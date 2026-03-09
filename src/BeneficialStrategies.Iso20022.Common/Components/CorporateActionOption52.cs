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
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_m7kuARFLEeKp2ZN13DI_pA")]
[DisplayName("Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOption52
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOption52 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOption52( System.String reqOptionNumber,CorporateActionOption10Choice_ reqOptionType,DefaultProcessingOrStandingInstruction1Choice_ reqDefaultProcessingOrStandingInstruction )
    {
        OptionNumber = reqOptionNumber;
        OptionType = reqOptionType;
        DefaultProcessingOrStandingInstruction = reqDefaultProcessingOrStandingInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_nR7YmRFLEeKp2ZN13DI_pA")]
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
    [IsoId("_nR7YoxFLEeKp2ZN13DI_pA")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption10Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption10Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption10Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption10Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_nR7YrRFLEeKp2ZN13DI_pA")]
    [DisplayName("Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnDspstn")]
    #endif
    [IsoXmlTag("FrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType19Choice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType19Choice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType19Choice_? FractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_nR7YtxFLEeKp2ZN13DI_pA")]
    [DisplayName("Offer Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OfferTp")]
    #endif
    [IsoXmlTag("OfferTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OfferTypeFormat3Choice_? OfferType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OfferTypeFormat3Choice_? OfferType { get; init; } 
    #else
    public OfferTypeFormat3Choice_? OfferType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_nR7YwRFLEeKp2ZN13DI_pA")]
    [DisplayName("Option Features")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnFeatrs")]
    #endif
    [IsoXmlTag("OptnFeatrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionFeaturesFormat9Choice_? OptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionFeaturesFormat9Choice_? OptionFeatures { get; init; } 
    #else
    public OptionFeaturesFormat9Choice_? OptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of intermediates securities distribution.
    /// </summary>
    [IsoId("_nR7YyxFLEeKp2ZN13DI_pA")]
    [DisplayName("Intermediate Securities Distribution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmdtSctiesDstrbtnTp")]
    #endif
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IntermediateSecuritiesDistributionTypeFormat9Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntermediateSecuritiesDistributionTypeFormat9Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    #else
    public IntermediateSecuritiesDistributionTypeFormat9Choice_? IntermediateSecuritiesDistributionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_nR7Y1RFLEeKp2ZN13DI_pA")]
    [DisplayName("Option Availability Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnAvlbtySts")]
    #endif
    [IsoXmlTag("OptnAvlbtySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionAvailabilityStatus1Choice_? OptionAvailabilityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionAvailabilityStatus1Choice_? OptionAvailabilityStatus { get; init; } 
    #else
    public OptionAvailabilityStatus1Choice_? OptionAvailabilityStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of certification/breakdown.
    /// </summary>
    [IsoId("_nR7Y3xFLEeKp2ZN13DI_pA")]
    [DisplayName("Certification Breakdown Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnBrkdwnTp")]
    #endif
    [IsoXmlTag("CertfctnBrkdwnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType5Choice_? CertificationBreakdownType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType5Choice_? CertificationBreakdownType { get; init; } 
    #else
    public BeneficiaryCertificationType5Choice_? CertificationBreakdownType { get; set; } 
    #endif
    
    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_nR7Y6RFLEeKp2ZN13DI_pA")]
    [DisplayName("Non Domicile Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonDmclCtry")]
    #endif
    [IsoXmlTag("NonDmclCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? NonDomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NonDomicileCountry { get; init; } 
    #else
    public string? NonDomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [IsoId("_nR7Y8xFLEeKp2ZN13DI_pA")]
    [DisplayName("Valid Domicile Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldDmclCtry")]
    #endif
    [IsoXmlTag("VldDmclCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? ValidDomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ValidDomicileCountry { get; init; } 
    #else
    public string? ValidDomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_nR7Y_RFLEeKp2ZN13DI_pA")]
    [DisplayName("Currency Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyOptn")]
    #endif
    [IsoXmlTag("CcyOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyOption { get; init; } 
    #else
    public string? CurrencyOption { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [IsoId("_nR7ZBxFLEeKp2ZN13DI_pA")]
    [DisplayName("Default Processing Or Standing Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltPrcgOrStgInstr")]
    #endif
    [IsoXmlTag("DfltPrcgOrStgInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; } 
    #else
    public DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether redemption charges apply.
    /// </summary>
    [IsoId("_nR7ZERFLEeKp2ZN13DI_pA")]
    [DisplayName("Charges Applied Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsApldInd")]
    #endif
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChargesAppliedIndicator { get; init; } 
    #else
    public System.String? ChargesAppliedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not certification/breakdown is required from the account owner. 
    /// Yes: certification required 
    /// No: no certification required.
    /// </summary>
    [IsoId("_nR7ZGxFLEeKp2ZN13DI_pA")]
    [DisplayName("Certification Breakdown Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnBrkdwnInd")]
    #endif
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationBreakdownIndicator { get; init; } 
    #else
    public System.String? CertificationBreakdownIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_nR7ZJRFLEeKp2ZN13DI_pA")]
    [DisplayName("Withdrawal Allowed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlAllwdInd")]
    #endif
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WithdrawalAllowedIndicator { get; init; } 
    #else
    public System.String? WithdrawalAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_nR7ZLxFLEeKp2ZN13DI_pA")]
    [DisplayName("Change Allowed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngAllwdInd")]
    #endif
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChangeAllowedIndicator { get; init; } 
    #else
    public System.String? ChangeAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_nR7ZORFLEeKp2ZN13DI_pA")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification14? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("_nR7ZQxFLEeKp2ZN13DI_pA")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDate15? DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate15? DateDetails { get; init; } 
    #else
    public CorporateActionDate15? DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("_nR7ZTRFLEeKp2ZN13DI_pA")]
    [DisplayName("Period Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdDtls")]
    #endif
    [IsoXmlTag("PrdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPeriod7? PeriodDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPeriod7? PeriodDetails { get; init; } 
    #else
    public CorporateActionPeriod7? PeriodDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_nR7ZVxFLEeKp2ZN13DI_pA")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate37? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate37? RateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRate37? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_nR7ZYRFLEeKp2ZN13DI_pA")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice28? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice28? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice28? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities quantity related to a corporate action option.
    /// </summary>
    [IsoId("_nR7ZaxFLEeKp2ZN13DI_pA")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesOption23? SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOption23? SecuritiesQuantity { get; init; } 
    #else
    public SecuritiesOption23? SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities movement related to a corporate action option.
    /// </summary>
    [IsoId("_nR7ZdRFLEeKp2ZN13DI_pA")]
    [DisplayName("Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesOption38? SecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOption38? SecuritiesMovementDetails { get; init; } 
    #else
    public SecuritiesOption38? SecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("_nR7ZfxFLEeKp2ZN13DI_pA")]
    [DisplayName("Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmntDtls")]
    #endif
    [IsoXmlTag("CshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOption25? CashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOption25? CashMovementDetails { get; init; } 
    #else
    public CashOption25? CashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the corporate action movement.
    /// </summary>
    [IsoId("_nR7ZiRFLEeKp2ZN13DI_pA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative20? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative20? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative20? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
