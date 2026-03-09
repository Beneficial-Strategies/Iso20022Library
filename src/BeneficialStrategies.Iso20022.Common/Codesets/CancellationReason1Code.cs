// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bX9Uwdp-Ed-ak6NoX_4Aeg_326881766")]
[Description(@"Specifies the reason for requesting the cancellation of a payment instruction.")]
[DerivedFrom(typeof(CancellationReasonCode))]
public enum CancellationReason1Code
{
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bX9Uwtp-Ed-ak6NoX_4Aeg_1630644349")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer = CancellationReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bX9Uw9p-Ed-ak6NoX_4Aeg_1685131160")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment = CancellationReasonCode.DuplicatePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_bX9UxNp-Ed-ak6NoX_4Aeg_625588821")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent = CancellationReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_bX9Uxdp-Ed-ak6NoX_4Aeg_53376570")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency = CancellationReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_bX9Uxtp-Ed-ak6NoX_4Aeg_-1199151468")]
    [Description(@"Payment is not justified.")]
    UnduePayment = CancellationReasonCode.UnduePayment, // same ordinal as derivation source for type conversions
    
}
