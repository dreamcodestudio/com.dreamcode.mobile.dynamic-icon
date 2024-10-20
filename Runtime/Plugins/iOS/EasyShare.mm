#import "UnityFramework/UnityFramework-Swift.h"

extern "C" {

void _ES_SendBinaryContent(char* cMessage, char* cFilePath) {
    NSString *message = [[NSString alloc] initWithUTF8String:cMessage];
    NSString *filePath = [[NSString alloc] initWithUTF8String:cFilePath];
    
    UIViewController *viewController = UnityGetGLViewController();
    [[EasyShare shared] SendBinaryContentWithMessage:message filePath:filePath viewController:viewController];
    }

void _ES_SendText(char* cMessage) {
    NSString *message = [[NSString alloc] initWithUTF8String:cMessage];
    
    UIViewController *viewController = UnityGetGLViewController();
    [[EasyShare shared] SendTextWithMessage:message viewController:viewController];
    }

}
