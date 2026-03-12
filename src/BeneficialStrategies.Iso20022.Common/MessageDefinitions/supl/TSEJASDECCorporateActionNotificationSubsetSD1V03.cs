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



namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.012.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is an extension used by TSE/JASDEC and its community to provide supplementary data to the CorporateActionNotification 002, which is the restricted version that supports the coexistence of ISO messages.
/// </summary>
[Description(@"This message is an extension used by TSE/JASDEC and its community to provide supplementary data to the CorporateActionNotification 002, which is the restricted version that supports the coexistence of ISO messages.")]
[IsoId("_HEsq4aKSEeOo48XfssNw8w")]
[DisplayName("TSEJASDEC Corporate Action Notification Subset SD 1 V")]
public partial record TSEJASDECCorporateActionNotificationSubsetSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.012.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TSEJASDECCorpActnNtfctnSubsetSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.012.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Extension to an identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("_HEtR86KSEeOo48XfssNw8w")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public OtherIdentification2SD1? OtherIdentification { get; init; } 
    
    /// <summary>
    /// Extension to provide additional information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_HEtR9aKSEeOo48XfssNw8w")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public DividendSD1? RateAndAmountDetails { get; init; } 
    
    /// <summary>
    /// Extension to provide more information for the underlying security.
    /// </summary>
    [IsoId("_HEtR96KSEeOo48XfssNw8w")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributes23SD1? UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Extension to provide information about the securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_HEtR-aKSEeOo48XfssNw8w")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity4SD2? SecuritiesQuantity { get; init; } 
    
    /// <summary>
    /// Extension to specify additional information related to the type of dividend.
    /// </summary>
    [IsoId("_HEtR-6KSEeOo48XfssNw8w")]
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat4SD1? DividendType { get; init; } 
    
    /// <summary>
    /// Extension to provide additional corporate action details information.
    /// </summary>
    [IsoId("_HEtR_aKSEeOo48XfssNw8w")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction6SD1? CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Extension to provide information about the entity making the offer (when it is different from the issuing company).
    /// </summary>
    [IsoId("_HEtR_6KSEeOo48XfssNw8w")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public UpdatedAdditionalInformation6SD3? Offeror { get; init; } 
    
    /// <summary>
    /// Extension to capture the new to old ratio with higher precision.
    /// </summary>
    [IsoId("_HEtSAaKSEeOo48XfssNw8w")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate19SD1? RateDetails { get; init; } 
    
    /// <summary>
    /// Extension for the stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_HEtSA6KSEeOo48XfssNw8w")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public CorporateActionEventStageFormat4SD1? EventStage { get; init; } 
    
    /// <summary>
    /// Extension for the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_HEtSBaKSEeOo48XfssNw8w")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat8SD1? OptionFeatures { get; init; } 
    
    /// <summary>
    /// Extension to provide information on additional corporate action dates.
    /// </summary>
    [IsoId("_HEtSB6KSEeOo48XfssNw8w")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate21SD1? DateDetails { get; init; } 
    
    /// <summary>
    /// Extension to provide breakdown details as used by custody banks for tax processing and asset valuation.
    /// </summary>
    [IsoId("_HEtSCaKSEeOo48XfssNw8w")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public GrossDividendRateFormat6SD1? GrossDividendRate { get; init; } 
    
    /// <summary>
    /// Extension to provide information about the dates related to securities movement.
    /// </summary>
    [IsoId("_HEtSC6KSEeOo48XfssNw8w")]
    [DisplayName("Securities Movement Date Details")]
    [IsoXmlTag("SctiesMvmntDtDtls")]
    public SecurityDate8SD1? SecuritiesMovementDateDetails { get; init; } 
    
    /// <summary>
    /// Extension to provide extra parameters of the securities of the counterparties in a merger or exchange offer.
    /// </summary>
    [IsoId("_HEtSDaKSEeOo48XfssNw8w")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public SecuritiesOption22SD1? SecuritiesMovementDetails { get; init; } 
    
    /// <summary>
    /// Extension to provide the new name of a company following a name change.
    /// </summary>
    [IsoId("_HEtSD6KSEeOo48XfssNw8w")]
    [DisplayName("New Company Name")]
    [IsoXmlTag("NewCpnyNm")]
    public UpdatedAdditionalInformation6SD2? NewCompanyName { get; init; } 
    
    /// <summary>
    /// Extension for the name of the Issuer Agent.
    /// </summary>
    [IsoId("_HEtSEaKSEeOo48XfssNw8w")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public OrganisationIdentificationSD1? IssuerAgent { get; init; } 
    
    /// <summary>
    /// Extension to provide additional taxation information related to the corporate action event.
    /// </summary>
    [IsoId("_HEtSE6KSEeOo48XfssNw8w")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation5SD3? TaxationConditions { get; init; } 
    
    /// <summary>
    /// Extension to provide additional narrative information in the local language.
    /// </summary>
    [IsoId("_HEtSFaKSEeOo48XfssNw8w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative17SD1? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}


// Since TSEJASDECCorporateActionNotificationSubsetSD1V03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TSEJASDECCorporateActionNotificationSubsetSD1V03.

