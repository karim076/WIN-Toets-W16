using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Eindtoets_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var jobs = new List<Job>();
            jobs.Add(new Job { Title = "IT Expert", Department = "IT", Salary = 3000 });
            jobs.Add(new Job { Title = "Software Expert", Department = "IT", Salary = 3200 });
            jobs.Add(new Job { Title = "Sales agent", Department = "Sales", Salary = 2900 });
            jobs.Add(new Job { Title = "Customer service", Department = "Sales", Salary = 2300 });
            jobs.Add(new Job { Title = "Internal service", Department = "IT", Salary = 2500 });
            jobs.Add(new Job { Title = "Account manager", Department = "Sales", Salary = 4000 });
            //jobTitleEl.ItemsSource = jobs;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var jobs = new List<Job>();
            jobs.Add(new Job { Title = "IT Expert", Department = "IT", Salary = 3000 });
            jobs.Add(new Job { Title = "Software Expert", Department = "IT", Salary = 3200 });
            jobs.Add(new Job { Title = "Sales agent", Department = "Sales", Salary = 2900 });
            jobs.Add(new Job { Title = "Customer service", Department = "Sales", Salary = 2300 });
            jobs.Add(new Job { Title = "Internal service", Department = "IT", Salary = 2500 });
            jobs.Add(new Job { Title = "Account manager", Department = "Sales", Salary = 4000 });
            string title = (this.jobTitleEl.SelectedItem as ComboBoxItem).Content.ToString();
            foreach (var job in jobs)
            {
                if(job.Title == title)
                {
                    salary.Text = Convert.ToString(job.Salary);
                }
            }
        }
    }
}
