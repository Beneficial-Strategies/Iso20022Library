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
[IsoId("_UU5hsNp-Ed-ak6NoX_4Aeg_-1534924185")]
[DisplayName("Status And Reason")]
public record StatusAndReason1
{
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_UU5hsdp-Ed-ak6NoX_4Aeg_-239125413")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status2Choice_ StatusAndReason { get; init; }

    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_UU5hstp-Ed-ak6NoX_4Aeg_1247064422")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction7> Transaction { get; init; } = [];
}
