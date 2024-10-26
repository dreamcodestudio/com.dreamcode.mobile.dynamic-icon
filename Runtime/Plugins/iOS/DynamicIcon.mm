#import "UnityFramework/UnityFramework-Swift.h"

extern "C" {

void _DI_Setup(const char** icons, int count) {
    NSMutableArray *iconArray = [NSMutableArray array];
    for(int i = 0; i < count; i++) {
        [iconArray addObject:[NSString stringWithUTF8String:icons[i]]];
    }
    
    [[DynamicIcon shared] SetupWithIcons:iconArray];
}

void _DI_ApplyAlternateIcon(const char* cIconName) {
    NSString *iconName = [NSString stringWithUTF8String:cIconName];
    [[DynamicIcon shared] ApplyAlternateIconWithIconName:iconName];
}

}
