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
/// This record is an implementation of the fxtr.015.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeInstructionAmendment message is sent by a participant to a central settlement system to notify the amendment of the foreign exchange trade previously confirmed by the sender.|
/// Usage|
/// The ForeignExchangeTradeInstructionAmendment message is sent from a participant to a central settlement system to advise of the update of a previously sent notification. The &quot;Related Reference&quot; must be used to link it to the previous notification.
/// </summary>
[Description(
    @"Scope||The ForeignExchangeTradeInstructionAmendment message is sent by a participant to a central settlement system to notify the amendment of the foreign exchange trade previously confirmed by the sender.||Usage||The ForeignExchangeTradeInstructionAmendment message is sent from a participant to a central settlement system to advise of the update of a previously sent notification. The ""Related Reference"" must be used to link it to the previous notification."
)]
[IsoId("_yW59oTJ5EeOd1OidA-8_VQ")]
[DisplayName("Foreign Exchange Trade Instruction Amendment V")]
public record ForeignExchangeTradeInstructionAmendmentV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.015.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradInstrAmdmnt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.015.001.03";

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
    [IsoId("_yW59ozJ5EeOd1OidA-8_VQ")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement11 TradeInformation { get; init; }

    /// <summary>
    /// Party(ies) on the trading side of the trade.
    /// </summary>
    [IsoId("_yW59pTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification6 TradingSideIdentification { get; init; }

    /// <summary>
    /// Party(ies) on the counterparty side of the trade.
    /// </summary>
    [IsoId("_yW59pzJ5EeOd1OidA-8_VQ")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification6 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Amounts of the trade.
    /// </summary>
    [IsoId("_yW59qTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }

    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_yW59qzJ5EeOd1OidA-8_VQ")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public required AgreedRate1 AgreedRate { get; init; }

    /// <summary>
    /// Settlement instructions for the amounts received by the trading side.
    /// </summary>
    [IsoId("_yW59rTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Trading Side Settlement Instructions")]
    [IsoXmlTag("TradgSdSttlmInstrs")]
    public SettlementParties29? TradingSideSettlementInstructions { get; init; }

    /// <summary>
    /// Settlement instructions for the amounts received by the counterparty.
    /// </summary>
    [IsoId("_yW59rzJ5EeOd1OidA-8_VQ")]
    [DisplayName("Counterparty Side Settlement Instructions")]
    [IsoXmlTag("CtrPtySdSttlmInstrs")]
    public SettlementParties29? CounterpartySideSettlementInstructions { get; init; }

    /// <summary>
    /// Specifies whether the trade is a block or an individual trade. It also contains supplementary information such as free format information, broker&apos;s identification, dealing branches and references.
    /// </summary>
    [IsoId("_yW59sTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Optional General Information")]
    [IsoXmlTag("OptnlGnlInf")]
    public GeneralInformation4? OptionalGeneralInformation { get; init; }

    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_yW59szJ5EeOd1OidA-8_VQ")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public RegulatoryReporting4? RegulatoryReporting { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_yW59tTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ForeignExchangeTradeInstructionAmendmentV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeInstructionAmendmentV03.
