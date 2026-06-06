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
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_YHDyQeFWEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ProcessingStatus70Choice_> ProcessingStatus { get; init; } = [];

    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_YHDyQ-FWEeWIA4E9cYSxxQ")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public ValueList<MatchingStatus27Choice_> InferredMatchingStatus { get; init; } = [];

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_YHDyReFWEeWIA4E9cYSxxQ")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public ValueList<MatchingStatus27Choice_> MatchingStatus { get; init; } = [];

    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_YHDyR-FWEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public ValueList<SettlementStatus26Choice_> SettlementStatus { get; init; } = [];

    /// <summary>
    /// Defines that the transaction has been settled.
    /// </summary>
    [IsoId("_YHDySeFWEeWIA4E9cYSxxQ")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; }
}
