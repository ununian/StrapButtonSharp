## StrapButtonSharp

[StrapButtonSharp](https://github.com/OskarGroth/UIButton-Bootstrap) For Xamarin.iOS 

##食用前滴准备:
  •复制FontAwesome.ttf 到你的工程目录下，生成操作改为BundleResource
  
  •使用(Xml)文本编辑器打开Info.plist文件，在dic元素下添加
  ```Xml
  <key>UIAppFonts</key>
  <array>
    <string>FontAwesome.ttf</string>
  </array><key>UIAppFonts</key>
  ```
  让Info.plist文件看起来像
   ```Xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
  <key>UIAppFonts</key>
  <array>
    <string>FontAwesome.ttf</string>
  </array><key>UIAppFonts</key>
	<array>
		<string>FontAwesome.ttf</string>
	</array>
	<key>CFBundleDisplayName</key>
	<string>StrapButtonSharpSample</string>
	<key>CFBundleIdentifier</key>
	<string>com.your-company.StrapButtonSharpSample</string>
	.................
  ```
  这一步是为了让iOS知道我们要使用的自定义字体
  
  •直接复制UIButtonExtension文件到你的工程任何位置
  
##如何食用:
   •让UIButton使用Bootstrap样式
   ```CSharp
   yourButton.DefaultStyle();
   yourButton.PrimaryStyle();
   ```
   
   •为UIButton添加Bottstrap图标
   ```CSharp
    yourButton.AddAwesomeIcon(AwesomeIcon.DownloadAlt, false);
   ```
   后面那个参数是指定图标是放在文本前面(true)还是后面(false)
