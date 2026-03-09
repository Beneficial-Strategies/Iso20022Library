// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the identification of the rules and laws governing the undertaking.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6AaZoHyaEeGWJuGCfvwOsQ")]
[Description(@"Specifies the identification of the rules and laws governing the undertaking.")]
[Derivations(typeof(GovernanceIdentification1Code))]
public enum GovernanceIdentificationCode
{
    /// <summary>
    /// The version of the ICC Uniform Rules For Demand Guarantees (URDG) as published by the International Chamber of Commerce (ICC) that is in effect on the date of issue of the undertaking.
    /// Encoded/decoded by serializers as &quot;URDG&quot;.
    /// </summary>
    [EnumMember(Value = "URDG")]
    [IsoId("_meNv4HybEeGWJuGCfvwOsQ")]
    [Description(@"The version of the ICC Uniform Rules For Demand Guarantees (URDG) as published by the International Chamber of Commerce (ICC) that is in effect on the date of issue of the undertaking.")]
    UniformRulesForDemandGuarantees,
    
    /// <summary>
    /// The version of the International Standby Practices (ISP) that is in effect on the date of issue of the undertaking.
    /// Encoded/decoded by serializers as &quot;ISPR&quot;.
    /// </summary>
    [EnumMember(Value = "ISPR")]
    [IsoId("_vWxsAHybEeGWJuGCfvwOsQ")]
    [Description(@"The version of the International Standby Practices (ISP) that is in effect on the date of issue of the undertaking.")]
    InternationalStandbyPractices,
    
    /// <summary>
    /// The version of the Uniform Customs and Practice for Documentary Credits (UCP) as published by the International Chamber of Commerce (ICC) that is in effect on the date of issue of the undertaking.
    /// Encoded/decoded by serializers as &quot;UCPR&quot;.
    /// </summary>
    [EnumMember(Value = "UCPR")]
    [IsoId("_6-c5wHybEeGWJuGCfvwOsQ")]
    [Description(@"The version of the Uniform Customs and Practice for Documentary Credits (UCP) as published by the International Chamber of Commerce (ICC) that is in effect on the date of issue of the undertaking.")]
    UniformCustomsAndPractice,
    
    /// <summary>
    /// No applicable rule set defined.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_GpQUAHycEeGWJuGCfvwOsQ")]
    [Description(@"No applicable rule set defined.")]
    None,
    
}
