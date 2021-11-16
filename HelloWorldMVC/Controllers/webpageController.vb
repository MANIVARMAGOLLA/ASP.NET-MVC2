Imports System.Web.Mvc

Namespace Controllers
    Public Class webpageController
        Inherits Controller

        ' GET: webpage
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace