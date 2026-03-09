// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason for a payment status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iL_l8KXaEeaBtJ1HvhzRtg")]
[Description(@"Provides the reason for a payment status.")]
[DerivedFrom(typeof(ExternalPaymentStatusReasonCode))]
public enum PaymentStatusReason2Code
{
    /// <summary>
    /// The transaction processing cannot be completed the same day.
    /// Encoded/decoded by serializers as &quot;G002&quot;.
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_m3wxgaXaEeaBtJ1HvhzRtg")]
    [Description(@"The transaction processing cannot be completed the same day.")]
    CreditDebitNotConfirmed = ExternalPaymentStatusReasonCode.CreditDebitNotConfirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit to the creditor&apos;s account is pending as status Originator is waiting for funds provided via a cover.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_m8ReEaXaEeaBtJ1HvhzRtg")]
    [Description(@"Credit to the creditor's account is pending as status Originator is waiting for funds provided via a cover.")]
    CreditPendingFunds = ExternalPaymentStatusReasonCode.CreditPendingFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure maintaining the transaction’s service obligations.
    /// Encoded/decoded by serializers as &quot;G000&quot;.
    /// </summary>
    [EnumMember(Value = "G000")]
    [IsoId("_nGkpkaXaEeaBtJ1HvhzRtg")]
    [Description(@"The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure maintaining the transaction’s service obligations.")]
    PaymentTransferredAndSLAMaintained = ExternalPaymentStatusReasonCode.PaymentTransferredAndSLAMaintained, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure where the transaction’s service obligations may no longer be guaranteed.
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_nLJnkaXaEeaBtJ1HvhzRtg")]
    [Description(@"The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure where the transaction’s service obligations may no longer be guaranteed.")]
    PaymentTransferredAndSLANoLongerMaintained = ExternalPaymentStatusReasonCode.PaymentTransferredAndSLANoLongerMaintained, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In an FI to FI Customer Credit Transfer: Credit to creditor&apos;s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation.
    /// Encoded/decoded by serializers as &quot;G003&quot;.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_eqFg0aZbEeatnf2letP_og")]
    [Description(@"In an FI to FI Customer Credit Transfer: Credit to creditor's account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation.")]
    CreditPendingDocuments = ExternalPaymentStatusReasonCode.CreditPendingDocuments, // same ordinal as derivation source for type conversions
    
}
