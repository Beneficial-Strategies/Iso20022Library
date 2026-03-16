// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.014.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_yGWL4UjqEe-KhcStGV4xTg")]
[DisplayName("Foreign Exchange Trade Instruction V06")]
public record ForeignExchangeTradeInstructionV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.014.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.014.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Agreed Rate.
    /// </summary>
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public required AgreedRate3 AgreedRate { get; init; }

    /// <summary>
    /// Counterparty Side Identification.
    /// </summary>
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification8 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Counterparty Side Settlement Instructions.
    /// </summary>
    [DisplayName("Counterparty Side Settlement Instructions")]
    [IsoXmlTag("CtrPtySdSttlmInstrs")]
    public SettlementParties120? CounterpartySideSettlementInstructions { get; init; }

    /// <summary>
    /// Non Deliverable Forward Conditions.
    /// </summary>
    [DisplayName("Non Deliverable Forward Conditions")]
    [IsoXmlTag("NDFConds")]
    public NonDeliverableForwardConditions1? NonDeliverableForwardConditions { get; init; }

    /// <summary>
    /// Optional General Information.
    /// </summary>
    [DisplayName("Optional General Information")]
    [IsoXmlTag("OptnlGnlInf")]
    public GeneralInformation9? OptionalGeneralInformation { get; init; }

    /// <summary>
    /// Post Trade Event.
    /// </summary>
    [DisplayName("Post Trade Event")]
    [IsoXmlTag("PstTradEvt")]
    public PostTradeEvent1? PostTradeEvent { get; init; }

    /// <summary>
    /// Regulatory Reporting.
    /// </summary>
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public RegulatoryReporting8? RegulatoryReporting { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Trade Amounts.
    /// </summary>
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate8 TradeAmounts { get; init; }

    /// <summary>
    /// Trade Information.
    /// </summary>
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement14 TradeInformation { get; init; }

    /// <summary>
    /// Trading Side Identification.
    /// </summary>
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification8 TradingSideIdentification { get; init; }

    /// <summary>
    /// Trading Side Settlement Instructions.
    /// </summary>
    [DisplayName("Trading Side Settlement Instructions")]
    [IsoXmlTag("TradgSdSttlmInstrs")]
    public SettlementParties120? TradingSideSettlementInstructions { get; init; }
}

// Since ForeignExchangeTradeInstructionV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeInstructionV06.
