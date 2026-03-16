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
/// This record is an implementation of the acmt.034.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchRequestPayment message is sent by the old account servicer to the new account servicer after the completion of the account switch to request the transfer of funds for a payment that the previous account servicer has had to make from the old account (for example: the settlement of a card transaction that was authorised offline).
/// </summary>
[Description(
    @"The AccountSwitchRequestPayment message is sent by the old account servicer to the new account servicer after the completion of the account switch to request the transfer of funds for a payment that the previous account servicer has had to make from the old account (for example: the settlement of a card transaction that was authorised offline)."
)]
[IsoId("_Lv10x8P_Eemsic1bQcEtLA")]
[DisplayName("Account Switch Request Payment V")]
public record AccountSwitchRequestPaymentV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.034.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqPmt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.034.001.03";

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
    [IsoId("_Lv10ycP_Eemsic1bQcEtLA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Contains information about the details of the account switch and a response code to the original payment request.
    /// </summary>
    [IsoId("_Lv10y8P_Eemsic1bQcEtLA")]
    [DisplayName("Account Switch Details")]
    [IsoXmlTag("AcctSwtchDtls")]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }

    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_Lv10zcP_Eemsic1bQcEtLA")]
    [DisplayName("Old Account")]
    [IsoXmlTag("OdAcct")]
    public required CashAccount39 OldAccount { get; init; }

    /// <summary>
    /// Specific information relating to a request for payment, including details that enable the receiving account servicer to reconcile the payment to be received with the original payment request.
    /// </summary>
    [IsoId("_Lv10z8P_Eemsic1bQcEtLA")]
    [DisplayName("Credit Instruction")]
    [IsoXmlTag("CdtInstr")]
    public required CreditTransferTransaction41 CreditInstruction { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Lv100cP_Eemsic1bQcEtLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountSwitchRequestPaymentV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchRequestPaymentV03.
