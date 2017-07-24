using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using UIKit;
namespace PayGuardian
{
    [Native]
    public enum CardReadErrorCode : ulong
    {
        MSRBadRead,
        ChipBadRead,
        MSRCancelled,
        MSRButtonPressed,
        MSRInvalidPrompt,
        EncryptionFailed,
        UnableToOpenDevice,
        PINEntryCancelled,
        PINEntryInvalidLength,
        PINEntryInvalidIndex,
        PINKeyPressed,
        PINInvalidPrompt,
        PINRequestDeclined
    }

    [Native]
    public enum BridgeCommResponseCode : ulong
    {
        Success = 0,
        Cancel = 1,
        Error = 2,
        DeniedByCustomersBank = 30032
    }

    [Native]
    public enum PayGuardianTransactionState : ulong
    {
        NotStarted,
        WaitingForCard,
        ReadingCard,
        ChipCardWithUnreadChipSwiped,
        CardReadWithBrokenChip,
        CardReadWithError,
        WaitingForGateway,
        RespondingToCard,
        Voiding,
        Finished
    }
}
