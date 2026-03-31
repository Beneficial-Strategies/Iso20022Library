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
[IsoId("_6d7vcZNLEeWGlc8L7oPDIg")]
[DisplayName("Status And Reason")]
public record StatusAndReason29
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_6d7vdZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus62Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_6d7veZNLEeWGlc8L7oPDIg")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus32Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_6d7vfZNLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus32Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_6d7vgZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus22Choice_? SettlementStatus { get; init; }
}
