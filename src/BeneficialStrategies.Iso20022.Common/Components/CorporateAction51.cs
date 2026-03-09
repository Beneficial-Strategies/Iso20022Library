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
/// Provides information about the corporate action event.
/// </summary>
[IsoId("_DrkXSc3yEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateAction51
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_DrkXTc3yEee5nJBZsW8MFQ")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDate74? DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate74? DateDetails { get; init; } 
    #else
    public CorporateActionDate74? DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    [IsoId("_DrkXVc3yEee5nJBZsW8MFQ")]
    [DisplayName("Period Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdDtls")]
    #endif
    [IsoXmlTag("PrdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPeriod14? PeriodDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPeriod14? PeriodDetails { get; init; } 
    #else
    public CorporateActionPeriod14? PeriodDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    [IsoId("_DrkXXc3yEee5nJBZsW8MFQ")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate96? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate96? RateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRate96? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    [IsoId("_DrkXZc3yEee5nJBZsW8MFQ")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice67? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice67? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice67? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_DrkXbc3yEee5nJBZsW8MFQ")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionQuantity8? SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionQuantity8? SecuritiesQuantity { get; init; } 
    #else
    public CorporateActionQuantity8? SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_DrkXdc3yEee5nJBZsW8MFQ")]
    [DisplayName("Interest Accrued Number Of Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstAcrdNbOfDays")]
    #endif
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? InterestAccruedNumberOfDays { get; init; } 
    #else
    public System.UInt64? InterestAccruedNumberOfDays { get; set; } 
    #endif
    
    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [IsoId("_DrkXfc3yEee5nJBZsW8MFQ")]
    [DisplayName("Coupon Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnNb")]
    #endif
    [IsoXmlTag("CpnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IdentificationFormat4Choice_? CouponNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationFormat4Choice_? CouponNumber { get; init; } 
    #else
    public IdentificationFormat4Choice_? CouponNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether certification/breakdown is required. 
    /// Yes = certification required.
    /// No = no certification required.
    /// </summary>
    [IsoId("_DrkXhc3yEee5nJBZsW8MFQ")]
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
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_DrkXjc3yEee5nJBZsW8MFQ")]
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
    /// Indicates whether there is restrictions apply to the corporate action event or not.|Yes = There is restrictions.|No = There is no restrictions.
    /// </summary>
    [IsoId("_DrkXlc3yEee5nJBZsW8MFQ")]
    [DisplayName("Restriction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnInd")]
    #endif
    [IsoXmlTag("RstrctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RestrictionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RestrictionIndicator { get; init; } 
    #else
    public System.String? RestrictionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    [IsoId("_DrkXnc3yEee5nJBZsW8MFQ")]
    [DisplayName("Accrued Interest Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstInd")]
    #endif
    [IsoXmlTag("AcrdIntrstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccruedInterestIndicator { get; init; } 
    #else
    public System.String? AccruedInterestIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a letter of guaranteed delivery can be submitted in order to participate in the offer on full eligible position. It is not intended for use in situations arising from failed or late trades.
    /// </summary>
    [IsoId("_DrkXpc3yEee5nJBZsW8MFQ")]
    [DisplayName("Letter Of Guaranteed Delivery Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfGrntedDlvryInd")]
    #endif
    [IsoXmlTag("LttrOfGrntedDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LetterOfGuaranteedDeliveryIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LetterOfGuaranteedDeliveryIndicator { get; init; } 
    #else
    public System.String? LetterOfGuaranteedDeliveryIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("_DrkXp83yEee5nJBZsW8MFQ")]
    [DisplayName("Dividend Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddTp")]
    #endif
    [IsoXmlTag("DvddTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DividendTypeFormat10Choice_? DividendType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DividendTypeFormat10Choice_? DividendType { get; init; } 
    #else
    public DividendTypeFormat10Choice_? DividendType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conversion type of an instrument.
    /// </summary>
    [IsoId("_DrkXr83yEee5nJBZsW8MFQ")]
    [DisplayName("Conversion Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsTp")]
    #endif
    [IsoXmlTag("ConvsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConversionTypeFormat4Choice_? ConversionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConversionTypeFormat4Choice_? ConversionType { get; init; } 
    #else
    public ConversionTypeFormat4Choice_? ConversionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    [IsoId("_DrkXt83yEee5nJBZsW8MFQ")]
    [DisplayName("Occurrence Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OcrncTp")]
    #endif
    [IsoXmlTag("OcrncTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionTypeFormat8Choice_? OccurrenceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionTypeFormat8Choice_? OccurrenceType { get; init; } 
    #else
    public DistributionTypeFormat8Choice_? OccurrenceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_DrkXv83yEee5nJBZsW8MFQ")]
    [DisplayName("Offer Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OfferTp")]
    #endif
    [IsoXmlTag("OfferTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OfferTypeFormat11Choice_? OfferType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OfferTypeFormat11Choice_? OfferType { get; init; } 
    #else
    public OfferTypeFormat11Choice_? OfferType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_DrkXx83yEee5nJBZsW8MFQ")]
    [DisplayName("Renounceable Entitlement Status Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RnncblEntitlmntStsTp")]
    #endif
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RenounceableEntitlementStatusTypeFormat4Choice_? RenounceableEntitlementStatusType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RenounceableEntitlementStatusTypeFormat4Choice_? RenounceableEntitlementStatusType { get; init; } 
    #else
    public RenounceableEntitlementStatusTypeFormat4Choice_? RenounceableEntitlementStatusType { get; set; } 
    #endif
    
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_DrkXz83yEee5nJBZsW8MFQ")]
    [DisplayName("Event Stage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtStag")]
    #endif
    [IsoXmlTag("EvtStag")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventStageFormat20Choice_? EventStage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventStageFormat20Choice_? EventStage { get; init; } 
    #else
    public CorporateActionEventStageFormat20Choice_? EventStage { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the additional business process linked to a corporate action event such as a claim compensation or tax refund.
    /// </summary>
    [IsoId("_DrkX183yEee5nJBZsW8MFQ")]
    [DisplayName("Additional Business Process Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBizPrcInd")]
    #endif
    [IsoXmlTag("AddtlBizPrcInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBusinessProcessFormat12Choice_? AdditionalBusinessProcessIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBusinessProcessFormat12Choice_? AdditionalBusinessProcessIndicator { get; init; } 
    #else
    public AdditionalBusinessProcessFormat12Choice_? AdditionalBusinessProcessIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("_DrkX383yEee5nJBZsW8MFQ")]
    [DisplayName("Change Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngTp")]
    #endif
    [IsoXmlTag("ChngTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionChangeTypeFormat8Choice_? ChangeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionChangeTypeFormat8Choice_? ChangeType { get; init; } 
    #else
    public CorporateActionChangeTypeFormat8Choice_? ChangeType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [IsoId("_DrkX583yEee5nJBZsW8MFQ")]
    [DisplayName("Intermediate Securities Distribution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmdtSctiesDstrbtnTp")]
    #endif
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IntermediateSecuritiesDistributionTypeFormat18Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntermediateSecuritiesDistributionTypeFormat18Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    #else
    public IntermediateSecuritiesDistributionTypeFormat18Choice_? IntermediateSecuritiesDistributionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    [IsoId("_DrkX783yEee5nJBZsW8MFQ")]
    [DisplayName("Capital Gain In Out Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CptlGnInOutInd")]
    #endif
    [IsoXmlTag("CptlGnInOutInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CapitalGainFormat4Choice_? CapitalGainInOutIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CapitalGainFormat4Choice_? CapitalGainInOutIndicator { get; init; } 
    #else
    public CapitalGainFormat4Choice_? CapitalGainInOutIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("_DrkX983yEee5nJBZsW8MFQ")]
    [DisplayName("Taxable Income Per Share Calculated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShrClctd")]
    #endif
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxableIncomePerShareCalculatedFormat4Choice_? TaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxableIncomePerShareCalculatedFormat4Choice_? TaxableIncomePerShareCalculated { get; init; } 
    #else
    public TaxableIncomePerShareCalculatedFormat4Choice_? TaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    [IsoId("_DrkX_83yEee5nJBZsW8MFQ")]
    [DisplayName("Election Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnTp")]
    #endif
    [IsoXmlTag("ElctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ElectionTypeFormat4Choice_? ElectionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElectionTypeFormat4Choice_? ElectionType { get; init; } 
    #else
    public ElectionTypeFormat4Choice_? ElectionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_DrkYB83yEee5nJBZsW8MFQ")]
    [DisplayName("Lottery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtryTp")]
    #endif
    [IsoXmlTag("LtryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LotteryTypeFormat5Choice_? LotteryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LotteryTypeFormat5Choice_? LotteryType { get; init; } 
    #else
    public LotteryTypeFormat5Choice_? LotteryType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    [IsoId("_DrkYD83yEee5nJBZsW8MFQ")]
    [DisplayName("Certification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnTp")]
    #endif
    [IsoXmlTag("CertfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CertificationTypeFormat4Choice_? CertificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificationTypeFormat4Choice_? CertificationType { get; init; } 
    #else
    public CertificationTypeFormat4Choice_? CertificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    [IsoId("_DrkYF83yEee5nJBZsW8MFQ")]
    [DisplayName("Consent Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnsntTp")]
    #endif
    [IsoXmlTag("CnsntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConsentTypeFormat5Choice_? ConsentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConsentTypeFormat5Choice_? ConsentType { get; init; } 
    #else
    public ConsentTypeFormat5Choice_? ConsentType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    [IsoId("_DrkYGc3yEee5nJBZsW8MFQ")]
    [DisplayName("Information Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfTp")]
    #endif
    [IsoXmlTag("InfTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InformationTypeFormat5Choice_? InformationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InformationTypeFormat5Choice_? InformationType { get; init; } 
    #else
    public InformationTypeFormat5Choice_? InformationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event.
    /// </summary>
    [IsoId("_DrkYG83yEee5nJBZsW8MFQ")]
    [DisplayName("Tax On Non Distributed Proceeds Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnNonDstrbtdPrcdsInd")]
    #endif
    [IsoXmlTag("TaxOnNonDstrbtdPrcdsInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification47? TaxOnNonDistributedProceedsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification47? TaxOnNonDistributedProceedsIndicator { get; init; } 
    #else
    public GenericIdentification47? TaxOnNonDistributedProceedsIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// New company&apos;s place of incorporation.
    /// </summary>
    [IsoId("_DrkYHc3yEee5nJBZsW8MFQ")]
    [DisplayName("New Place Of Incorporation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewPlcOfIncorprtn")]
    #endif
    [IsoXmlTag("NewPlcOfIncorprtn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax350Text? NewPlaceOfIncorporation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewPlaceOfIncorporation { get; init; } 
    #else
    public System.String? NewPlaceOfIncorporation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_DrkYJc3yEee5nJBZsW8MFQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative39? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative39? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative39? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
