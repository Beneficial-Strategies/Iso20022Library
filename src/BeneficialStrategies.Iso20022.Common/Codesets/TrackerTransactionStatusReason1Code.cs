// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason for a status of a payment transaction in the tracker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8QHecPpQEemXaqBx8S4XSg")]
[Description(@"Provides the reason for a status of a payment transaction in the tracker.")]
[DerivedFrom(typeof(TrackerTransactionStatusReasonCode))]
public enum TrackerTransactionStatusReason1Code
{
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G002&quot;.
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_3Ofz4fruEemIKt9hrQ9pJw")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.|In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.")]
    CreditDebitNotConfirmed = TrackerTransactionStatusReasonCode.CreditDebitNotConfirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G003&quot;.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_3Sb4sfruEemIKt9hrQ9pJw")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator.|In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.")]
    CreditPendingDocuments = TrackerTransactionStatusReasonCode.CreditPendingDocuments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_3ZrwMfruEemIKt9hrQ9pJw")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.")]
    CreditPendingFunds = TrackerTransactionStatusReasonCode.CreditPendingFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_30nYsfruEemIKt9hrQ9pJw")]
    [Description(@"In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.")]
    PaymentTransferredAndNotTracked = TrackerTransactionStatusReasonCode.PaymentTransferredAndNotTracked, // same ordinal as derivation source for type conversions
    
}
