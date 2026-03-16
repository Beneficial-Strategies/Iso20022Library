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

namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.027.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchInformationRequest message is sent by the new account servicer to the account servicer which previously held the account to initiate the account switch process. It provides information sufficient for the old account servicer to identify the old account and validate the account parties. The new account servicer is able to inform the old bank of the maximum funding the new account will provide to settle a negative closing balance and the proposed balance transfer window.
/// </summary>
[Description(
    @"The AccountSwitchInformationRequest message is sent by the new account servicer to the account servicer which previously held the account to initiate the account switch process. It provides information sufficient for the old account servicer to identify the old account and validate the account parties. The new account servicer is able to inform the old bank of the maximum funding the new account will provide to settle a negative closing balance and the proposed balance transfer window."
)]
[IsoId("_7HK1jW42EeiU9cctagi5ow")]
[DisplayName("Account Switch Information Request V")]
public record AccountSwitchInformationRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.027.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchInfReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.027.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HK1j242EeiU9cctagi5ow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_7HK1kW42EeiU9cctagi5ow")]
    [DisplayName("Account Switch Details")]
    [IsoXmlTag("AcctSwtchDtls")]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }

    /// <summary>
    /// Account servicer holding the account to which the switch will be made. That is, the acquiring account servicer.
    /// </summary>
    [IsoId("_7HK1k242EeiU9cctagi5ow")]
    [DisplayName("New Account")]
    [IsoXmlTag("NewAcct")]
    public required NewAccount2 NewAccount { get; init; }

    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_7HK1lW42EeiU9cctagi5ow")]
    [DisplayName("Old Account")]
    [IsoXmlTag("OdAcct")]
    public required CashAccount39 OldAccount { get; init; }

    /// <summary>
    /// Information that enables the receiving account servicer to reconcile the payment with the request.
    /// </summary>
    [IsoId("_7HK1l242EeiU9cctagi5ow")]
    [DisplayName("Balance Transfer")]
    [IsoXmlTag("BalTrf")]
    public BalanceTransfer2? BalanceTransfer { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HK1mW42EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountSwitchInformationRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchInformationRequestV02.
