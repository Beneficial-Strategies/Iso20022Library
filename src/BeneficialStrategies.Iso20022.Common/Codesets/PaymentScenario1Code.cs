// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the payment scenario used for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Kw3hUDKmEeipv8GJ5uBgPw")]
[Description(@"Describes the payment scenario used for a payment transaction.")]
[DerivedFrom(typeof(PaymentScenarioCode))]
public enum PaymentScenario1Code
{
    /// <summary>
    /// Indicates cover payment(s).
    /// Encoded/decoded by serializers as &quot;COVE&quot;.
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_oL9tYDKmEeipv8GJ5uBgPw")]
    [Description(@"Indicates cover payment(s).")]
    Cover = PaymentScenarioCode.Cover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates customer credit transfer(s).
    /// Encoded/decoded by serializers as &quot;CCTR&quot;.
    /// </summary>
    [EnumMember(Value = "CCTR")]
    [IsoId("_iz73oXYkEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s).")]
    CustomerCreditTransfer = PaymentScenarioCode.CustomerCreditTransfer, // same ordinal as derivation source for type conversions
    
}
