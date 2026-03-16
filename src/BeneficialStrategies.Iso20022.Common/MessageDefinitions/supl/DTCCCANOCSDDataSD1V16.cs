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
/// This record is an implementation of the supl.001.001.16 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_Xt5vl3GxEe6S2Llv74R19w")]
[DisplayName("DTCCCANOCSD Data SD1V16")]
public partial record DTCCCANOCSDDataSD1V16 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.001.001.16";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.16";
    
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
    /// Agent.
    /// </summary>
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public ValueList<PartyIdentificationSD6> Agent { get; init; } = [];
    
    /// <summary>
    /// Cash Movement Details.
    /// </summary>
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOptionSD14> CashMovementDetails { get; init; } = [];
    
    /// <summary>
    /// Corporate Action Date Details.
    /// </summary>
    [DisplayName("Corporate Action Date Details")]
    [IsoXmlTag("CorpActnDtDtls")]
    public CorporateActionDateSD10? CorporateActionDateDetails { get; init; } 
    
    /// <summary>
    /// Corporate Action Details.
    /// </summary>
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD24? CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD47? CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Corporate Action Period Details.
    /// </summary>
    [DisplayName("Corporate Action Period Details")]
    [IsoXmlTag("CorpActnPrdDtls")]
    public CorporateActionPeriodSD3? CorporateActionPeriodDetails { get; init; } 
    
    /// <summary>
    /// Corporate Action Price Details.
    /// </summary>
    [DisplayName("Corporate Action Price Details")]
    [IsoXmlTag("CorpActnPricDtls")]
    public CorporateActionPriceSD4? CorporateActionPriceDetails { get; init; } 
    
    /// <summary>
    /// Corporate Action Rate And Amount Details.
    /// </summary>
    [DisplayName("Corporate Action Rate And Amount Details")]
    [IsoXmlTag("CorpActnRateAndAmtDtls")]
    public CorporateActionRateSD9? CorporateActionRateAndAmountDetails { get; init; } 
    
    /// <summary>
    /// Corporate Action Securities Quantity.
    /// </summary>
    [DisplayName("Corporate Action Securities Quantity")]
    [IsoXmlTag("CorpActnSctiesQty")]
    public CorporateActionQuantitySD3? CorporateActionSecuritiesQuantity { get; init; } 
    
    /// <summary>
    /// New Agent.
    /// </summary>
    [DisplayName("New Agent")]
    [IsoXmlTag("NewAgt")]
    public ValueList<PartyIdentificationSD5> NewAgent { get; init; } = [];
    
    /// <summary>
    /// Notification General Information.
    /// </summary>
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public CorporateActionNotificationSD9? NotificationGeneralInformation { get; init; } 
    
    /// <summary>
    /// Option Date Details.
    /// </summary>
    [DisplayName("Option Date Details")]
    [IsoXmlTag("OptnDtDtls")]
    public ValueList<CorporateActionDateSD11> OptionDateDetails { get; init; } = [];
    
    /// <summary>
    /// Option Details.
    /// </summary>
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public ValueList<CorporateActionOptionSD15> OptionDetails { get; init; } = [];
    
    /// <summary>
    /// Securities Movement Cash In Lieu Details.
    /// </summary>
    [DisplayName("Securities Movement Cash In Lieu Details")]
    [IsoXmlTag("SctiesMvmntCshInLieuDtls")]
    public ValueList<CorporateActionPriceSD5> SecuritiesMovementCashInLieuDetails { get; init; } = [];
    
    /// <summary>
    /// Securities Movement Details.
    /// </summary>
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOptionSD9> SecuritiesMovementDetails { get; init; } = [];
    
    /// <summary>
    /// Securities Movement Fraction Disposition.
    /// </summary>
    [DisplayName("Securities Movement Fraction Disposition")]
    [IsoXmlTag("SctiesMvmntFrctnDspstn")]
    public ValueList<FractionDispositionTypeSD3> SecuritiesMovementFractionDisposition { get; init; } = [];
    
    /// <summary>
    /// Securities Movement Rate Details.
    /// </summary>
    [DisplayName("Securities Movement Rate Details")]
    [IsoXmlTag("SctiesMvmntRateDtls")]
    public ValueList<CorporateActionRateSD10> SecuritiesMovementRateDetails { get; init; } = [];
    
    /// <summary>
    /// Securities Movement Security Details.
    /// </summary>
    [DisplayName("Securities Movement Security Details")]
    [IsoXmlTag("SctiesMvmntSctyDtls")]
    public ValueList<FinancialInstrumentAttributesSD16> SecuritiesMovementSecurityDetails { get; init; } = [];
    
    /// <summary>
    /// Underlying Security.
    /// </summary>
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD19? UnderlyingSecurity { get; init; } 
    
    
    #nullable disable
    
}


// Since DTCCCANOCSDDataSD1V16Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOCSDDataSD1V16.

