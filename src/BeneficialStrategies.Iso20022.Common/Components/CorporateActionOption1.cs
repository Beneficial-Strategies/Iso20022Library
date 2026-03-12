// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the CA option.
/// </summary>
[IsoId("_UFsoGdp-Ed-ak6NoX_4Aeg_-1064577856")]
[DisplayName("Corporate Action Option")]
public partial record CorporateActionOption1
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UFsoGtp-Ed-ak6NoX_4Aeg_-963912936")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UFsoG9p-Ed-ak6NoX_4Aeg_-963912905")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    
    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_UFsoHNp-Ed-ak6NoX_4Aeg_-921431062")]
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public required CorporateActionEventStatus2FormatChoice_ OptionAvailabilityStatus { get; init; } 
    
    /// <summary>
    /// Whether or not certification is required from the account owner. |Yes: certification required |No: no certification required.
    /// </summary>
    [IsoId("_UF2ZENp-Ed-ak6NoX_4Aeg_-548329043")]
    [DisplayName("Certification Indicator")]
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_UF2ZEdp-Ed-ak6NoX_4Aeg_-477217373")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    
    /// <summary>
    /// Identification of a temporary security used for processing reasons, eg, contra security used in the US.
    /// </summary>
    [IsoId("_UF2ZEtp-Ed-ak6NoX_4Aeg_1198048231")]
    [DisplayName("Assented Line Security Identification")]
    [IsoXmlTag("AssntdLineSctyId")]
    public SecurityIdentification7? AssentedLineSecurityIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the safekeeping account held by an agent at the CSD.
    /// </summary>
    [IsoId("_UF2ZE9p-Ed-ak6NoX_4Aeg_-65255820")]
    [DisplayName("Agent Securities Account Identification")]
    [IsoXmlTag("AgtSctiesAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AgentSecuritiesAccountIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the cash account held by an agent at the CSD.
    /// </summary>
    [IsoId("_UF2ZFNp-Ed-ak6NoX_4Aeg_-532715793")]
    [DisplayName("Agent Cash Account Identification")]
    [IsoXmlTag("AgtCshAcctId")]
    public AccountIdentification2Choice_? AgentCashAccountIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_UF2ZFdp-Ed-ak6NoX_4Aeg_-616320822")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public OfferType1FormatChoice_? OfferType { get; init; } 
    
    /// <summary>
    /// Type of intermediates securities distribution, eg, stock dividend, reverse right.
    /// </summary>
    [IsoId("_UF2ZFtp-Ed-ak6NoX_4Aeg_-616320520")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecurityDistributionType1FormatChoice_? IntermediateSecuritiesDistributionType { get; init; } 
    
    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_UF2ZF9p-Ed-ak6NoX_4Aeg_1839983467")]
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator WithdrawalAllowedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_UF2ZGNp-Ed-ak6NoX_4Aeg_-2128058199")]
    [DisplayName("Change Allowed Indicator")]
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ChangeAllowedIndicator { get; init; } 
    
    /// <summary>
    /// Provides information about the dates related to a CA option.
    /// </summary>
    [IsoId("_UF2ZGdp-Ed-ak6NoX_4Aeg_-1100900730")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate4? DateDetails { get; init; } 
    
    /// <summary>
    /// Provides information about rates and amounts related to a CA option.
    /// </summary>
    [IsoId("_UF_jANp-Ed-ak6NoX_4Aeg_-488676195")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate2? RateAndAmountDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the prices related to a CA option.
    /// </summary>
    [IsoId("_UF_jAdp-Ed-ak6NoX_4Aeg_-693561752")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice1? PriceDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the periods related to a CA option.
    /// </summary>
    [IsoId("_UF_jAtp-Ed-ak6NoX_4Aeg_-928157510")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod2? PeriodDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the securities movement linked to the CA option.
    /// </summary>
    [IsoId("_UF_jA9p-Ed-ak6NoX_4Aeg_3077583")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public SecurityOption1? SecuritiesMovementDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the cash movement linked to the CA option.
    /// </summary>
    [IsoId("_UF_jBNp-Ed-ak6NoX_4Aeg_-127876028")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public CashOption1? CashMovementDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the agents linked to the CA option.
    /// </summary>
    [IsoId("_UF_jBdp-Ed-ak6NoX_4Aeg_1521015328")]
    [DisplayName("Corporate Action Other Agent Details")]
    [IsoXmlTag("CorpActnOthrAgtDtls")]
    public CorporateActionAgent1? CorporateActionOtherAgentDetails { get; init; } 
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_UF_jBtp-Ed-ak6NoX_4Aeg_398627756")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType1FormatChoice_? FractionDisposition { get; init; } 
    
    /// <summary>
    /// ndicates whether redemption charges apply.
    /// </summary>
    [IsoId("_UF_jB9p-Ed-ak6NoX_4Aeg_2102524745")]
    [DisplayName("Redemption Charges Applied Indicator")]
    [IsoXmlTag("RedChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RedemptionChargesAppliedIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_UF_jCNp-Ed-ak6NoX_4Aeg_330286965")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeatures1FormatChoice_? OptionFeatures { get; init; } 
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_UF_jCdp-Ed-ak6NoX_4Aeg_-710459371")]
    [DisplayName("Corporate Action Additional Information")]
    [IsoXmlTag("CorpActnAddtlInf")]
    public CorporateActionNarrative1? CorporateActionAdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
