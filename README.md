## StrapButtonSharp

[UIButton-Bootstrap](https://github.com/OskarGroth/UIButton-Bootstrap) For Xamarin.iOS 

## Introduction

[UIButton-Bootstrap](https://github.com/OskarGroth/UIButton-Bootstrap) is a simple UIButton category that adds nice and flat Bootstrap 3.0 button styles, without any subclass or image.
It is of Quartz Core drawing only and highly customizable.
	
StrapButtonSharp is a Xamarin.iOS port of UIButton-Bootstrap.

## Preparation
  • Copy FontAwesome.ttf to your project directory and change its build action to BundleResource.
  
  • Use any text editor you like to open Info.plist, and then add the content below to the <dic> element.
  
```Xml
	<key>UIAppFonts</key>
	<array>
		<string>FontAwesome.ttf</string>
	</array>
	<key>UIAppFonts</key>
 ```
After your modification, the Info.plist may like this:
```Xml
	<?xml version="1.0" encoding="UTF-8"?>
	<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
	<plist version="1.0">
	<dict>
	  <key>UIAppFonts</key>
	  <array>
		<string>FontAwesome.ttf</string>
	  </array 
		<key>CFBundleDisplayName</key>
		<string>StrapButtonSharpSample</string>
		<key>CFBundleIdentifier</key>
		<string>com.your-company.StrapButtonSharpSample</string>
		.................
```
 These modifications tells the iOS operation that we want to use a custom font.
	
  • Copy UIButtonExtension to any of directories in your project directly.

## How to use
  • Apply Bootstrap style to your UIButton:
```CSharp
	yourButton.DefaultStyle();
	yourButton.PrimaryStyle();
```
	
  • Add Bootstrap icon to UIButton:
```CSharp
	yourButton.AddAwesomeIcon(AwesomeIcon.DownloadAlt, false);
```
The latter parameter is used to specify whether the icon is placed before(true) or after(false) the text.

## 简介
[UIButton-Bootstrap](https://github.com/OskarGroth/UIButton-Bootstrap)是一个能为按钮添加美观的扁平化Boostrap 3.0样式的简单UIButton类。
它不含任何子类化或者嵌入位图，并且它是纯粹由Quartz Core渲染的。与此同时，它提供很高的的可定制性。
	
StrapButtonSharp是UIButton-Bootstrap在Xamarin.iOS上的移植。
	
## 食用前滴准备:
  • 复制FontAwesome.ttf 到你的工程目录下，生成操作改为BundleResource
  
  • 使用(Xml)文本编辑器打开Info.plist文件，在dic元素下添加
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
	  </array>
		<key>CFBundleDisplayName</key>
		<string>StrapButtonSharpSample</string>
		<key>CFBundleIdentifier</key>
		<string>com.your-company.StrapButtonSharpSample</string>
		.................
```
这一步是为了让iOS知道我们要使用的自定义字体
	
  • 直接复制UIButtonExtension文件到你的工程任何位置
  
## 如何食用:
   • 让UIButton使用Bootstrap样式：
```CSharp
	yourButton.DefaultStyle();
	yourButton.PrimaryStyle();
```
   
   •为UIButton添加Bootstrap图标
```CSharp
	yourButton.AddAwesomeIcon(AwesomeIcon.DownloadAlt, false);
```
后面那个参数是指定图标是放在文本前面(true)还是后面(false)
