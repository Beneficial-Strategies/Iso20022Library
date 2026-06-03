// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of the intra-balance movement status type.
/// </summary>
[IsoId("_YqmoMeSkEe-qVZLXW4RRBw")]
[DisplayName("Pending Status And Reason4")]
public record PendingStatusAndReason4
{
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_Y5xsoeSkEe-qVZLXW4RRBw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ProcessingStatus100Choice> ProcessingStatus { get; init; } = [];

    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_Y5xso-SkEe-qVZLXW4RRBw")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public ValueList<SettlementStatus34Choice> SettlementStatus { get; init; } = [];
}
