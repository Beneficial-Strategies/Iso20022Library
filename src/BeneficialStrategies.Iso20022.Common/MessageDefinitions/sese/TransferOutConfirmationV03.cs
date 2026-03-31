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
/// This record is an implementation of the sese.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the TransferOutConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to confirm the delivery of a financial instrument, free of payment, on a given date, to a specified party.
/// This message may also be used to confirm the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.
/// Usage
/// The TransferOutConfirmation message is used to confirm the withdrawal of a financial instrument from the owner&apos;s account and its delivery to another own account, or to a third party, has taken place.
/// The reference of the transfer confirmation is identified in TransferConfirmationReference. The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferOutInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the TransferOutConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to confirm the delivery of a financial instrument, free of payment, on a given date, to a specified party.|This message may also be used to confirm the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.|Usage|The TransferOutConfirmation message is used to confirm the withdrawal of a financial instrument from the owner's account and its delivery to another own account, or to a third party, has taken place.|The reference of the transfer confirmation is identified in TransferConfirmationReference. The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferOutInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference."
)]
[IsoId("_xs8JofpbEeCPwaG9zjUPNQ")]
[DisplayName("Transfer Out Confirmation V")]
public record TransferOutConfirmationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.003.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.003.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_xs8JpfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_C2IYcENIEeGHJ_bHJRPaIQ_-2011216296")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("_FGX8wENIEeGHJ_bHJRPaIQ_323176613")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_FGX8wUNIEeGHJ_bHJRPaIQ_-1982769902")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_FGX8wkNIEeGHJ_bHJRPaIQ_-790910498")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_xs8JtfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer13 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    [IsoId("_xs8JvfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount22 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_xs8JwfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required ReceiveInformation6 SettlementDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_xs8JxfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_xs8JyfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferOutConfirmationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferOutConfirmationV03.
