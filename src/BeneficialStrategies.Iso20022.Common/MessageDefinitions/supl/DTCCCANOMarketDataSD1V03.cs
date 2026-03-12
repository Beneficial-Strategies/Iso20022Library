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
/// This record is an implementation of the supl.002.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOMarketDataSD1 message extends ISO corporate action notification (CANO) market data message (Market Data type) with data elements that are not covered by the standard message, and additionally, with DTC values where issuer/offeror/market corresponding values are mapped to CANO. For example issuer/offeror/market declared cash rate will be mapped to the CANO and DTC announced cash rate will be extended in this message.
/// </summary>
[Description(@"The DTCCCANOMarketDataSD1 message extends ISO corporate action notification (CANO) market data message (Market Data type) with data elements that are not covered by the standard message, and additionally, with DTC values where issuer/offeror/market corresponding values are mapped to CANO. For example issuer/offeror/market declared cash rate will be mapped to the CANO and DTC announced cash rate will be extended in this message.")]
[IsoId("_1O5jxTL3EeKU9IrkkToqcw_570195189")]
[DisplayName("DTCCCANO Market Data SD 1 V")]
public partial record DTCCCANOMarketDataSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.002.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOMktDataSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.002.001.03";
    
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
    [IsoId("_1PDUwDL3EeKU9IrkkToqcw_698754401")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public CorporateActionNotificationSD3? NotificationGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to general information.
    /// </summary>
    [IsoId("_1PDUwTL3EeKU9IrkkToqcw_-1409229371")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionNotificationSD5? CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_1PDUwjL3EeKU9IrkkToqcw_8359932")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD6? UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_1PDUwzL3EeKU9IrkkToqcw_-959249820")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD1? CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_1PDUxDL3EeKU9IrkkToqcw_458339483")]
    [DisplayName("Corporate Action Date Details")]
    [IsoXmlTag("CorpActnDtDtls")]
    public CorporateActionDateSD5? CorporateActionDateDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_1PDUxTL3EeKU9IrkkToqcw_-1649644289")]
    [DisplayName("Corporate Action Price Details")]
    [IsoXmlTag("CorpActnPricDtls")]
    public CorporateActionPriceSD3? CorporateActionPriceDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_1PDUxjL3EeKU9IrkkToqcw_-232054986")]
    [DisplayName("Corporate Action Period Details")]
    [IsoXmlTag("CorpActnPrdDtls")]
    public CorporateActionPeriodSD2? CorporateActionPeriodDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_1PDUxzL3EeKU9IrkkToqcw_1954928538")]
    [DisplayName("Corporate Action Securities Quantity")]
    [IsoXmlTag("CorpActnSctiesQty")]
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantity { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_1PMesDL3EeKU9IrkkToqcw_-2145539622")]
    [DisplayName("Corporate Action Rate And Amount Details")]
    [IsoXmlTag("CorpActnRateAndAmtDtls")]
    public CorporateActionRateSD5? CorporateActionRateAndAmountDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_1PMesTL3EeKU9IrkkToqcw_-727950319")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public CorporateActionOptionSD1? OptionDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_1PMesjL3EeKU9IrkkToqcw_-1418344788")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public SecuritiesOptionSD2? SecuritiesMovementDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_1PMeszL3EeKU9IrkkToqcw_-1577613287")]
    [DisplayName("Securities Movement Security Details")]
    [IsoXmlTag("SctiesMvmntSctyDtls")]
    public FinancialInstrumentAttributesSD3? SecuritiesMovementSecurityDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_1PMetDL3EeKU9IrkkToqcw_609370237")]
    [DisplayName("Securities Movement Rate Details")]
    [IsoXmlTag("SctiesMvmntRateDtls")]
    public CorporateActionRateSD7? SecuritiesMovementRateDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement cash in lieu.
    /// </summary>
    [IsoId("_1PMetTL3EeKU9IrkkToqcw_2026959540")]
    [DisplayName("Securities Movement Cash In Lieu Details")]
    [IsoXmlTag("SctiesMvmntCshInLieuDtls")]
    public CorporateActionPriceSD2? SecuritiesMovementCashInLieuDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_1PWPsDL3EeKU9IrkkToqcw_-81024232")]
    [DisplayName("Securities Movement Fraction Disposition")]
    [IsoXmlTag("SctiesMvmntFrctnDspstn")]
    public FractionDispositionTypeSD2? SecuritiesMovementFractionDisposition { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_1PWPsTL3EeKU9IrkkToqcw_-1983233102")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public CashOptionSD2? CashMovementDetails { get; init; } 
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like &quot;issuer agent&quot;, &quot;reselling agent&quot;, etc). Used when required &quot;ISO agent type&quot; exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_1PWPsjL3EeKU9IrkkToqcw_-565643799")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public PartyIdentificationSD2? Agent { get; init; } 
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_1PWPszL3EeKU9IrkkToqcw_1621339725")]
    [DisplayName("New Agent")]
    [IsoXmlTag("NewAgt")]
    public PartyIdentificationSD1? NewAgent { get; init; } 
    
    
    #nullable disable
    
}


// Since DTCCCANOMarketDataSD1V03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOMarketDataSD1V03.

