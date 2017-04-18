#addin "Cake.ResxConverter"

using ResxConverter.Mobile;

Task("RunResxConverter")
  .Does(() =>
{
    var resxFolder = "src/shared/Xamarin.ResxConverter.Sample.Resx/StringResources";
    var androidOutputFile = "src/android/Resources";
    var iosOutputFile = "src/ios/Resources";

    ResxConverters.Android.Convert(resxFolder, androidOutputFile);
    ResxConverters.iOS.Convert(resxFolder, iosOutputFile);
});

RunTarget("RunResxConverter");