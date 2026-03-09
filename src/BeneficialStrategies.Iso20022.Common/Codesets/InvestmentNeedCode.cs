// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an investment need.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S9gOMDcdEeidBoT_PugKiA")]
[Description(@"Specifies an investment need.")]
[Derivations(typeof(InvestmentNeed1Code),typeof(InvestmentNeed2Code))]
public enum InvestmentNeedCode
{
    /// <summary>
    /// No specific need.
    /// Encoded/decoded by serializers as &quot;NSPE&quot;.
    /// </summary>
    [EnumMember(Value = "NSPE")]
    [IsoId("_gMLO8DcdEeidBoT_PugKiA")]
    [Description(@"No specific need.")]
    None,
    
    /// <summary>
    /// Investment need is for green investment.
    /// Encoded/decoded by serializers as &quot;GRIN&quot;.
    /// </summary>
    [EnumMember(Value = "GRIN")]
    [IsoId("_h2QLIDcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for green investment.")]
    GreenInvestment,
    
    /// <summary>
    /// Investment need is for ethical investment.
    /// Encoded/decoded by serializers as &quot;ETHI&quot;.
    /// </summary>
    [EnumMember(Value = "ETHI")]
    [IsoId("_oNAR0DcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for ethical investment.")]
    EthicalInvestment,
    
    /// <summary>
    /// Investment need is for Islamic banking.
    /// Encoded/decoded by serializers as &quot;ISLB&quot;.
    /// </summary>
    [EnumMember(Value = "ISLB")]
    [IsoId("_t5M_oDcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for Islamic banking.")]
    IslamicBanking,
    
    /// <summary>
    /// Investment need is for environmental social corporate governance.
    /// Encoded/decoded by serializers as &quot;ESGO&quot;.
    /// </summary>
    [EnumMember(Value = "ESGO")]
    [IsoId("_xXxYQDcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for environmental social corporate governance.|")]
    EnvironmentalSocialCorporateGovernance,
    
    /// <summary>
    /// Other specific need.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_3zbNEDcdEeidBoT_PugKiA")]
    [Description(@"Other specific need.")]
    Other,
    
    /// <summary>
    /// Specific investment need.
    /// Encoded/decoded by serializers as &quot;YSPE&quot;.
    /// </summary>
    [EnumMember(Value = "YSPE")]
    [IsoId("_CY4s4Ol4Eei6w4V2u1HOBw")]
    [Description(@"Specific investment need.")]
    SpecificNeed,
    
}
