// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.012.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is an extension used by TSE/JASDEC and its community to provide supplementary data to the CorporateActionNotification 002V04, which is the restricted version that supports the coexistence of ISO messages.
/// </summary>
[Description(@"This message is an extension used by TSE/JASDEC and its community to provide supplementary data to the CorporateActionNotification 002V04, which is the restricted version that supports the coexistence of ISO messages.")]
[IsoId("_oznswV_DEeK92NuVSnCzFw")]
[DisplayName("TSEJASDEC Corporate Action Notification Subset SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TSEJASDECCorporateActionNotificationSubsetSD1V02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.012.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TSEJASDECCorpActnNtfctnSubsetSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.012.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Extension to an identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("_oznsyV_DEeK92NuVSnCzFw")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification2SD1? OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification2SD1? OtherIdentification { get; init; } 
    #else
    public OtherIdentification2SD1? OtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide additional information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_oznszV_DEeK92NuVSnCzFw")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DividendSD1? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DividendSD1? RateAndAmountDetails { get; init; } 
    #else
    public DividendSD1? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide more information for the underlying security.
    /// </summary>
    [IsoId("_ozns0V_DEeK92NuVSnCzFw")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes23SD1? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes23SD1? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributes23SD1? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide information about the securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_ozns1V_DEeK92NuVSnCzFw")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionQuantity4SD2? SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionQuantity4SD2? SecuritiesQuantity { get; init; } 
    #else
    public CorporateActionQuantity4SD2? SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to specify additional information related to the type of dividend.
    /// </summary>
    [IsoId("_ozns2V_DEeK92NuVSnCzFw")]
    [DisplayName("Dividend Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddTp")]
    #endif
    [IsoXmlTag("DvddTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DividendTypeFormat4SD1? DividendType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DividendTypeFormat4SD1? DividendType { get; init; } 
    #else
    public DividendTypeFormat4SD1? DividendType { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide additional corporate action details information.
    /// </summary>
    [IsoId("_ozns3V_DEeK92NuVSnCzFw")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction6SD1? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction6SD1? CorporateActionDetails { get; init; } 
    #else
    public CorporateAction6SD1? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide information about the entity making the offer (when it is different from the issuing company).
    /// </summary>
    [IsoId("_6-_agGCTEeK8P92abE6HIA")]
    [DisplayName("Offeror")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Offerr")]
    #endif
    [IsoXmlTag("Offerr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation6SD3? Offeror { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation6SD3? Offeror { get; init; } 
    #else
    public UpdatedAdditionalInformation6SD3? Offeror { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to capture the new to old ratio with higher precision.
    /// </summary>
    [IsoId("_ozns4V_DEeK92NuVSnCzFw")]
    [DisplayName("Rate Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateDtls")]
    #endif
    [IsoXmlTag("RateDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate19SD1? RateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate19SD1? RateDetails { get; init; } 
    #else
    public CorporateActionRate19SD1? RateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension for the stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_ozns5V_DEeK92NuVSnCzFw")]
    [DisplayName("Event Stage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtStag")]
    #endif
    [IsoXmlTag("EvtStag")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventStageFormat4SD1? EventStage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventStageFormat4SD1? EventStage { get; init; } 
    #else
    public CorporateActionEventStageFormat4SD1? EventStage { get; set; } 
    #endif
    
    /// <summary>
    /// Extension for the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_ozns6V_DEeK92NuVSnCzFw")]
    [DisplayName("Option Features")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnFeatrs")]
    #endif
    [IsoXmlTag("OptnFeatrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionFeaturesFormat8SD1? OptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionFeaturesFormat8SD1? OptionFeatures { get; init; } 
    #else
    public OptionFeaturesFormat8SD1? OptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide information on additional corporate action dates.
    /// </summary>
    [IsoId("_ozns7V_DEeK92NuVSnCzFw")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDate21SD1? DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate21SD1? DateDetails { get; init; } 
    #else
    public CorporateActionDate21SD1? DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide breakdown details as used by custody banks for tax processing and asset valuation.
    /// </summary>
    [IsoId("_ozns8V_DEeK92NuVSnCzFw")]
    [DisplayName("Gross Dividend Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssDvddRate")]
    #endif
    [IsoXmlTag("GrssDvddRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GrossDividendRateFormat6SD1? GrossDividendRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GrossDividendRateFormat6SD1? GrossDividendRate { get; init; } 
    #else
    public GrossDividendRateFormat6SD1? GrossDividendRate { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide information about the dates related to securities movement.
    /// </summary>
    [IsoId("_ozns9V_DEeK92NuVSnCzFw")]
    [DisplayName("Securities Movement Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntDtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityDate8SD1? SecuritiesMovementDateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityDate8SD1? SecuritiesMovementDateDetails { get; init; } 
    #else
    public SecurityDate8SD1? SecuritiesMovementDateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide extra parameters of the securities of the counterparties in a merger or exchange offer.
    /// </summary>
    [IsoId("_ozns-V_DEeK92NuVSnCzFw")]
    [DisplayName("Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesOption22SD1? SecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOption22SD1? SecuritiesMovementDetails { get; init; } 
    #else
    public SecuritiesOption22SD1? SecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide the new name of a company following a name change.
    /// </summary>
    [IsoId("_ozntAV_DEeK92NuVSnCzFw")]
    [DisplayName("New Company Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewCpnyNm")]
    #endif
    [IsoXmlTag("NewCpnyNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation6SD2? NewCompanyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation6SD2? NewCompanyName { get; init; } 
    #else
    public UpdatedAdditionalInformation6SD2? NewCompanyName { get; set; } 
    #endif
    
    /// <summary>
    /// Extension for the name of the Issuer Agent.
    /// </summary>
    [IsoId("_ozntBV_DEeK92NuVSnCzFw")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentificationSD1? IssuerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentificationSD1? IssuerAgent { get; init; } 
    #else
    public OrganisationIdentificationSD1? IssuerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide additional taxation information related to the corporate action event.
    /// </summary>
    [IsoId("_ozntCV_DEeK92NuVSnCzFw")]
    [DisplayName("Taxation Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnConds")]
    #endif
    [IsoXmlTag("TaxtnConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation5SD1? TaxationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation5SD1? TaxationConditions { get; init; } 
    #else
    public UpdatedAdditionalInformation5SD1? TaxationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Extension to provide additional narrative information in the local language.
    /// </summary>
    [IsoId("_ozntDV_DEeK92NuVSnCzFw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative17SD1? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative17SD1? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative17SD1? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since TSEJASDECCorporateActionNotificationSubsetSD1V02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TSEJASDECCorporateActionNotificationSubsetSD1V02.

