// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the transactions in the report.
/// </summary>
[IsoId("_YdjDoeSkEe-qVZLXW4RRBw")]
[DisplayName("Intra Position Pending11")]
public record IntraPositionPending11
{
    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_YqmBI-SkEe-qVZLXW4RRBw")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public PendingStatusAndReason4? StatusAndReason { get; init; }

    /// <summary>
    /// Identifies the individual transaction.
    /// </summary>
    [IsoId("_YqmBJeSkEe-qVZLXW4RRBw")]
    [DisplayName("Movement")]
    [IsoXmlTag("Mvmnt")]
    [MinLength(1)]
    public ValueList<IntraPositionPending12> Movement { get; init; } = [];
}
