// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an investment need.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7RZv0DcdEeidBoT_PugKiA")]
[Description(@"Specifies an investment need.")]
[DerivedFrom(typeof(InvestmentNeedCode))]
public enum InvestmentNeed1Code
{
    /// <summary>
    /// Investment need is for environmental social corporate governance.
    /// Encoded/decoded by serializers as &quot;ESGO&quot;.
    /// </summary>
    [EnumMember(Value = "ESGO")]
    [IsoId("_-DCJ8TcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for environmental social corporate governance.|")]
    EnvironmentalSocialCorporateGovernance =
        InvestmentNeedCode.EnvironmentalSocialCorporateGovernance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment need is for ethical investment.
    /// Encoded/decoded by serializers as &quot;ETHI&quot;.
    /// </summary>
    [EnumMember(Value = "ETHI")]
    [IsoId("_-IFpETcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for ethical investment.")]
    EthicalInvestment = InvestmentNeedCode.EthicalInvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment need is for green investment.
    /// Encoded/decoded by serializers as &quot;GRIN&quot;.
    /// </summary>
    [EnumMember(Value = "GRIN")]
    [IsoId("_-NJvQTcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for green investment.")]
    GreenInvestment = InvestmentNeedCode.GreenInvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment need is for Islamic banking.
    /// Encoded/decoded by serializers as &quot;ISLB&quot;.
    /// </summary>
    [EnumMember(Value = "ISLB")]
    [IsoId("_-SgJUTcdEeidBoT_PugKiA")]
    [Description(@"Investment need is for Islamic banking.")]
    IslamicBanking = InvestmentNeedCode.IslamicBanking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No specific need.
    /// Encoded/decoded by serializers as &quot;NSPE&quot;.
    /// </summary>
    [EnumMember(Value = "NSPE")]
    [IsoId("_-US5ETcdEeidBoT_PugKiA")]
    [Description(@"No specific need.")]
    None = InvestmentNeedCode.None, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other specific need.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-ZgJMTcdEeidBoT_PugKiA")]
    [Description(@"Other specific need.")]
    Other = InvestmentNeedCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specific investment need.
    /// Encoded/decoded by serializers as &quot;YSPE&quot;.
    /// </summary>
    [EnumMember(Value = "YSPE")]
    [IsoId("_c_wd0el4Eei6w4V2u1HOBw")]
    [Description(@"Specific investment need.")]
    SpecificNeed = InvestmentNeedCode.SpecificNeed, // same ordinal as derivation source for type conversions
}
