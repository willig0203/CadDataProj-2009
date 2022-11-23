Public Class Form1


    Private Sub btnGetShortCuts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetShortCuts.Click

        Dim cls As clsUtil.Class1 = New clsUtil.Class1()

        Dim clsTbl As New clsUtil.Class1.shCt()

        Dim retArryLst As ArrayList = cls.GetShortcuts()

        For c = 0 To (retArryLst.Count - 1)

            clsTbl = retArryLst(c)

            Console.Write(clsTbl.link)
            Console.Write(", ")
            Console.WriteLine(clsTbl.args)
        Next

    End Sub

    Private Sub btnGetTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetTasks.Click
        Dim cls As clsUtil.Class1 = New clsUtil.Class1()

        Dim clsTbl As New clsUtil.Class1.tsk()

        Dim retArryLst As ArrayList = cls.GetTasks()

        For c = 0 To (retArryLst.Count - 1)

            clsTbl = retArryLst(c)

            Console.Write(clsTbl.appName)
            Console.Write(", ")
            Console.Write(clsTbl.accName)
            Console.Write(", ")
            Console.Write(clsTbl.appWorkDir)
            Console.Write(", ")
            Console.WriteLine(clsTbl.appTrigger)

        Next

    End Sub

    Private Sub btnGetDirs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDirs.Click

        Dim cls As clsUtil.Class1 = New clsUtil.Class1()
        Dim clsTbl As New clsUtil.Class1.dir()
        Dim retArryLst As ArrayList = cls.GetDirs()

        For c = 0 To (retArryLst.Count - 1)
            clsTbl = retArryLst(c)
            Console.WriteLine(clsTbl.appDir)
        Next

    End Sub

    Private Sub btnGetServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetServices.Click
        Dim cls As clsUtil.Class1 = New clsUtil.Class1()
        Dim clsTbl As New clsUtil.Class1.svc()
        Dim retArryLst As ArrayList = cls.getSvc()

        For c = 0 To (retArryLst.Count - 1)

            clsTbl = retArryLst(c)

            Console.Write(clsTbl.Description)
            Console.Write(", ")
            Console.Write(clsTbl.PathName)
            Console.Write(", ")
            Console.Write(clsTbl.ServiceType)
            Console.Write(", ")
            Console.Write(clsTbl.State)
            Console.Write(", ")
            Console.Write(clsTbl.StartMode)
            Console.Write(", ")
            Console.WriteLine(clsTbl.StartName)
        Next

    End Sub

    Private Sub btnGetDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDB.Click
        Dim cls As clsUtil.Class1 = New clsUtil.Class1()
        Dim clsTbl As New clsUtil.Class1.DB()
        'Dim retArryLst As System.Data.DataTable = cls.getDB()

        Dim retArryLst As ArrayList = cls.getDB("")

        For c = 0 To (retArryLst.Count - 1)

            clsTbl = retArryLst(c)

            Console.Write(clsTbl.TABLE_QUALIFIER)
            Console.Write(", ")
            Console.WriteLine(clsTbl.TABLE_NAME)

        Next

    End Sub

    Private Sub btnEventLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEventLogs.Click
        Dim cls As clsUtil.Class1 = New clsUtil.Class1()
        Dim clsTbl As New clsUtil.Class1.evntLog()
        'Dim retArryLst As System.Data.DataTable = cls.getDB()

        Dim retArryLst As ArrayList = cls.getEL()

        For c = 0 To (retArryLst.Count - 1)

            clsTbl = retArryLst(c)

            Console.WriteLine(clsTbl.Name)
        Next

    End Sub

    Private Sub btnIIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIIS.Click
        Dim cls As clsUtil.Class1 = New clsUtil.Class1()
        'Dim clsTbl As New clsUtil.Class1.evntLog()
        'Dim retArryLst As System.Data.DataTable = cls.getDB()

        'Dim retArryLst As String = 
        'cls.GetSites("DFHLSCASQL01")

    End Sub





End Class
