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
[IsoId("_8VHUH5NLEeWGlc8L7oPDIg")]
[DisplayName("Status And Reason")]
public record StatusAndReason30
{
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_8VHUIZNLEeWGlc8L7oPDIg")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status23Choice_ StatusAndReason { get; init; }

    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_8VHUJZNLEeWGlc8L7oPDIg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction48> Transaction { get; init; } = [];
}
