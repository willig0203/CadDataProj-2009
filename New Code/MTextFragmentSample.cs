// (C) Copyright 2006  Tony Tanzillo,  http://www.caddzone.com
//
// This material may not be published or reproduced in any
// form, without the express written consent of the AUTHOR.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted, 
// provided that the above copyright notice appears in all copies and 
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting 
// documentation.
//
// CADDZONE.COM PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
// CADDZONE.COM SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  CADDZONE.COM 
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to 
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
//
// MText Fragment Sample
//
// This example shows how to use the ExplodeFragements() method of
// of the managed MText class, to strip formatting information from
// the contents of an MText entity.
//
// To run the example, create a new classlibrary project, and
// add this class. Build the project; start AutoCAD, draw some
// mtext, and use the editor to change the formatting of parts
// of the MTEXT (for example, change the font of some, but not
// all the text). 
//
// Next, NETLOAD the assembly contining this class; issue the 
// 'MTextFragmentSample' command and select the MTEXT object.
// The code will display both the value of the Contents property
// of the selected MTEXT along with the concatenation of the text 
// that was accumulated by the callback, and the number of mtext 
// fragments encountered.


using System ;
using System.Text;
using Autodesk.AutoCAD.Runtime ;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using AcadApp = Autodesk.AutoCAD.ApplicationServices.Application;


namespace CaddZone.AutoCAD.Samples
{
	/// <summary>
	/// Summary description for Class.
	/// </summary>
	public class Class
	{
		public Class()
		{
		}

		[CommandMethod("MTextFragmentSample")]
		static public void test() 
		{
			Editor ed = AcadApp.DocumentManager.MdiActiveDocument.Editor;
			ObjectId id = SelectObject("\nSelect MText entity: ", typeof(MText));
			if( ! id.IsNull )
			{
				s_data = new StringBuilder();
				s_count = 0;
				using ( Transaction tr = id.Database.TransactionManager.StartTransaction() )
				{
					MText mtext = (MText) tr.GetObject(id, OpenMode.ForRead);
					mtext.ExplodeFragments(new MTextFragmentCallback(FragmentCallback));
					ed.WriteMessage("\nMText.Contents: {0}", mtext.Contents);
					ed.WriteMessage("\n{0} MText fragments: {1}", s_count, s_data.ToString());
				}
			}
		}

		static private StringBuilder s_data = null;
		static private int s_count = 0;

		static MTextFragmentCallbackStatus FragmentCallback(MTextFragment fragment, object unused)
		{
			s_data.Append(fragment.Text);
			++ s_count;
			return MTextFragmentCallbackStatus.Continue;
		}

		static ObjectId SelectObject(string prompt, System.Type objectClass)
		{
			Editor e = AcadApp.DocumentManager.MdiActiveDocument.Editor;
			using ( Transaction tr = e.Document.Database.TransactionManager.StartTransaction() )
			{
				while( true )
				{
					PromptEntityResult res = e.GetEntity(prompt);
					if( res.Status != PromptStatus.OK )
						return ObjectId.Null;
					DBObject ob = tr.GetObject(res.ObjectId, OpenMode.ForRead);
					if( objectClass.IsAssignableFrom(ob.GetType()) )
						return res.ObjectId;
					e.WriteMessage("\nInvalid selection, {0} entity expected", 
						RXClass.GetClass(objectClass).DxfName);
				}
			}
		}
	}
}
