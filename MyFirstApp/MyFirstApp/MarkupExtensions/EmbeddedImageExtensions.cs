using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp.MarkupExtensions
{
    [ContentProperty(nameof(ResourceId))]
    public class EmbeddedImageExtensions : IMarkupExtension
    {
        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return string.IsNullOrEmpty(ResourceId) ? null : ImageSource.FromResource(ResourceId);
        }
    }
}