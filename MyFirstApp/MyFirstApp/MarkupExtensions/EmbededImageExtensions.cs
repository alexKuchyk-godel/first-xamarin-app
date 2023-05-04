using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace MyFirstApp.MarkupExtensions
{
    [ContentProperty(nameof(ResourseId))]
    public class EmbededImageExtensions : IMarkupExtension
    {
        public string ResourseId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(ResourseId))
            {
                return null;
            }

            return ImageSource.FromResource(ResourseId);
        }
    }
}
