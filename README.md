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

![explorer_3gBZbWaVpR](https://github.com/user-attachments/assets/f199c52e-bad3-4394-a821-81458edc381b)
![explorer_g2KYTgleza](https://github.com/user-attachments/assets/4726eb40-14ba-4131-805f-35012ca218ca)

### iOS Setup

Setup Info.plist:
Add `Icon files (iOS 5)` to the Information Property List
Add `CFBundleAlternateIcons` as a dictionary, it is used for alternative icons

Here's an example:

<img width="507" alt="Screenshot 2024-11-10 at 21 12 54" src="https://github.com/user-attachments/assets/32327b86-bfee-47f5-b23b-3711bf32b8f9">
<img width="264" alt="Screenshot 2024-11-10 at 21 13 28" src="https://github.com/user-attachments/assets/19b8379c-17fe-4641-93dd-7424d31a6141">

# ✨ Showcase

https://github.com/user-attachments/assets/52071061-c55c-4564-b880-29efab6a1749

# ✉️ Contact
[Telegram](https://t.me/dreamcestudio)

[Email](mailto:dreamcodestudio@yandex.com)

# 🔑 License

[Unity Asset Store EULA](https://unity.com/legal/as-terms)
