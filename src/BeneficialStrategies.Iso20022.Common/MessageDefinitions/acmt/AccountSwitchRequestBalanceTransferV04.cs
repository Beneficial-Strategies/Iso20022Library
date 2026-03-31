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
/// This record is an implementation of the acmt.031.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchRequestBalanceTransfer message is sent by the new account servicer to the account servicer which previously held the account to request the transfer of the closing balance. This may be addressed to the new account or an alternate account nominated by the new account servicer.
/// </summary>
[Description(
    @"The AccountSwitchRequestBalanceTransfer message is sent by the new account servicer to the account servicer which previously held the account to request the transfer of the closing balance. This may be addressed to the new account or an alternate account nominated by the new account servicer. "
)]
[IsoId("_KOlm29cDEeq_l4BJLVUF2Q")]
[DisplayName("Account Switch Request Balance Transfer V")]
public record AccountSwitchRequestBalanceTransferV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.031.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqBalTrf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.031.001.04";

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
    [IsoId("_KOlm3dcDEeq_l4BJLVUF2Q")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_KOlm39cDEeq_l4BJLVUF2Q")]
    [DisplayName("Account Switch Details")]
    [IsoXmlTag("AcctSwtchDtls")]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }

    /// <summary>
    /// Details of the new account set up with the new account servicer.
    /// Usage: If an Alternate Credit Account is not specified and the closing balance of the old account was positive then the payment of the outstanding balance should be made to this account.
    /// </summary>
    [IsoId("_KOlm4dcDEeq_l4BJLVUF2Q")]
    [DisplayName("New Account")]
    [IsoXmlTag("NewAcct")]
    public required CashAccount41 NewAccount { get; init; }

    /// <summary>
    /// Alternate beneficiary account for a payment made from the old account servicer to the new account servicer in the case of a positive closing balance of the old bank.
    /// </summary>
    [IsoId("_KOlm49cDEeq_l4BJLVUF2Q")]
    [DisplayName("Nominated Account")]
    [IsoXmlTag("NmntdAcct")]
    public CashAccount41? NominatedAccount { get; init; }

    /// <summary>
    /// Information that enables the receiving bank to reconcile the payment with the request.
    /// </summary>
    [IsoId("_KOlm5dcDEeq_l4BJLVUF2Q")]
    [DisplayName("Balance Transfer")]
    [IsoXmlTag("BalTrf")]
    public BalanceTransfer4? BalanceTransfer { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KOlm59cDEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since AccountSwitchRequestBalanceTransferV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchRequestBalanceTransferV04.
