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
/// This record is an implementation of the supl.001.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.
/// </summary>
[Description(@"The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.")]
[IsoId("_I7q0IZCEEeaSk9d1hvTrHg")]
[DisplayName("DTCCCANOCSD Data SD 1 V")]
public partial record DTCCCANOCSDDataSD1V09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.001.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.09";
    
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
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_I7rbMZCEEeaSk9d1hvTrHg")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public CorporateActionNotificationSD3? NotificationGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_I7rbM5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD23? CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_I7rbNZCEEeaSk9d1hvTrHg")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD14? UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_I7rbN5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD14? CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_I7rbOZCEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Date Details")]
    [IsoXmlTag("CorpActnDtDtls")]
    public CorporateActionDateSD5? CorporateActionDateDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_I7rbO5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Price Details")]
    [IsoXmlTag("CorpActnPricDtls")]
    public CorporateActionPriceSD3? CorporateActionPriceDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_I7rbPZCEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Period Details")]
    [IsoXmlTag("CorpActnPrdDtls")]
    public CorporateActionPeriodSD2? CorporateActionPeriodDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_I7rbP5CEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Rate And Amount Details")]
    [IsoXmlTag("CorpActnRateAndAmtDtls")]
    public CorporateActionRateSD5? CorporateActionRateAndAmountDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_I7rbQZCEEeaSk9d1hvTrHg")]
    [DisplayName("Corporate Action Securities Quantity")]
    [IsoXmlTag("CorpActnSctiesQty")]
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantity { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_I7rbQ5CEEeaSk9d1hvTrHg")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public CorporateActionOptionSD10? OptionDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to option date details.
    /// </summary>
    [IsoId("_iSsHgJEYEeajS_7NioJdVA")]
    [DisplayName("Option Date Details")]
    [IsoXmlTag("OptnDtDtls")]
    public CorporateActionDateSD7? OptionDateDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_I7rbRZCEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public SecuritiesOptionSD8? SecuritiesMovementDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_I7rbR5CEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Security Details")]
    [IsoXmlTag("SctiesMvmntSctyDtls")]
    public FinancialInstrumentAttributesSD13? SecuritiesMovementSecurityDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_I7rbSZCEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Rate Details")]
    [IsoXmlTag("SctiesMvmntRateDtls")]
    public CorporateActionRateSD8? SecuritiesMovementRateDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as securities movement cash in lieu supplementary data.
    /// </summary>
    [IsoId("_I7rbS5CEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Cash In Lieu Details")]
    [IsoXmlTag("SctiesMvmntCshInLieuDtls")]
    public CorporateActionPriceSD1? SecuritiesMovementCashInLieuDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_I7rbTZCEEeaSk9d1hvTrHg")]
    [DisplayName("Securities Movement Fraction Disposition")]
    [IsoXmlTag("SctiesMvmntFrctnDspstn")]
    public FractionDispositionTypeSD2? SecuritiesMovementFractionDisposition { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_I7rbT5CEEeaSk9d1hvTrHg")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public CashOptionSD10? CashMovementDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_I7rbUZCEEeaSk9d1hvTrHg")]
    [DisplayName("New Agent")]
    [IsoXmlTag("NewAgt")]
    public PartyIdentificationSD1? NewAgent { get; init; } 
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like &quot;issuer agent&quot;, &quot;reselling agent&quot;, etc). Used when required &quot;ISO agent type&quot; exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_I7rbU5CEEeaSk9d1hvTrHg")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public PartyIdentificationSD2? Agent { get; init; } 
    
    
    #nullable disable
    
}


// Since DTCCCANOCSDDataSD1V09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOCSDDataSD1V09.

