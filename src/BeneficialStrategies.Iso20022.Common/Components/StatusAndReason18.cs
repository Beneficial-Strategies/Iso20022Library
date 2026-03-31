// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
[IsoId("_Dl-9wSRhEeO8sskhVI3IDA")]
[DisplayName("Status And Reason")]
public record StatusAndReason18
{
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_D9pPwyRhEeO8sskhVI3IDA")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status15Choice_ StatusAndReason { get; init; }

    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_D9pPyyRhEeO8sskhVI3IDA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction35> Transaction { get; init; } = [];
}
