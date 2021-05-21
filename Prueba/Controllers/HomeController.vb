Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Quienes somos.? Basicamenten un par de Personas con tiempo libre."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Nuestra Pagina de contacto."

        Return View()
    End Function

    Function Img() As ActionResult
        ViewData("Message") = "En esta pagina se encuentran todas las imagenes agregadas."
        Return View()
    End Function
End Class
