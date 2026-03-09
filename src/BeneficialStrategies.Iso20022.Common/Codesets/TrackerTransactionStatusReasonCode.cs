// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason for a status of a payment transaction in the tracker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8RJ1sPpPEemXaqBx8S4XSg")]
[Description(@"Provides the reason for a status of a payment transaction in the tracker.")]
[Derivations(typeof(TrackerTransactionStatusReason1Code))]
public enum TrackerTransactionStatusReasonCode
{
    /// <summary>
    /// In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G000&quot;.
    /// </summary>
    [EnumMember(Value = "G000")]
    [IsoId("_D11vIPpQEemXaqBx8S4XSg")]
    [Description(@"In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.")]
    PaymentTransferredAndTracked,
    
    /// <summary>
    /// In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_D7HQsPpQEemXaqBx8S4XSg")]
    [Description(@"In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.")]
    PaymentTransferredAndNotTracked,
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G002&quot;.
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_D9U3MPpQEemXaqBx8S4XSg")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.|In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.")]
    CreditDebitNotConfirmed,
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator.
    /// In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G003&quot;.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_D_jEwPpQEemXaqBx8S4XSg")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator.|In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.")]
    CreditPendingDocuments,
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_EBhasPpQEemXaqBx8S4XSg")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.")]
    CreditPendingFunds,
    
    /// <summary>
    /// Credit Transfer has been delivered to creditor agent with transaction&apos;s service obligations maintained.
    /// Encoded/decoded by serializers as &quot;G005&quot;.
    /// </summary>
    [EnumMember(Value = "G005")]
    [IsoId("_EDcGQPpQEemXaqBx8S4XSg")]
    [Description(@"Credit Transfer has been delivered to creditor agent with transaction's service obligations maintained.")]
    PaymentDeliveredAndSLAMaintained,
    
    /// <summary>
    /// Credit Transfer has been delivered to creditor agent without service level. Update will follow from the status originator.	
    /// Encoded/decoded by serializers as &quot;G006&quot;.
    /// </summary>
    [EnumMember(Value = "G006")]
    [IsoId("_ElsewPpQEemXaqBx8S4XSg")]
    [Description(@"Credit Transfer has been delivered to creditor agent without service level. Update will follow from the status originator.	")]
    DeliveredWithoutServiceLevel,
    
}
