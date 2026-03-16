// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t9qdIFkyEeGeoaLUQk__nA_-849686320")]
[Description(
    @"Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalChargeTypeCode))]
public enum ExternalChargeType1Code
{
    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_uLHG3vRYEeuLhpyIdtJzwg")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee = ExternalChargeTypeCode.BrokerageFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for processing a batch of transactions.
    /// Encoded/decoded by serializers as &quot;BTCH&quot;.
    /// </summary>
    [EnumMember(Value = "BTCH")]
    [IsoId("_uLQ30vRYEeuLhpyIdtJzwg")]
    [Description(@"Fee paid for processing a batch of transactions.")]
    Batch = ExternalChargeTypeCode.Batch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for services provided.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uLQ31fRYEeuLhpyIdtJzwg")]
    [Description(@"Fee paid for services provided.")]
    Commission = ExternalChargeTypeCode.Commission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Summation of individual fees.
    /// Encoded/decoded by serializers as &quot;SUMM&quot;.
    /// </summary>
    [EnumMember(Value = "SUMM")]
    [IsoId("_uLQ32PRYEeuLhpyIdtJzwg")]
    [Description(@"Summation of individual fees.")]
    Summation = ExternalChargeTypeCode.Summation, // same ordinal as derivation source for type conversions
}
