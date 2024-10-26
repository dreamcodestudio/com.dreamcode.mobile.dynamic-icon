//
import Foundation

@objc public class DynamicIcon: NSObject {
    @objc public static let shared = DynamicIcon()
    
    @objc public func Setup(icons: [String]) {
        UserDefaults.standard.set(icons, forKey: "iconsDI")
    }
    
    @objc public func ApplyAlternateIcon(iconName: String) {
        guard let icons = UserDefaults.standard.stringArray(forKey: "iconsDI"), icons.contains(iconName) else {
            print("IconChanger: Icons not setup")
            return
        }
        if iconName == UIApplication.shared.alternateIconName {
            return
        }
        UIApplication.shared.setAlternateIconName(iconName) { error in
            if let error = error {
                print("IconChanger: Failed to change app icon:\(error.localizedDescription)")
            }
        }
        UserDefaults.standard.set(icons, forKey: "iconsDI")
    }
}
