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
[IsoId("9242905c-7475-4b1c-8c93-796ba22731b4")]
[DisplayName("Status And Reason50")]
public record StatusAndReason50
{
    [IsoId("b3db753e-c8c5-4b77-805d-c58027430885")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus104Choice_? ProcessingStatus { get; init; }

    [IsoId("d3a15f13-237c-4a63-bfc3-f20b1d6de99c")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus24Choice_? InferredMatchingStatus { get; init; }

    [IsoId("5379570e-ab0d-48c9-9de1-ca80a755df94")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus24Choice_? MatchingStatus { get; init; }

    [IsoId("0abb2dd5-4608-4400-9ce3-89f8889fd048")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus32Choice_? SettlementStatus { get; init; }
}
