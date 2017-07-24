#import <UIKit/UIKit.h>
#import <PayGuardian_SDK/PayGuardian_SDK.h>

@interface ViewController : UIViewController

@property BPNPaymentRequest* _request;
@property PayGuardianTransaction* _transaction;
@property RBAConnectionQueue* queue;

@end

