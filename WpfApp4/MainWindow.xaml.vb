Class MainWindow
    Public Sub New()
        InitializeComponent()

        DataContext = New With {
            .Productos =
                New List(Of Producto) From
                    {
                        New Producto With {.Nombre = "Manzanas", .Precio = 2.5, .Unidad = "Kg", .Imagen = "https://estaticos.miarevista.es/media/cache/1140x_thumb/uploads/images/gallery/59144d795cafe812663c986a/razonescomermanzana-int.jpg"},
                        New Producto With {.Nombre = "Naranjas", .Precio = 4, .Unidad = "2 Kg", .Imagen = "https://imagenes.elpais.com/resizer/fIjv1yxF5Uay_dRvO8amBE02AXA=/980x735/filters:focal(1890x1663:1900x1673)/cloudfront-eu-central-1.images.arcpublishing.com/prisa/GDNU4QIWVJHYZNZEACEWYQXZLE.jpg"}
                    }
            }

    End Sub


End Class

Public Class Producto
    Public Property Nombre As String
    Public Property Precio As Decimal
    Public Property Unidad As String
    Public Property Imagen As String
End Class
