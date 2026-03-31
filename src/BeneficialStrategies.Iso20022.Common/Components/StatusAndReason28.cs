// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of a transaction.
/// </summary>
[IsoId("_kYkAjTnvEeWfSKvvZlhRKg")]
[DisplayName("Status And Reason")]
public record StatusAndReason28
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_k4_M8znvEeWfSKvvZlhRKg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus52Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_k4_M9znvEeWfSKvvZlhRKg")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus24Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_k4_M-znvEeWfSKvvZlhRKg")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus24Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_k4_M_znvEeWfSKvvZlhRKg")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus17Choice_? SettlementStatus { get; init; }
}
