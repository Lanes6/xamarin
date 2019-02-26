using winter.ViewModels;
using Storm.Mvvm.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace winter
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : BaseContentPage
	{
		public Home ()
		{
			InitializeComponent ();
            BindingContext = new SaisonViewModel();
        }
	}
}