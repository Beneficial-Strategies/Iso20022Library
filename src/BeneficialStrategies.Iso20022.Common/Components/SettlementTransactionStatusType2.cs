// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of the securities settlement instruction status type.
/// </summary>
[IsoId("_X9rz1eFWEeWIA4E9cYSxxQ")]
[DisplayName("Settlement Transaction Status Type2")]
public record SettlementTransactionStatusType2
{
    [IsoId("_YHDyQeFWEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ProcessingStatus70Choice> ProcessingStatus { get; init; } = [];

    [IsoId("_YHDyQ-FWEeWIA4E9cYSxxQ")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public ValueList<MatchingStatus27Choice> InferredMatchingStatus { get; init; } = [];

    [IsoId("_YHDyReFWEeWIA4E9cYSxxQ")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public ValueList<MatchingStatus27Choice> MatchingStatus { get; init; } = [];

    [IsoId("_YHDyR-FWEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public ValueList<SettlementStatus26Choice> SettlementStatus { get; init; } = [];

    [IsoId("_YHDySeFWEeWIA4E9cYSxxQ")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; }
}
