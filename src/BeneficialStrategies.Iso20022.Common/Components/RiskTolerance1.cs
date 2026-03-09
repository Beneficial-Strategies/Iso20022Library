// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Risk tolerance of an investor for which a financial instrument is targeted.
/// </summary>
[IsoId("_vPux4DcWEeidBoT_PugKiA")]
[DisplayName("Risk Tolerance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RiskTolerance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the Summary Risk Indicator (SRI). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04010.
    /// </summary>
    [IsoId("_Dz71wDcXEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance PRIIPS Methodology")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskTlrncePRIIPSMthdlgy")]
    #endif
    [IsoXmlTag("RskTlrncePRIIPSMthdlgy")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1Number? RiskTolerancePRIIPSMethodology { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RiskTolerancePRIIPSMethodology { get; init; } 
    #else
    public System.UInt64? RiskTolerancePRIIPSMethodology { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the Synthetic Risk and Reward Indicator (SRRI). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04020.
    /// </summary>
    [IsoId("_PJpw0DcXEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance UCITS Methodology")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskTlrnceUCITSMthdlgy")]
    #endif
    [IsoXmlTag("RskTlrnceUCITSMthdlgy")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1Number? RiskToleranceUCITSMethodology { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RiskToleranceUCITSMethodology { get; init; } 
    #else
    public System.UInt64? RiskToleranceUCITSMethodology { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the risk tolerance for non-PRIIPs and non-UCITS instructions. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04030.
    /// </summary>
    [IsoId("_TkUlUDcXEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance Internal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskTlrnceIntl")]
    #endif
    [IsoXmlTag("RskTlrnceIntl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskLevel1Code? RiskToleranceInternal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskLevel1Code? RiskToleranceInternal { get; init; } 
    #else
    public RiskLevel1Code? RiskToleranceInternal { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the Summary Risk Indicator (SRI) for a Spanish product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04040.
    /// </summary>
    [IsoId("_cMIIoDcXEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance For Non PRIIPS And Non UCITS Spain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskTlrnceForNonPRIIPSAndNonUCITSES")]
    #endif
    [IsoXmlTag("RskTlrnceForNonPRIIPSAndNonUCITSES")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1Number? RiskToleranceForNonPRIIPSAndNonUCITSSpain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RiskToleranceForNonPRIIPSAndNonUCITSSpain { get; init; } 
    #else
    public System.UInt64? RiskToleranceForNonPRIIPSAndNonUCITSSpain { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the risk tolerance for a German product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04050.
    /// </summary>
    [IsoId("_hrhwkDcXEeidBoT_PugKiA")]
    [DisplayName("Not For Investors With The Lowest Risk Tolerance Germany")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NotForInvstrsWthTheLwstRskTlrnceDE")]
    #endif
    [IsoXmlTag("NotForInvstrsWthTheLwstRskTlrnceDE")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket2Code? NotForInvestorsWithTheLowestRiskToleranceGermany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket2Code? NotForInvestorsWithTheLowestRiskToleranceGermany { get; init; } 
    #else
    public TargetMarket2Code? NotForInvestorsWithTheLowestRiskToleranceGermany { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies another type of risk tolerance.
    /// </summary>
    [IsoId("_An9MgDcYEeidBoT_PugKiA")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherTargetMarketRiskTolerance1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherTargetMarketRiskTolerance1? Other { get; init; } 
    #else
    public OtherTargetMarketRiskTolerance1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
