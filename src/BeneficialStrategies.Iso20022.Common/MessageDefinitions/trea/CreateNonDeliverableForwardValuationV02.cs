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
/// This record is an implementation of the trea.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the valuation of a non deliverable trade.
/// Usage
/// The two trading parties will both send similar notifications to the central settlement system and the central settlement system will send notifications to both.
/// </summary>
[Description(
    @"Scope|The CreateNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the valuation of a non deliverable trade.|Usage|The two trading parties will both send similar notifications to the central settlement system and the central settlement system will send notifications to both."
)]
[IsoId("_PNYUONE8Ed-BzquC8wXy7w_1806193871")]
[DisplayName("Create Non Deliverable Forward Valuation V")]
public record CreateNonDeliverableForwardValuationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.004.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretNDFValtnV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.004.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides identification and date of the valuation of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_PNYUOdE8Ed-BzquC8wXy7w_1867450436")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement1 TradeInformation { get; init; }

    /// <summary>
    /// Specifies the trading side of the valuation of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_PNYUOtE8Ed-BzquC8wXy7w_1743430709")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification3 TradingSideIdentification { get; init; }

    /// <summary>
    /// Specifies the counterparty of the valuation of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_PNYUO9E8Ed-BzquC8wXy7w_2094371836")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification3 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Specifies the amounts of the valuation of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_PNheINE8Ed-BzquC8wXy7w_1514664860")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }

    /// <summary>
    /// Specifies the valuation information of the valuation of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_PNheIdE8Ed-BzquC8wXy7w_1542371945")]
    [DisplayName("Valuation Information")]
    [IsoXmlTag("ValtnInf")]
    public required ValuationData2 ValuationInformation { get; init; }

    /// <summary>
    /// Specifies the valuation rate of the valuation of the non deliverable trade which is created.
    /// </summary>
    [IsoId("_PNheItE8Ed-BzquC8wXy7w_1810190650")]
    [DisplayName("Valuation Rate")]
    [IsoXmlTag("ValtnRate")]
    public required AgreedRate1 ValuationRate { get; init; }
}

// Since CreateNonDeliverableForwardValuationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreateNonDeliverableForwardValuationV02.
