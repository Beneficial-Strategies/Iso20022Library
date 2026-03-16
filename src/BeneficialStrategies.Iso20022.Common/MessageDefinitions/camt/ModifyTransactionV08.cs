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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.007.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ModifyTransaction message is sent by a member to the transaction administrator.
/// It is used to request one modification in one payment instruction held at the transaction administrator and sent by the member, debiting or crediting its account at the transaction administrator.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).
/// Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// For this reason, at any time during the operating hours of the system, the member can request modifications to the features of transient transactions.
/// The member will submit a message requesting modifications in one or more of the following criteria:
/// - instruction given, related to the processing of the transaction
/// - type of payment instructed
/// - priority of payment period in which the payment instruction should be processed (processing validity time)
/// The ModifyTransaction message will contain the new values that the member wants to see applied to the features of the transaction identified in the message.
/// Based on the criteria received within the ModifyTransaction message, the transaction administrator will execute or reject the requested modifications.
/// The transaction administrator may send a Receipt message as a reply to the ModifyTransaction request.
/// To verify the outcome of the request, the member may submit a GetTransaction message with the appropriate search criteria.
/// </summary>
[Description(
    @"Scope|The ModifyTransaction message is sent by a member to the transaction administrator.|It is used to request one modification in one payment instruction held at the transaction administrator and sent by the member, debiting or crediting its account at the transaction administrator.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).|Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|For this reason, at any time during the operating hours of the system, the member can request modifications to the features of transient transactions.|The member will submit a message requesting modifications in one or more of the following criteria:|- instruction given, related to the processing of the transaction|- type of payment instructed|- priority of payment period in which the payment instruction should be processed (processing validity time)|The ModifyTransaction message will contain the new values that the member wants to see applied to the features of the transaction identified in the message.|Based on the criteria received within the ModifyTransaction message, the transaction administrator will execute or reject the requested modifications.|The transaction administrator may send a Receipt message as a reply to the ModifyTransaction request.|To verify the outcome of the request, the member may submit a GetTransaction message with the appropriate search criteria."
)]
[IsoId("_jwlb6RbvEeiyVv5j1vf1VQ")]
[DisplayName("Modify Transaction V")]
public record ModifyTransactionV08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.007.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyTx";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.007.001.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlb6xbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; }

    /// <summary>
    /// Identifies the list of modifications to be executed.
    /// </summary>
    [IsoId("_jwlb7RbvEeiyVv5j1vf1VQ")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public required TransactionModification5 Modification { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb7xbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ModifyTransactionV08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ModifyTransactionV08.
