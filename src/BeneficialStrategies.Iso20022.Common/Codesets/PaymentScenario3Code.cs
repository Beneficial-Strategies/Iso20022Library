// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the payment scenario used for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_utCzoHYkEei7x9Ux0Cio1w")]
[Description(@"Describes the payment scenario used for a payment transaction.")]
[DerivedFrom(typeof(PaymentScenarioCode))]
public enum PaymentScenario3Code
{
    /// <summary>
    /// Indicates cover payment(s).
    /// Encoded/decoded by serializers as &quot;COVE&quot;.
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_v4nO4XYkEei7x9Ux0Cio1w")]
    [Description(@"Indicates cover payment(s).")]
    Cover = PaymentScenarioCode.Cover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates customer credit transfer(s) without cover.
    /// Encoded/decoded by serializers as &quot;CCTW&quot;.
    /// </summary>
    [EnumMember(Value = "CCTW")]
    [IsoId("_wz-q8XYkEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) without cover.")]
    CustomerCreditTransferWithoutCover = PaymentScenarioCode.CustomerCreditTransferWithoutCover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates customer credit transfer(s) with cover.
    /// Encoded/decoded by serializers as &quot;CCTC&quot;.
    /// </summary>
    [EnumMember(Value = "CCTC")]
    [IsoId("_xbZ3UXYkEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) with cover.")]
    CustomerCreditTransferWithCover = PaymentScenarioCode.CustomerCreditTransferWithCover, // same ordinal as derivation source for type conversions
    
}
