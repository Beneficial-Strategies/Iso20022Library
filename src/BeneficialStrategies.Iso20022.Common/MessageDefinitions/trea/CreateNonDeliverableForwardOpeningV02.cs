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
/// This record is an implementation of the trea.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateNonDeliverableForwardOpening message is sent by a participant to a central system or to a counterparty to notify the opening of a non deliverable trade.
/// Usage
/// The trading parties will send similar messages to the central settlement system and the central settlement system will send notifications to both parties.
/// </summary>
[Description(
    @"Scope|The CreateNonDeliverableForwardOpening message is sent by a participant to a central system or to a counterparty to notify the opening of a non deliverable trade.|Usage|The trading parties will send similar messages to the central settlement system and the central settlement system will send notifications to both parties."
)]
[IsoId("_OzAFVdE8Ed-BzquC8wXy7w_421836002")]
[DisplayName("Create Non Deliverable Forward Opening V")]
public record CreateNonDeliverableForwardOpeningV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.001.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretNDFOpngV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.001.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides identification and date of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_OzAFVtE8Ed-BzquC8wXy7w_579998049")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement1 TradeInformation { get; init; }

    /// <summary>
    /// Specifies the trading side of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_OzAFV9E8Ed-BzquC8wXy7w_1458268305")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification3 TradingSideIdentification { get; init; }

    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_OzAFWNE8Ed-BzquC8wXy7w_1612496357")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification3 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Specifies the amounts of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_OzAFWdE8Ed-BzquC8wXy7w_-659367564")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }

    /// <summary>
    /// Specifies the rate agreed at the opening of a non deliverable trade.
    /// </summary>
    [IsoId("_OzAFWtE8Ed-BzquC8wXy7w_497805144")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public required AgreedRate1 AgreedRate { get; init; }

    /// <summary>
    /// Specifies the valuation conditions of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_OzJ2UNE8Ed-BzquC8wXy7w_1979703277")]
    [DisplayName("Valuation Conditions")]
    [IsoXmlTag("ValtnConds")]
    public required NonDeliverableForwardValuationConditions2 ValuationConditions { get; init; }
}

// Since CreateNonDeliverableForwardOpeningV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreateNonDeliverableForwardOpeningV02.
