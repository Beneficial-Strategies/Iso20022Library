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
/// Provides information about the CA option.
/// </summary>
[IsoId("_UFsoGdp-Ed-ak6NoX_4Aeg_-1064577856")]
[DisplayName("Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOption1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOption1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOption1( System.String reqOptionNumber,CorporateActionOption1FormatChoice_ reqOptionType,CorporateActionEventStatus2FormatChoice_ reqOptionAvailabilityStatus,System.String reqWithdrawalAllowedIndicator,System.String reqChangeAllowedIndicator )
    {
        OptionNumber = reqOptionNumber;
        OptionType = reqOptionType;
        OptionAvailabilityStatus = reqOptionAvailabilityStatus;
        WithdrawalAllowedIndicator = reqWithdrawalAllowedIndicator;
        ChangeAllowedIndicator = reqChangeAllowedIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UFsoGtp-Ed-ak6NoX_4Aeg_-963912936")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OptionNumber { get; init; } 
    #else
    public System.String OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UFsoG9p-Ed-ak6NoX_4Aeg_-963912905")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_UFsoHNp-Ed-ak6NoX_4Aeg_-921431062")]
    [DisplayName("Option Availability Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnAvlbtySts")]
    #endif
    [IsoXmlTag("OptnAvlbtySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventStatus2FormatChoice_ OptionAvailabilityStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventStatus2FormatChoice_ OptionAvailabilityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventStatus2FormatChoice_ OptionAvailabilityStatus { get; init; } 
    #else
    public CorporateActionEventStatus2FormatChoice_ OptionAvailabilityStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Whether or not certification is required from the account owner. |Yes: certification required |No: no certification required.
    /// </summary>
    [IsoId("_UF2ZENp-Ed-ak6NoX_4Aeg_-548329043")]
    [DisplayName("Certification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnInd")]
    #endif
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationIndicator { get; init; } 
    #else
    public System.String? CertificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_UF2ZEdp-Ed-ak6NoX_4Aeg_-477217373")]
    [DisplayName("Certification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnTp")]
    #endif
    [IsoXmlTag("CertfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    #else
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a temporary security used for processing reasons, eg, contra security used in the US.
    /// </summary>
    [IsoId("_UF2ZEtp-Ed-ak6NoX_4Aeg_1198048231")]
    [DisplayName("Assented Line Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssntdLineSctyId")]
    #endif
    [IsoXmlTag("AssntdLineSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification7? AssentedLineSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification7? AssentedLineSecurityIdentification { get; init; } 
    #else
    public SecurityIdentification7? AssentedLineSecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the safekeeping account held by an agent at the CSD.
    /// </summary>
    [IsoId("_UF2ZE9p-Ed-ak6NoX_4Aeg_-65255820")]
    [DisplayName("Agent Securities Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtSctiesAcctId")]
    #endif
    [IsoXmlTag("AgtSctiesAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AgentSecuritiesAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgentSecuritiesAccountIdentification { get; init; } 
    #else
    public System.String? AgentSecuritiesAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cash account held by an agent at the CSD.
    /// </summary>
    [IsoId("_UF2ZFNp-Ed-ak6NoX_4Aeg_-532715793")]
    [DisplayName("Agent Cash Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCshAcctId")]
    #endif
    [IsoXmlTag("AgtCshAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification2Choice_? AgentCashAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification2Choice_? AgentCashAccountIdentification { get; init; } 
    #else
    public AccountIdentification2Choice_? AgentCashAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_UF2ZFdp-Ed-ak6NoX_4Aeg_-616320822")]
    [DisplayName("Offer Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OfferTp")]
    #endif
    [IsoXmlTag("OfferTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OfferType1FormatChoice_? OfferType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OfferType1FormatChoice_? OfferType { get; init; } 
    #else
    public OfferType1FormatChoice_? OfferType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of intermediates securities distribution, eg, stock dividend, reverse right.
    /// </summary>
    [IsoId("_UF2ZFtp-Ed-ak6NoX_4Aeg_-616320520")]
    [DisplayName("Intermediate Securities Distribution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmdtSctiesDstrbtnTp")]
    #endif
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IntermediateSecurityDistributionType1FormatChoice_? IntermediateSecuritiesDistributionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntermediateSecurityDistributionType1FormatChoice_? IntermediateSecuritiesDistributionType { get; init; } 
    #else
    public IntermediateSecurityDistributionType1FormatChoice_? IntermediateSecuritiesDistributionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_UF2ZF9p-Ed-ak6NoX_4Aeg_1839983467")]
    [DisplayName("Withdrawal Allowed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlAllwdInd")]
    #endif
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator WithdrawalAllowedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String WithdrawalAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String WithdrawalAllowedIndicator { get; init; } 
    #else
    public System.String WithdrawalAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_UF2ZGNp-Ed-ak6NoX_4Aeg_-2128058199")]
    [DisplayName("Change Allowed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngAllwdInd")]
    #endif
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ChangeAllowedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ChangeAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ChangeAllowedIndicator { get; init; } 
    #else
    public System.String ChangeAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a CA option.
    /// </summary>
    [IsoId("_UF2ZGdp-Ed-ak6NoX_4Aeg_-1100900730")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDate4? DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate4? DateDetails { get; init; } 
    #else
    public CorporateActionDate4? DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about rates and amounts related to a CA option.
    /// </summary>
    [IsoId("_UF_jANp-Ed-ak6NoX_4Aeg_-488676195")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate2? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate2? RateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRate2? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a CA option.
    /// </summary>
    [IsoId("_UF_jAdp-Ed-ak6NoX_4Aeg_-693561752")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice1? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice1? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice1? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the periods related to a CA option.
    /// </summary>
    [IsoId("_UF_jAtp-Ed-ak6NoX_4Aeg_-928157510")]
    [DisplayName("Period Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdDtls")]
    #endif
    [IsoXmlTag("PrdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPeriod2? PeriodDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPeriod2? PeriodDetails { get; init; } 
    #else
    public CorporateActionPeriod2? PeriodDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the securities movement linked to the CA option.
    /// </summary>
    [IsoId("_UF_jA9p-Ed-ak6NoX_4Aeg_3077583")]
    [DisplayName("Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityOption1? SecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityOption1? SecuritiesMovementDetails { get; init; } 
    #else
    public SecurityOption1? SecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the cash movement linked to the CA option.
    /// </summary>
    [IsoId("_UF_jBNp-Ed-ak6NoX_4Aeg_-127876028")]
    [DisplayName("Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmntDtls")]
    #endif
    [IsoXmlTag("CshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOption1? CashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOption1? CashMovementDetails { get; init; } 
    #else
    public CashOption1? CashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the agents linked to the CA option.
    /// </summary>
    [IsoId("_UF_jBdp-Ed-ak6NoX_4Aeg_1521015328")]
    [DisplayName("Corporate Action Other Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnOthrAgtDtls")]
    #endif
    [IsoXmlTag("CorpActnOthrAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionAgent1? CorporateActionOtherAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAgent1? CorporateActionOtherAgentDetails { get; init; } 
    #else
    public CorporateActionAgent1? CorporateActionOtherAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_UF_jBtp-Ed-ak6NoX_4Aeg_398627756")]
    [DisplayName("Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnDspstn")]
    #endif
    [IsoXmlTag("FrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType1FormatChoice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType1FormatChoice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType1FormatChoice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// ndicates whether redemption charges apply.
    /// </summary>
    [IsoId("_UF_jB9p-Ed-ak6NoX_4Aeg_2102524745")]
    [DisplayName("Redemption Charges Applied Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedChrgsApldInd")]
    #endif
    [IsoXmlTag("RedChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RedemptionChargesAppliedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RedemptionChargesAppliedIndicator { get; init; } 
    #else
    public System.String? RedemptionChargesAppliedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_UF_jCNp-Ed-ak6NoX_4Aeg_330286965")]
    [DisplayName("Option Features")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnFeatrs")]
    #endif
    [IsoXmlTag("OptnFeatrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionFeatures1FormatChoice_? OptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionFeatures1FormatChoice_? OptionFeatures { get; init; } 
    #else
    public OptionFeatures1FormatChoice_? OptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_UF_jCdp-Ed-ak6NoX_4Aeg_-710459371")]
    [DisplayName("Corporate Action Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnAddtlInf")]
    #endif
    [IsoXmlTag("CorpActnAddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative1? CorporateActionAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative1? CorporateActionAdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative1? CorporateActionAdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
