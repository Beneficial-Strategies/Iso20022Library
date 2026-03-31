// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status And Reason48.
/// </summary>
[IsoId("_x9e7cYcSEe-U27oWwgmhCQ")]
[DisplayName("Status And Reason48")]
public record StatusAndReason48
{
    /// <summary>
    /// Inferred Matching Status.
    /// </summary>
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus24Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Matching Status.
    /// </summary>
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus24Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus52Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Settlement Status.
    /// </summary>
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus32Choice_? SettlementStatus { get; init; }
}
