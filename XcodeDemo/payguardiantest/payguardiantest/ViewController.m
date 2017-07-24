#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController

@synthesize _transaction;
@synthesize _request;

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    
    self.view.backgroundColor = [UIColor blueColor];
    
    _request = [[BPNPaymentRequest alloc] initInvoiceNumber:@"1234" pnRefNum:nil amount:[NSDecimalNumber decimalNumberWithString:@"5.00"] tipAmount:[NSDecimalNumber decimalNumberWithString:@"1.00"] cashBackAmount:nil tenderType:TENDER_TYPE_CREDIT transactionType:TRANSACTION_TYPE_SALE username:@"paulpgtest" password:@"57!sE@3Fm" merchantCode:@"682000" merchantAccountCode:@"682001" paymentAccountNumber:nil token:nil expirationDate:nil terminalType:TERMINAL_TYPE_INGENICO_BLUETOOTH industryType:TRANSACTION_INDUSTRY_TYPE_RESTAURANT disableEmv:NO testMode:YES];
    _transaction = [[PayGuardianTransaction alloc] initWithPaymentRequest:_request];
    
    [_transaction runOnCompletion:^(BPNPayment* payment, NSError* error) {
        //Run on completion
    } onStateChanged:^(PayGuardianTransactionState state) {
        //State changed
    }];
}

@end
