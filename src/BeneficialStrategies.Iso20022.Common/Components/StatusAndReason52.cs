// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of status.
/// </summary>
[IsoId("_8-dsEQNrEfG_3cM8uyJ20w")]
[DisplayName("Status And Reason52")]
public record StatusAndReason52
{
    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_9BRvhQNrEfG_3cM8uyJ20w")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus24Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_9BRvjQNrEfG_3cM8uyJ20w")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus24Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_9BRvlQNrEfG_3cM8uyJ20w")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus32Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_9BRvnQNrEfG_3cM8uyJ20w")]
    [DisplayName("Instruction Processing Status")]
    [IsoXmlTag("InstrPrcgSts")]
    public InstructionProcessingStatus63Choice_? InstructionProcessingStatus { get; init; }

    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_9BSWlQNrEfG_3cM8uyJ20w")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; }

    /// <summary>
    /// Proprietary status.
    /// </summary>
    [IsoId("_9BSWlwNrEfG_3cM8uyJ20w")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryStatusAndReason6? Proprietary { get; init; }
}
