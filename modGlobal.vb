Option Explicit On 

Imports rnsCadDataProj.nsUserCtls
Imports rnsCadDataProj.nsDataComp

Namespace nsMods

    Module modGlobal


        'Dim file As New System.IO.StreamReader("C:\DataLinks" & "\DBTest.txt")
        'Dim words As String = file.ReadToEnd() : file.Close()

        Public words As String = "Data Source=DFHLSCASQL01;Initial Catalog=Document Control;Integrated Security=True"

        ' user controls
        Public ucE001PIN As New ucE001PIN
        Public ucE044DRN As New ucE044DRN
        Public ucE045ECPNI As New ucE045ECPNI
        Public ucE046CRN As New ucE046CRN
        Public ucE037ECO As New ucE037ECO
        Public ucE025BomItmMstr As New ucE025BomItmMstr
        Public ucBLManagment As New ucBLManagment
        Public ucDwgLstTbLst As New ucDwgLstTbLst
        ' Public ucOther As New ucOther

        ' Data Component

        'Public daComp As New DataComp
        Public SqlDaComp As New cSqlDataComp

        ' Vars
        Public drnID As String : Public crnID As String : Public ecoID As String : Public bomID As String : Public echpniID As String
        Public pinID As String

        Public rOnly As Boolean = False
        Public pathStrToHandBook As String = "C:\Gary\Standard Drawings\Drawings\-1. Engineering Procedures Handbook\"
        Public FolderName As String : Public OpenFileName As String : Public OpenFileNames As String()
        Public cloneTable As System.data.DataTable

        Public dvE044DRN As DataView



        ' Reports
        'Public rptE044DRN1 As New rptE044DRN

        ' Public PassedDataTable As DataTable
        ' Public E044drnClone As DataTable = SqlDaComp.DataSet11.E044DocumentReleaseNotice.Clone
        ' Public E044drnClone As DataTable = SqlDaComp.DataSet11.E044DocumentReleaseNotice.Clone



    End Module

End Namespace
