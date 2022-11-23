Option Explicit On 

Imports System.Windows.Forms

Imports Autodesk.AutoCAD.Runtime

'Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
'Imports Autodesk.AutoCAD.DatabaseServices.XrefObjectId


Imports rnsCadDataProj.nsMods

<Assembly: ExtensionApplication(GetType(nsCadDataProj.CadDataProj))> 
<Assembly: CommandClass(GetType(nsCadDataProj.CadDataProjCommands))> 

Namespace nsCadDataProj

    Public Class CadDataProj
        Implements Autodesk.AutoCAD.Runtime.IExtensionApplication

        Public Sub Initialize() Implements Autodesk.AutoCAD.Runtime.IExtensionApplication.Initialize
            ' Create an AutoCAD toolbar with 4 buttons linked to the 4 commands defined below
            Dim helloModule As System.Reflection.Module = System.Reflection.Assembly.GetExecutingAssembly().GetModules()(0)
            Dim helloModulePath As String = helloModule.FullyQualifiedName
            Try
                helloModulePath = helloModulePath.Substring(0, helloModulePath.LastIndexOf("\"))
                helloModulePath = helloModulePath.Substring(0, helloModulePath.LastIndexOf("\"))
            Catch
                MessageBox.Show("Error with Module Path")
                Exit Sub
            End Try
            Dim acadApp As Autodesk.AutoCAD.Interop.AcadApplication = Autodesk.AutoCAD.ApplicationServices.Application.AcadApplication
            Dim hwTb As Autodesk.AutoCAD.Interop.AcadToolbar = acadApp.MenuGroups.Item(0).Toolbars.Add("CadDataProj")

            Dim tbBut0 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(0, "PltCurrLayoutFit", "Plot The Current LayoutFit", "_PltCurrLayoutFit ")
            tbBut0.SetBitmaps(helloModulePath + "\tbBut0.bmp", helloModulePath + "\tbBut0.bmp")

            Dim tbBut1 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(1, "PltCurrLayout1to1", "Plot The Current Layout1to1", "_PltCurrLayout1to1 ")
            tbBut1.SetBitmaps(helloModulePath + "\tbBut0.bmp", helloModulePath + "\tbBut0.bmp")

            Dim tbBut2 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(2, "CadDataProjForm", "Cad Data Proj Form", "_CadDataProjForm ")
            tbBut2.SetBitmaps(helloModulePath + "\tbBut1.bmp", helloModulePath + "\tbBut1.bmp")

            Dim tbBut3 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(3, "CurrLayoutDWF3fit", "Plot The Current Layout DWF3fit", "_CurrLayoutDWF3fit ")
            tbBut3.SetBitmaps(helloModulePath + "\tbBut0.bmp", helloModulePath + "\tbBut0.bmp")

            Dim tbBut4 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(4, "CurrLayoutDWF31to1", "Plot The Current Layout DWF31to1", "_CurrLayoutDWF31to1 ")
            tbBut4.SetBitmaps(helloModulePath + "\tbBut0.bmp", helloModulePath + "\tbBut0.bmp")

            Dim tbBut5 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(5, "AttDwgName", "AttDwgName", "_AttDwgName ")
            tbBut5.SetBitmaps(helloModulePath + "\tbBut0.bmp", helloModulePath + "\tbBut0.bmp")

            Dim tbBut6 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(6, "AttDwgLayout", "AttDwgLayout", "_AttDwgLayout ")
            tbBut6.SetBitmaps(helloModulePath + "\tbBut0.bmp", helloModulePath + "\tbBut0.bmp")

            Dim tbBut7 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(7, "AttDate", "AttDate", "_AttDate ")
            tbBut7.SetBitmaps(helloModulePath + "\tbBut0.bmp", helloModulePath + "\tbBut0.bmp")

            Dim tbBut8 As Autodesk.AutoCAD.Interop.AcadToolbarItem = hwTb.AddToolbarButton(8, "BlockMan", "BlockMan", "_BlockMan ")
            tbBut8.SetBitmaps(helloModulePath + "\tbBut1.bmp", helloModulePath + "\tbBut1.bmp")

        End Sub

        Public Sub Terminate() Implements Autodesk.AutoCAD.Runtime.IExtensionApplication.Terminate
        End Sub

    End Class

    Public Class CadDataProjCommands

        <Autodesk.AutoCAD.Runtime.CommandMethod("PltCurrLayoutFit")> _
                        Public Sub pltCurrLayoutCommand()
            modPlot.pltCurrLayout(StdScaleType.ScaleToFit, ucDwgLstTbLst.chkbxFade255.Checked)
        End Sub

        <Autodesk.AutoCAD.Runtime.CommandMethod("PltCurrLayout1to1")> _
                Public Sub pltCurrLayout1to1Command()
            modPlot.pltCurrLayout(StdScaleType.StdScale1To1, ucDwgLstTbLst.chkbxFade255.Checked)
        End Sub

        <Autodesk.AutoCAD.Runtime.CommandMethod("CadDataProjForm", CommandFlags.Session)> _
        Public Sub CadDataProjFormCommand()
            Dim dlg As New rnsCadDataProj.nsForms.frmMain
            dlg.ShowDialog()
        End Sub

        <Autodesk.AutoCAD.Runtime.CommandMethod("CurrLayoutDWF3fit")> _
        Public Sub CurrLayoutDWF3fit()
            pltCurrLayoutDWF3(StdScaleType.ScaleToFit, ucDwgLstTbLst.chkbxFade255.Checked)

            ' MessageBox.Show("My Extra Button")
        End Sub

        <Autodesk.AutoCAD.Runtime.CommandMethod("CurrLayoutDWF31to1")> _
       Public Sub CurrLayoutDWF31to1()
            pltCurrLayoutDWF3(StdScaleType.StdScale1To1, ucDwgLstTbLst.chkbxFade255.Checked)
            ' MessageBox.Show("My Extra Button")
        End Sub

        <Autodesk.AutoCAD.Runtime.CommandMethod("AttDwgName")> _
       Public Sub AttDwgName()
            FileNametoAtt(True, False)
        End Sub

        <Autodesk.AutoCAD.Runtime.CommandMethod("AttDwgLayout")> _
       Public Sub AttDwgLayout()
            FileNametoAtt(False, True)
        End Sub

        <Autodesk.AutoCAD.Runtime.CommandMethod("AttDate")> _
       Public Sub AttDate()
            nsMods.DateToAtt(False)
        End Sub

        <Autodesk.AutoCAD.Runtime.CommandMethod("BlockMan", CommandFlags.Session)> _
        Public Sub showBlockManFrm()
            Dim frmBlocMan As New rnsCadDataProj.nsForms.frmBlockMan
            frmBlocMan.Show()
        End Sub

    End Class

End Namespace






' Copyright 2004 by Autodesk, Inc.

'Permission to use, copy, modify, and distribute this software in
'object code form for any purpose and without fee is hereby granted, 
'provided that the above copyright notice appears in all copies and 
'that both that copyright notice and the limited warranty and
'restricted rights notice below appear in all supporting 
'documentation.

'AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
'AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
'MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC. 
'DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
'UNINTERRUPTED OR ERROR FREE.

'Use, duplication, or disclosure by the U.S. Government is subject to 
'restrictions set forth in FAR 52.227-19 (Commercial Computer
'Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
'(Rights in Technical Data and Computer Software), as applicable.

' Hello World VB.NET sample
' by Cyrille Fauvel - Autodesk Developer Technical Services
' Copyright Autodesk (c) 2003
