// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bX9Ux9p-Ed-ak6NoX_4Aeg_1539844320")]
[Description(@"Specifies the reason for requesting the cancellation of a payment instruction.")]
[DerivedFrom(typeof(CancellationReasonCode))]
public enum CancellationReason2Code
{
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bX9UyNp-Ed-ak6NoX_4Aeg_1539844657")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer = CancellationReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bYGesNp-Ed-ak6NoX_4Aeg_1539844717")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment = CancellationReasonCode.DuplicatePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_bYGesdp-Ed-ak6NoX_4Aeg_1539845000")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent = CancellationReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_bYGestp-Ed-ak6NoX_4Aeg_1539845025")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency = CancellationReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_bYGes9p-Ed-ak6NoX_4Aeg_1539845060")]
    [Description(@"Payment is not justified.")]
    UnduePayment = CancellationReasonCode.UnduePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is a suspicious payment.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_bYGetNp-Ed-ak6NoX_4Aeg_1640509378")]
    [Description(@"Payment is a suspicious payment.")]
    SuspiciousPayment = CancellationReasonCode.SuspiciousPayment, // same ordinal as derivation source for type conversions
    
}
