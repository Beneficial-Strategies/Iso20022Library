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
/// This record is an implementation of the acmt.030.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect.
/// </summary>
[Description(
    @"The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect."
)]
[IsoId("_KOlmz9cDEeq_l4BJLVUF2Q")]
[DisplayName("Account Switch Request Redirection V")]
public record AccountSwitchRequestRedirectionV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.030.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqRdrctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.030.001.03";

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
    [IsoId("_KOlm0dcDEeq_l4BJLVUF2Q")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_KOlm09cDEeq_l4BJLVUF2Q")]
    [DisplayName("Account Switch Details")]
    [IsoXmlTag("AcctSwtchDtls")]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }

    /// <summary>
    /// Account servicer holding the account to which the switch will be made for example the acquiring account servicer.
    /// </summary>
    [IsoId("_KOlm1dcDEeq_l4BJLVUF2Q")]
    [DisplayName("New Account")]
    [IsoXmlTag("NewAcct")]
    public required CashAccount41 NewAccount { get; init; }

    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_KOlm19cDEeq_l4BJLVUF2Q")]
    [DisplayName("Old Account")]
    [IsoXmlTag("OdAcct")]
    public required CashAccount41 OldAccount { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KOlm2dcDEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountSwitchRequestRedirectionV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchRequestRedirectionV03.
