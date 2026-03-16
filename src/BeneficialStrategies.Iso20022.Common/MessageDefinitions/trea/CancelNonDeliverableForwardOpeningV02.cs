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

namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// This record is an implementation of the trea.003.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CancelNonDeliverableForwardOpening message is sent by a participant to a central system or to a counterparty to notify the cancellation of the opening of a non deliverable trade previously confirmed by the sender.
/// Usage
/// The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.
/// </summary>
[Description(
    @"Scope|The CancelNonDeliverableForwardOpening message is sent by a participant to a central system or to a counterparty to notify the cancellation of the opening of a non deliverable trade previously confirmed by the sender.|Usage|The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation."
)]
[IsoId("_L_cYkNE8Ed-BzquC8wXy7w_-895168583")]
[DisplayName("Cancel Non Deliverable Forward Opening V")]
public record CancelNonDeliverableForwardOpeningV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.003.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclNDFOpngV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.003.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides references and date of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYkdE8Ed-BzquC8wXy7w_1664087842")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement2 TradeInformation { get; init; }

    /// <summary>
    /// Specifies the trading side of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYktE8Ed-BzquC8wXy7w_940702862")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public TradePartyIdentification3? TradingSideIdentification { get; init; }

    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYk9E8Ed-BzquC8wXy7w_513113458")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public TradePartyIdentification3? CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Specifies the amounts of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYlNE8Ed-BzquC8wXy7w_1602210594")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public AmountsAndValueDate1? TradeAmounts { get; init; }

    /// <summary>
    /// Specifies the rate of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYldE8Ed-BzquC8wXy7w_1140450467")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public AgreedRate1? AgreedRate { get; init; }

    /// <summary>
    /// Specifies the valuation conditions of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYltE8Ed-BzquC8wXy7w_-1799937844")]
    [DisplayName("Valuation Conditions")]
    [IsoXmlTag("ValtnConds")]
    public NonDeliverableForwardValuationConditions2? ValuationConditions { get; init; }
}

// Since CancelNonDeliverableForwardOpeningV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CancelNonDeliverableForwardOpeningV02.
