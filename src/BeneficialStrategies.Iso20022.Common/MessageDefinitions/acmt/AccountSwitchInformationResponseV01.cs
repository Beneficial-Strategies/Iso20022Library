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
/// This record is an implementation of the acmt.028.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchInformationResponse message is sent by the account servicer that previously held the account to the new account servicer to signal whether the account owner&apos;s account can be switched and to pass details of payment arrangements to be transferred to the new account servicer if the account may be switched. Confirmation of the balance transfer window is permitted by the old account servicer.
/// </summary>
[Description(
    @"The AccountSwitchInformationResponse message is sent by the account servicer that previously held the account to the new account servicer to signal whether the account owner's account can be switched and to pass details of payment arrangements to be transferred to the new account servicer if the account may be switched. Confirmation of the balance transfer window is permitted by the old account servicer."
)]
[IsoId("_TP6gIUz6EeepdbMfWGyv3Q")]
[DisplayName("Account Switch Information Response V")]
public record AccountSwitchInformationResponseV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.028.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchInfRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.028.001.01";

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
    [IsoId("_YCeO0a5jEee17eDA_q0a9g")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_cj_SMa5jEee17eDA_q0a9g")]
    [DisplayName("Account Switch Details")]
    [IsoXmlTag("AcctSwtchDtls")]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }

    /// <summary>
    /// New account to which the switch will be made (destination account).
    /// </summary>
    [IsoId("_TP6gJUz6EeepdbMfWGyv3Q")]
    [DisplayName("New Account")]
    [IsoXmlTag("NewAcct")]
    public required CashAccount36 NewAccount { get; init; }

    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_TP6gJ0z6EeepdbMfWGyv3Q")]
    [DisplayName("Old Account")]
    [IsoXmlTag("OdAcct")]
    public required CashAccount36 OldAccount { get; init; }

    /// <summary>
    /// Details of debit payment arrangements associated with the old account. For example the payment may be a standing order, a bill payment arrangement or a future dated payment.
    /// </summary>
    [IsoId("_w07UgFDcEeeunetnjWUhcA")]
    [DisplayName("Payment Instruction")]
    [IsoXmlTag("PmtInstr")]
    public PaymentInstruction24? PaymentInstruction { get; init; }

    /// <summary>
    /// Details of a direct debit instruction associated with the old account.
    /// </summary>
    [IsoId("_qIn1MFy8Eee48PRwcRxS4A")]
    [DisplayName("Direct Debit Instruction")]
    [IsoXmlTag("DrctDbtInstr")]
    public DirectDebitInstructionDetails1? DirectDebitInstruction { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_TP6gLUz6EeepdbMfWGyv3Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountSwitchInformationResponseV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchInformationResponseV01.
