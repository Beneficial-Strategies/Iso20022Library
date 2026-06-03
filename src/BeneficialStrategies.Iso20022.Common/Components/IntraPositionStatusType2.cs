// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of the intra-position movement status type.
/// </summary>
[IsoId("_ceohpeWXEeWvh8HbDeFFMA")]
[DisplayName("Intra Position Status Type2")]
public record IntraPositionStatusType2
{
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_cqsAoeWXEeWvh8HbDeFFMA")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ProcessingStatus68Choice_> ProcessingStatus { get; init; } = [];

    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_cqsAo-WXEeWvh8HbDeFFMA")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public ValueList<SettlementStatus26Choice_> SettlementStatus { get; init; } = [];

    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_cqsApeWXEeWvh8HbDeFFMA")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; }
}
