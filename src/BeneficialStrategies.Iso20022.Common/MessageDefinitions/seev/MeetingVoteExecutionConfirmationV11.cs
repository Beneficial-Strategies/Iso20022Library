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

namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.007.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_UbvJCX_5Ee-h086v0qPiyQ")]
[DisplayName("Meeting Vote Execution Confirmation V11")]
public record MeetingVoteExecutionConfirmationV11 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.11";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.11";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Meeting Instruction Identification.
    /// </summary>
    [DisplayName("Meeting Instruction Identification")]
    [IsoXmlTag("MtgInstrId")]
    public required IsoMax35Text MeetingInstructionIdentification { get; init; }

    /// <summary>
    /// Meeting Reference.
    /// </summary>
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; }

    /// <summary>
    /// Pagination.
    /// </summary>
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Vote Execution Confirmation Identification.
    /// </summary>
    [DisplayName("Vote Execution Confirmation Identification")]
    [IsoXmlTag("VoteExctnConfId")]
    public IsoMax35Text? VoteExecutionConfirmationIdentification { get; init; }

    /// <summary>
    /// Vote Instructions.
    /// </summary>
    [DisplayName("Vote Instructions")]
    [IsoXmlTag("VoteInstrs")]
    public ValueList<DetailedInstructionStatus19> VoteInstructions { get; init; } = [];

    /// <summary>
    /// Vote Instructions Confirmation URL Address.
    /// </summary>
    [DisplayName("Vote Instructions Confirmation URL Address")]
    [IsoXmlTag("VoteInstrsConfURLAdr")]
    public IsoMax2048Text? VoteInstructionsConfirmationURLAddress { get; init; }
}

// Since MeetingVoteExecutionConfirmationV11Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingVoteExecutionConfirmationV11.
