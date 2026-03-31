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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.021.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesTransactionStatusQuery to an account servicer to request a status on a securities transaction.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manage a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct to a central securities depository or another settlement market infrastructure.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
///
/// </summary>
[Description(
    @"Scope|An account owner sends a SecuritiesTransactionStatusQuery to an account servicer to request a status on a securities transaction.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct to a central securities depository or another settlement market infrastructure.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.|"
)]
[IsoId("_pluB4SgSEeym1_Zp1BTvEw")]
[DisplayName("Securities Transaction Status Query V")]
public record SecuritiesTransactionStatusQueryV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.021.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxStsQry";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.021.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Description of the status advice requested.
    /// </summary>
    [IsoId("_pluB5ygSEeym1_Zp1BTvEw")]
    [DisplayName("Status Advice Requested")]
    [IsoXmlTag("StsAdvcReqd")]
    public required DocumentNumber18 StatusAdviceRequested { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_pluB6SgSEeym1_Zp1BTvEw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_pluB6ygSEeym1_Zp1BTvEw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount22? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_sw1oIyqFEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_pluB7SgSEeym1_Zp1BTvEw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesTransactionStatusQueryV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTransactionStatusQueryV06.
