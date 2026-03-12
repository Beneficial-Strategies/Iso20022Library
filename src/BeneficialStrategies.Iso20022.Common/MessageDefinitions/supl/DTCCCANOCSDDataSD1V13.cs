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
/// This record is an implementation of the supl.001.001.13 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/market declared cash rate will be extended in this DTCCCANOCSDDataSD1 message.
/// </summary>
[Description(@"The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/market declared cash rate will be extended in this DTCCCANOCSDDataSD1 message.")]
[IsoId("_q_pKQQ4zEeuIpNw_GxsBOw")]
[DisplayName("DTCCCANOCSD Data SD 1 V")]
public partial record DTCCCANOCSDDataSD1V13 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.001.001.13";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.13";
    
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
    [IsoId("_q_pKQw4zEeuIpNw_GxsBOw")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public CorporateActionNotificationSD9? NotificationGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_q_pKRQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD41? CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_q_pKRw4zEeuIpNw_GxsBOw")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD19? UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_q_pKSQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD22? CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_q_pKSw4zEeuIpNw_GxsBOw")]
    [DisplayName("Corporate Action Date Details")]
    [IsoXmlTag("CorpActnDtDtls")]
    public CorporateActionDateSD10? CorporateActionDateDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action price details.
    /// </summary>
    [IsoId("_q_pKTQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Corporate Action Price Details")]
    [IsoXmlTag("CorpActnPricDtls")]
    public CorporateActionPriceSD4? CorporateActionPriceDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_q_pKTw4zEeuIpNw_GxsBOw")]
    [DisplayName("Corporate Action Period Details")]
    [IsoXmlTag("CorpActnPrdDtls")]
    public CorporateActionPeriodSD3? CorporateActionPeriodDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_q_pKUQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Corporate Action Rate And Amount Details")]
    [IsoXmlTag("CorpActnRateAndAmtDtls")]
    public CorporateActionRateSD9? CorporateActionRateAndAmountDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_q_pKUw4zEeuIpNw_GxsBOw")]
    [DisplayName("Corporate Action Securities Quantity")]
    [IsoXmlTag("CorpActnSctiesQty")]
    public CorporateActionQuantitySD3? CorporateActionSecuritiesQuantity { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_q_pKVQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public CorporateActionOptionSD14? OptionDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to option date details.
    /// </summary>
    [IsoId("_q_pKVw4zEeuIpNw_GxsBOw")]
    [DisplayName("Option Date Details")]
    [IsoXmlTag("OptnDtDtls")]
    public CorporateActionDateSD11? OptionDateDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_q_pKWQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public SecuritiesOptionSD9? SecuritiesMovementDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_q_pKWw4zEeuIpNw_GxsBOw")]
    [DisplayName("Securities Movement Security Details")]
    [IsoXmlTag("SctiesMvmntSctyDtls")]
    public FinancialInstrumentAttributesSD16? SecuritiesMovementSecurityDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_q_pKXQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Securities Movement Rate Details")]
    [IsoXmlTag("SctiesMvmntRateDtls")]
    public CorporateActionRateSD10? SecuritiesMovementRateDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement for cash in lieu details.
    /// </summary>
    [IsoId("_q_pKXw4zEeuIpNw_GxsBOw")]
    [DisplayName("Securities Movement Cash In Lieu Details")]
    [IsoXmlTag("SctiesMvmntCshInLieuDtls")]
    public CorporateActionPriceSD5? SecuritiesMovementCashInLieuDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_q_pKYQ4zEeuIpNw_GxsBOw")]
    [DisplayName("Securities Movement Fraction Disposition")]
    [IsoXmlTag("SctiesMvmntFrctnDspstn")]
    public FractionDispositionTypeSD3? SecuritiesMovementFractionDisposition { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_q_pKYw4zEeuIpNw_GxsBOw")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public CashOptionSD12? CashMovementDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to new agent. Used when the required ISO agent type does not exist and an entire new component must be generated.
    /// </summary>
    [IsoId("_q_pKZQ4zEeuIpNw_GxsBOw")]
    [DisplayName("New Agent")]
    [IsoXmlTag("NewAgt")]
    public PartyIdentificationSD5? NewAgent { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to agent, for example, &quot;issuer agent&quot; and &quot;reselling agent. Used when the required &quot;ISO agent type&quot; exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_q_pKZw4zEeuIpNw_GxsBOw")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public PartyIdentificationSD6? Agent { get; init; } 
    
    
    #nullable disable
    
}


// Since DTCCCANOCSDDataSD1V13Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOCSDDataSD1V13.

