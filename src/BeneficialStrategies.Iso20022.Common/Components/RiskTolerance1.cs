// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Risk tolerance of an investor for which a financial instrument is targeted.
/// </summary>
[IsoId("_vPux4DcWEeidBoT_PugKiA")]
[DisplayName("Risk Tolerance")]
public partial record RiskTolerance1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the Summary Risk Indicator (SRI). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04010.
    /// </summary>
    [IsoId("_Dz71wDcXEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance PRIIPS Methodology")]
    [IsoXmlTag("RskTlrncePRIIPSMthdlgy")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    public IsoMax1Number? RiskTolerancePRIIPSMethodology { get; init; } 
    
    /// <summary>
    /// Specifies the Synthetic Risk and Reward Indicator (SRRI). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04020.
    /// </summary>
    [IsoId("_PJpw0DcXEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance UCITS Methodology")]
    [IsoXmlTag("RskTlrnceUCITSMthdlgy")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    public IsoMax1Number? RiskToleranceUCITSMethodology { get; init; } 
    
    /// <summary>
    /// Specifies the risk tolerance for non-PRIIPs and non-UCITS instructions. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04030.
    /// </summary>
    [IsoId("_TkUlUDcXEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance Internal")]
    [IsoXmlTag("RskTlrnceIntl")]
    public RiskLevel1Code? RiskToleranceInternal { get; init; } 
    
    /// <summary>
    /// Specifies the Summary Risk Indicator (SRI) for a Spanish product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04040.
    /// </summary>
    [IsoId("_cMIIoDcXEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance For Non PRIIPS And Non UCITS Spain")]
    [IsoXmlTag("RskTlrnceForNonPRIIPSAndNonUCITSES")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    public IsoMax1Number? RiskToleranceForNonPRIIPSAndNonUCITSSpain { get; init; } 
    
    /// <summary>
    /// Specifies the risk tolerance for a German product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 04050.
    /// </summary>
    [IsoId("_hrhwkDcXEeidBoT_PugKiA")]
    [DisplayName("Not For Investors With The Lowest Risk Tolerance Germany")]
    [IsoXmlTag("NotForInvstrsWthTheLwstRskTlrnceDE")]
    public TargetMarket2Code? NotForInvestorsWithTheLowestRiskToleranceGermany { get; init; } 
    
    /// <summary>
    /// Specifies another type of risk tolerance.
    /// </summary>
    [IsoId("_An9MgDcYEeidBoT_PugKiA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherTargetMarketRiskTolerance1? Other { get; init; } 
    
    
    #nullable disable
    
}
