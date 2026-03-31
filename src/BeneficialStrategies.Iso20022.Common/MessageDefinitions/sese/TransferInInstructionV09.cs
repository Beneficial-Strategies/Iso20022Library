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
/// This record is an implementation of the sese.005.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The TransferInInstruction message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct the receipt of a financial instrument, free of payment, on a given date from a specified party.
/// This message may also be used to instruct the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.
/// Usage
/// The TransferInInstruction message is used to instruct the receipt of a financial instrument from another account, either owned by the instructing party or by a third party.
/// </summary>
[Description(
    @"The TransferInInstruction message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct the receipt of a financial instrument, free of payment, on a given date from a specified party.|This message may also be used to instruct the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.|Usage|The TransferInInstruction message is used to instruct the receipt of a financial instrument from another account, either owned by the instructing party or by a third party."
)]
[IsoId("_VueWUZDhEem7fvtoGpNpow")]
[DisplayName("Transfer In Instruction V")]
public record TransferInInstructionV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.005.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.005.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_VueWVZDhEem7fvtoGpNpow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_VueWV5DhEem7fvtoGpNpow")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference11? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_VueWWZDhEem7fvtoGpNpow")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_VueWW5DhEem7fvtoGpNpow")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }

    /// <summary>
    /// Function of the transfer in, that is, whether the transfer in message is used as an instruction or an advice and request for information. The absence of Function indicates the message is an instruction.
    /// </summary>
    [IsoId("_VueWXZDhEem7fvtoGpNpow")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public TransferInFunction1Code? Function { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_VueWX5DhEem7fvtoGpNpow")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// General information related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_VueWYZDhEem7fvtoGpNpow")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer36 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    [IsoId("_VueWY5DhEem7fvtoGpNpow")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount71 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_VueWZZDhEem7fvtoGpNpow")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public DeliverInformation21? SettlementDetails { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_VueWZ5DhEem7fvtoGpNpow")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_VueWaZDhEem7fvtoGpNpow")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation5? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_VueWa5DhEem7fvtoGpNpow")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferInInstructionV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInInstructionV09.
