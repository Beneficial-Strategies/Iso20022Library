// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the list of interest rates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FENyMDErEemzCpWiCwK4aQ")]
[Description(@"Contains the list of interest rates.")]
[DerivedFrom(typeof(InterestRateCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InterestRate1Code>))]
#endif
public enum InterestRate1Code
{
    /// <summary>
    /// Gross interest rate of the instalment
    /// Encoded/decoded by serializers as &quot;GSRT&quot;.
    /// </summary>
    [EnumMember(Value = "GSRT")]
    [IsoId("_RBUdYTErEemzCpWiCwK4aQ")]
    [Description(@"Gross interest rate of the instalment")]
    GrossRate = InterestRateCode.GrossRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net interest rate of the instalment
    /// Encoded/decoded by serializers as &quot;NTRT&quot;.
    /// </summary>
    [EnumMember(Value = "NTRT")]
    [IsoId("_RW7hATErEemzCpWiCwK4aQ")]
    [Description(@"Net interest rate of the instalment")]
    NetRate = InterestRateCode.NetRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other interest rate of the instalment
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_RrpMwTErEemzCpWiCwK4aQ")]
    [Description(@"Other interest rate of the instalment")]
    OtherNational = InterestRateCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other interest rate of the instalment
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_R9-S4TErEemzCpWiCwK4aQ")]
    [Description(@"Other interest rate of the instalment")]
    OtherPrivate = InterestRateCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
