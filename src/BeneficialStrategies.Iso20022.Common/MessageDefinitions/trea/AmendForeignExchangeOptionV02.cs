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
/// This record is an implementation of the trea.010.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the amendment of a foreign currency option contract.
/// Usage
/// The message contains a Related Reference to link it to the previously sent notification and may contain an reason for amendment.
/// This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.
/// </summary>
[Description(
    @"Scope|The AmendForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the amendment of a foreign currency option contract.|Usage|The message contains a Related Reference to link it to the previously sent notification and may contain an reason for amendment.|This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options."
)]
[IsoId("_HQD4WNE8Ed-BzquC8wXy7w_-1614590929")]
[DisplayName("Amend Foreign Exchange Option V")]
public record AmendForeignExchangeOptionV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.010.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdFXOptnV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.010.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides reference and date of the foreign exchange option trade which is amended.
    /// </summary>
    [IsoId("_HQD4WdE8Ed-BzquC8wXy7w_-277529666")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement2 TradeInformation { get; init; }

    /// <summary>
    /// Specifies the trading side of the currency option trade which is amended.
    /// </summary>
    [IsoId("_HQD4WtE8Ed-BzquC8wXy7w_-515469288")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification4 TradingSideIdentification { get; init; }

    /// <summary>
    /// Specifies the counterparty of the currency option trade which is amended.
    /// </summary>
    [IsoId("_HQD4W9E8Ed-BzquC8wXy7w_296306803")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification4 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Specifies the parameters of the currency option which is bought by the trading side.
    /// </summary>
    [IsoId("_HQNCQNE8Ed-BzquC8wXy7w_1463318138")]
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public required Option3 Option { get; init; }
}

// Since AmendForeignExchangeOptionV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendForeignExchangeOptionV02.
