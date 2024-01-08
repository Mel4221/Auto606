using System;
using Facturas;
namespace Auto606
{
    public partial class VentanaPrincipal : Gtk.Window
    {
        public VentanaPrincipal() :
        base(Gtk.WindowType.Toplevel) => this.Build();

        protected void OnFuncionAction1Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Working...");
        }
    }
}
