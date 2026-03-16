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



namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.027.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_Xx1LEYZHEe-6cOl7zMpJaA")]
[DisplayName("Securities Trade Confirmation V05")]
public partial record SecuritiesTradeConfirmationV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.027.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.027.001.05";
    
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
    /// Cash Parties.
    /// </summary>
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties33? CashParties { get; init; } 
    
    /// <summary>
    /// Clearing Details.
    /// </summary>
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing5? ClearingDetails { get; init; } 
    
    /// <summary>
    /// Confirmation Parties.
    /// </summary>
    [DisplayName("Confirmation Parties")]
    [IsoXmlTag("ConfPties")]
    public ValueList<ConfirmationParties6> ConfirmationParties { get; init; } = [];
    
    /// <summary>
    /// Delivering Settlement Parties.
    /// </summary>
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties59? DeliveringSettlementParties { get; init; } 
    
    /// <summary>
    /// Financial Instrument Attributes.
    /// </summary>
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes124? FinancialInstrumentAttributes { get; init; } 
    
    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required TransactiontIdentification4 Identification { get; init; } 
    
    /// <summary>
    /// Number Count.
    /// </summary>
    [DisplayName("Number Count")]
    [IsoXmlTag("NbCnt")]
    public NumberCount1Choice_? NumberCount { get; init; } 
    
    /// <summary>
    /// Other Amounts.
    /// </summary>
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public ValueList<OtherAmounts16> OtherAmounts { get; init; } = [];
    
    /// <summary>
    /// Other Business Parties.
    /// </summary>
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties32? OtherBusinessParties { get; init; } 
    
    /// <summary>
    /// Other Prices.
    /// </summary>
    [DisplayName("Other Prices")]
    [IsoXmlTag("OthrPrics")]
    public ValueList<OtherPrices5> OtherPrices { get; init; } = [];
    
    /// <summary>
    /// Receiving Settlement Parties.
    /// </summary>
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties59? ReceivingSettlementParties { get; init; } 
    
    /// <summary>
    /// References.
    /// </summary>
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<Linkages76> References { get; init; } = [];
    
    /// <summary>
    /// Regulatory Stipulations.
    /// </summary>
    [DisplayName("Regulatory Stipulations")]
    [IsoXmlTag("RgltryStiptns")]
    public RegulatoryStipulations1? RegulatoryStipulations { get; init; } 
    
    /// <summary>
    /// Settlement Amount.
    /// </summary>
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection28? SettlementAmount { get; init; } 
    
    /// <summary>
    /// Settlement Parameters.
    /// </summary>
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails213? SettlementParameters { get; init; } 
    
    /// <summary>
    /// Standing Settlement Instruction.
    /// </summary>
    [DisplayName("Standing Settlement Instruction")]
    [IsoXmlTag("StgSttlmInstr")]
    public StandingSettlementInstruction13? StandingSettlementInstruction { get; init; } 
    
    /// <summary>
    /// Stipulations.
    /// </summary>
    [DisplayName("Stipulations")]
    [IsoXmlTag("Stiptns")]
    public FinancialInstrumentStipulations4? Stipulations { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    /// <summary>
    /// Trade Details.
    /// </summary>
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public required Order24 TradeDetails { get; init; } 
    
    /// <summary>
    /// Two Leg Transaction Details.
    /// </summary>
    [DisplayName("Two Leg Transaction Details")]
    [IsoXmlTag("TwoLegTxDtls")]
    public TwoLegTransactionDetails5? TwoLegTransactionDetails { get; init; } 
    
    /// <summary>
    /// Underlying Financial Instrument.
    /// </summary>
    [DisplayName("Underlying Financial Instrument")]
    [IsoXmlTag("UndrlygFinInstrm")]
    public ValueList<UnderlyingFinancialInstrument7> UnderlyingFinancialInstrument { get; init; } = [];
    
    
    #nullable disable
    
}


// Since SecuritiesTradeConfirmationV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationV05.

