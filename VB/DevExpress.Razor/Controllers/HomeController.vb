Imports System.Web.Mvc
Imports DevExpress.Razor.Models
Imports System.Web.Script.Serialization

Namespace DevExpress.Razor.Controllers

    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
            Return View()
        End Function

        Public Function CallbackPanelPartial() As ActionResult
            ViewData("Data") = GetSerializationObject()
            Return PartialView("CallbackPanelPartial")
        End Function

        Private Function GetSerializationObject() As MyData
            Dim jsonText As String = Request.Params("SerializationData")
            If String.IsNullOrEmpty(jsonText) Then Return Nothing
            Dim data As MyData = Nothing
            Try
                data = New JavaScriptSerializer().Deserialize(Of MyData)(jsonText)
            Catch
                ViewData("ErrorMessage") = "Incorrect data"
            End Try

            Return data
        End Function
    End Class
End Namespace
