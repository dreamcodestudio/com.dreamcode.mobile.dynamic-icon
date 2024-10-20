# 🎯 What is Dynamic Icon package?
Lets users share content quickly and easily using their favorite apps.

[![card](https://github.com/user-attachments/assets/3cddca93-5565-4748-8c96-18090b66f0f6)](https://assetstore.unity.com/packages/tools/integration/easy-share-289206)

# 💻 Usage
```csharp
using DreamCode.EasyShare;

ShareService.SendText(
    message: "Content with text",
    sharedByActivity: packageName => { Debug.Log("SendBinaryContent callback:" + packageName); });

//
ScreenCapture.CaptureScreenshot("Test.png");
var imagePath = Path.Combine(Application.persistentDataPath, "Test.png");

ShareService.SendBinaryContent(
                filePath: imagePath,
                mimeType: MimeTypeNames.Image,
                message: "Content with image",
                sharedByActivity: packageName => { Debug.Log($"SendBinaryContent:{packageName}"); });

```
### Android Setup

To set up `FileProvider` for native sharing on Android, follow these steps.

You need to define a `FileProvider` in your `AndroidManifest.xml` file by path:

`Assets > Plugins > Android`

Here's an example:

```xml
<?xml version="1.0" encoding="utf-8"?>
<manifest
    xmlns:android="http://schemas.android.com/apk/res/android"
    package="com.unity3d.player"
    xmlns:tools="http://schemas.android.com/tools">
    <application>
        <activity android:name="com.unity3d.player.UnityPlayerActivity"
                  android:theme="@style/UnityThemeSelector">
            <intent-filter>
                <action android:name="android.intent.action.MAIN" />
                <category android:name="android.intent.category.LAUNCHER" />
            </intent-filter>
            <meta-data android:name="unityplayer.UnityActivity" android:value="true" />
        </activity>
    
    <provider android:name="androidx.core.content.FileProvider" android:authorities="com.IndieYP.JumpClub.jump.fall.hop.provider" android:exported="false" android:grantUriPermissions="true">
      <meta-data android:name="android.support.FILE_PROVIDER_PATHS" android:resource="@xml/file_provider_paths" />
    </provider>

    </application>
</manifest>
```

`android:authorities` should be set to `${applicationId}.provider` where `applicationId` is your package name.

# ✨ Showcase
https://github.com/user-attachments/assets/873a488f-ebed-4362-aa14-2d3794880172

# ✉️ Contact
[Telegram](https://t.me/dreamcestudio)

[Email](mailto:dreamcodestudio@yandex.com)

# 🔑 License

[Unity Asset Store EULA](https://unity.com/legal/as-terms)
