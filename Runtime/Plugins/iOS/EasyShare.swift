//
//  Sharesheet.swift
//  UnityFramework
//
//  Created by Yaroslav Petrichka on 06.06.2024.
//

import Foundation

@objc public class EasyShare: NSObject {
    @objc public static let shared = EasyShare()
    
    @objc public func SendText(
        message: String,
        viewController: UIViewController
    ) {
        var activityItems = [Any]()
        activityItems.append(
            message
        )
        
        
        let activityController = UIActivityViewController(
            activityItems: activityItems,
            applicationActivities: nil
            
        )
        
        let unityListener = "ShareListener"
        activityController.completionWithItemsHandler = { (
            activityType: UIActivity.ActivityType?,
            completed:
                Bool,
            arrayReturnedItems: [Any]?,
            error: Error?
        ) in
            let clickedPackageName = activityType?.rawValue ?? ""
            if completed {
                UnityFramework.getInstance().sendMessageToGO(
                    withName: unityListener,
                    functionName: "OnShareCompleted",
                    message: clickedPackageName
                )
            } else {
                UnityFramework.getInstance().sendMessageToGO(
                    withName: unityListener,
                    functionName: "OnShareCompleted",
                    message: ""
                    )
            }
        }
        
        if let popover = activityController.popoverPresentationController {
            popover.sourceRect = CGRect(
                x: UIScreen.main.bounds.width / 2,
                y: UIScreen.main.bounds.height / 2,
                width: 0,
                height: 0
            )
            popover.sourceView = viewController.view
            popover.permittedArrowDirections = UIPopoverArrowDirection(
                rawValue: 0
            )
         
         }
        
        DispatchQueue.main.async {
            viewController.present(
                activityController,
                animated: true,
                completion: nil
            )
        }
    }
    
    @objc public func SendBinaryContent(
        message: String,
        filePath: String,
        viewController: UIViewController
    ) {
        var activityItems = [Any]()
        
        let fileUrl = NSURL.fileURL(
            withPath: filePath
        );
        
        activityItems.append(
            fileUrl
        )
        activityItems.append(
            message
        )
        
        
        let activityController = UIActivityViewController(
            activityItems: activityItems,
            applicationActivities: nil
            
        )
        
        let unityListener = "ShareListener"
        activityController.completionWithItemsHandler = { (
            activityType: UIActivity.ActivityType?,
            completed:
                Bool,
            arrayReturnedItems: [Any]?,
            error: Error?
        ) in
            let clickedPackageName = activityType?.rawValue ?? ""
            if completed {
                UnityFramework.getInstance().sendMessageToGO(
                    withName: unityListener,
                    functionName: "OnShareCompleted",
                    message: clickedPackageName
                )
            } else {
                UnityFramework.getInstance().sendMessageToGO(
                    withName: unityListener,
                    functionName: "OnShareCompleted",
                    message: ""
                    )
            }
        }
        
        if let popover = activityController.popoverPresentationController {
            popover.sourceRect = CGRect(
                x: UIScreen.main.bounds.width / 2,
                y: UIScreen.main.bounds.height / 2,
                width: 0,
                height: 0
            )
            popover.sourceView = viewController.view
            popover.permittedArrowDirections = UIPopoverArrowDirection(
                rawValue: 0
            )
         
         }
        
        DispatchQueue.main.async {
            viewController.present(
                activityController,
                animated: true,
                completion: nil
            )
        }
    }
}
