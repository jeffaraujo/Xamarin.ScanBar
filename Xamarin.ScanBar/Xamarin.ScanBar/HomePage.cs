using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Xamarin.ScanBar
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {

            Button scanBtn = new Button()
            {
                Text = "Escanear Código de Barras",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            scanBtn.Clicked += async (sender, args) =>
            {
                var scanResult = await Acr.BarCodes.BarCodes.Instance.Read();

                if (!scanResult.Success)
                {
                    await this.DisplayAlert("Alerta!", "Erro! \n Falha ao ler o Código", "OK");
                }
                else
                {
                    await this.DisplayAlert("Scan realizado com sucesso!", String.Format("Formato do Cod. Barras: {0} \n Barcode Value: {1}", scanResult.Format, scanResult.Code), "OK");
                }

            };



            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Children = {
                    scanBtn
                }
            };
        }
    }
}
