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
/// This record is an implementation of the fxtr.015.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeInstructionAmendment message is sent by a participant to a central settlement system to notify the amendment of the foreign exchange trade previously confirmed by the sender.|
/// Usage|
/// The ForeignExchangeTradeInstructionAmendment message is sent from a participant to a central settlement system to advise of the update of a previously sent notification. The &quot;Related Reference&quot; must be used to link it to the previous notification.
/// </summary>
[Description(
    @"Scope||The ForeignExchangeTradeInstructionAmendment message is sent by a participant to a central settlement system to notify the amendment of the foreign exchange trade previously confirmed by the sender.||Usage||The ForeignExchangeTradeInstructionAmendment message is sent from a participant to a central settlement system to advise of the update of a previously sent notification. The ""Related Reference"" must be used to link it to the previous notification."
)]
[IsoId("_mJe8EQM-Ee2nqoJcXIhTdw")]
[DisplayName("Foreign Exchange Trade Instruction Amendment V")]
public record ForeignExchangeTradeInstructionAmendmentV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.015.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradInstrAmdmnt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.015.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// General information related to the trade.
    /// </summary>
    [IsoId("_mJe8EwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement15 TradeInformation { get; init; }

    /// <summary>
    /// Party(ies) on the trading side of the trade.
    /// </summary>
    [IsoId("_mJe8FQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification8 TradingSideIdentification { get; init; }

    /// <summary>
    /// Party(ies) on the counterparty side of the trade.
    /// </summary>
    [IsoId("_mJe8FwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification8 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Amounts of the trade.
    /// </summary>
    [IsoId("_mJe8GQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate6 TradeAmounts { get; init; }

    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_mJe8GwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public required AgreedRate3 AgreedRate { get; init; }

    /// <summary>
    /// Specifies the conditions for a non deliverable opening or fixing confirmation.
    /// </summary>
    [IsoId("_mJe8HQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Non Deliverable Forward Conditions")]
    [IsoXmlTag("NDFConds")]
    public NonDeliverableForwardConditions1? NonDeliverableForwardConditions { get; init; }

    /// <summary>
    /// Settlement instructions for the amounts received by the trading side.
    /// </summary>
    [IsoId("_mJe8HwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trading Side Settlement Instructions")]
    [IsoXmlTag("TradgSdSttlmInstrs")]
    public SettlementParties120? TradingSideSettlementInstructions { get; init; }

    /// <summary>
    /// Settlement instructions for the amounts received by the counterparty.
    /// </summary>
    [IsoId("_mJe8IQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Counterparty Side Settlement Instructions")]
    [IsoXmlTag("CtrPtySdSttlmInstrs")]
    public SettlementParties120? CounterpartySideSettlementInstructions { get; init; }

    /// <summary>
    /// Specifies whether the trade is a block or an individual trade. It also contains supplementary information such as free format information, broker&apos;s identification, dealing branches and references.
    /// </summary>
    [IsoId("_mJe8IwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Optional General Information")]
    [IsoXmlTag("OptnlGnlInf")]
    public GeneralInformation8? OptionalGeneralInformation { get; init; }

    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_mJe8JQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public RegulatoryReporting7? RegulatoryReporting { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mJe8JwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ForeignExchangeTradeInstructionAmendmentV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeInstructionAmendmentV05.
