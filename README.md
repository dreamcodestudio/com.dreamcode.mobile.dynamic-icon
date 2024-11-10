# 🎯 What is Dynamic Mobile Icon package?
The best way to dynamically changing app icon.

# 💻 Usage
```csharp
using DreamCode.DynamicIcon;

string[] icons =
    {
        "UnityPlayerActivity",
        "AlternativeIcon1",
        "AlternativeIcon2",
        "AlternativeIcon3",
    };

IconChangerService.Setup(icons);
// Set alternative icon
IconChangerService.ApplyAlternateIcon("AlternativeIcon3");
// Reset to default icon
IconChangerService.ApplyAlternateIcon("UnityPlayerActivity");

```
### Android Setup

Define a `activity-alias` with custom icons in your `AndroidManifest.xml` file by path:

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

        <activity-alias
                android:exported="true"
                android:icon="@mipmap/ic_launcher_1"
                android:name=".AlternativeIcon1"
                android:enabled="false"
                android:targetActivity="com.unity3d.player.UnityPlayerActivity">
            <intent-filter>
                <action android:name="android.intent.action.MAIN" />
                <category android:name="android.intent.category.LAUNCHER" />
            </intent-filter>
        </activity-alias>
        <activity-alias
                android:exported="true"
                android:icon="@mipmap/ic_launcher_2"
                android:name=".AlternativeIcon2"
                android:enabled="false"
                android:targetActivity="com.unity3d.player.UnityPlayerActivity">
            <intent-filter>
                <action android:name="android.intent.action.MAIN" />
                <category android:name="android.intent.category.LAUNCHER" />
            </intent-filter>
        </activity-alias>
        <activity-alias
                android:exported="true"
                android:icon="@mipmap/ic_launcher_3"
                android:name=".AlternativeIcon3"
                android:enabled="false"
                android:targetActivity="com.unity3d.player.UnityPlayerActivity">
            <intent-filter>
                <action android:name="android.intent.action.MAIN" />
                <category android:name="android.intent.category.LAUNCHER" />
            </intent-filter>
        </activity-alias>
    </application>
</manifest>
```

Add `DynamicIcon.androidlib` in `Assets > Plugins > Android`:

### iOS Setup

# ✨ Showcase
Todo

# ✉️ Contact
[Telegram](https://t.me/dreamcestudio)

[Email](mailto:dreamcodestudio@yandex.com)

# 🔑 License

[Unity Asset Store EULA](https://unity.com/legal/as-terms)
