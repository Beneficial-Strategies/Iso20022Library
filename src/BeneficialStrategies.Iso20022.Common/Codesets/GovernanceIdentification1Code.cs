// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the identification of the rules and laws governing the undertaking.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QbWgMHycEeGWJuGCfvwOsQ")]
[Description(@"Specifies the identification of the rules and laws governing the undertaking.")]
[DerivedFrom(typeof(GovernanceIdentificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GovernanceIdentification1Code>))]
#endif
public enum GovernanceIdentification1Code
{
    /// <summary>
    /// The version of the International Standby Practices (ISP) that is in effect on the date of issue of the undertaking.
    /// Encoded/decoded by serializers as &quot;ISPR&quot;.
    /// </summary>
    [EnumMember(Value = "ISPR")]
    [IsoId("_buUCNnycEeGWJuGCfvwOsQ")]
    [Description(
        @"The version of the International Standby Practices (ISP) that is in effect on the date of issue of the undertaking."
    )]
    InternationalStandbyPractices = GovernanceIdentificationCode.InternationalStandbyPractices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No applicable rule set defined.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_djAS9nycEeGWJuGCfvwOsQ")]
    [Description(@"No applicable rule set defined.")]
    None = GovernanceIdentificationCode.None, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The version of the Uniform Customs and Practice for Documentary Credits (UCP) as published by the International Chamber of Commerce (ICC) that is in effect on the date of issue of the undertaking.
    /// Encoded/decoded by serializers as &quot;UCPR&quot;.
    /// </summary>
    [EnumMember(Value = "UCPR")]
    [IsoId("_dtcBVnycEeGWJuGCfvwOsQ")]
    [Description(
        @"The version of the Uniform Customs and Practice for Documentary Credits (UCP) as published by the International Chamber of Commerce (ICC) that is in effect on the date of issue of the undertaking."
    )]
    UniformCustomsAndPractice = GovernanceIdentificationCode.UniformCustomsAndPractice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The version of the ICC Uniform Rules For Demand Guarantees (URDG) as published by the International Chamber of Commerce (ICC) that is in effect on the date of issue of the undertaking.
    /// Encoded/decoded by serializers as &quot;URDG&quot;.
    /// </summary>
    [EnumMember(Value = "URDG")]
    [IsoId("_d1VZFnycEeGWJuGCfvwOsQ")]
    [Description(
        @"The version of the ICC Uniform Rules For Demand Guarantees (URDG) as published by the International Chamber of Commerce (ICC) that is in effect on the date of issue of the undertaking."
    )]
    UniformRulesForDemandGuarantees = GovernanceIdentificationCode.UniformRulesForDemandGuarantees, // same ordinal as derivation source for type conversions
}
