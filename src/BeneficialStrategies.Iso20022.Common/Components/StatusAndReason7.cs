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
[IsoId("_3LNtA-EAEd-udr336SN7mQ")]
[DisplayName("Status And Reason")]
public record StatusAndReason7
{
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_3LXdQeEAEd-udr336SN7mQ")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status2Choice_ StatusAndReason { get; init; }

    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_3LXdQ-EAEd-udr336SN7mQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction14> Transaction { get; init; } = [];
}
