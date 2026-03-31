// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement totals or the report.
/// </summary>
[IsoId("_jWGXwFdGEeeIAMBcVOw01w")]
[DisplayName("Settlement Totals")]
public record SettlementTotals1
{
    /// <summary>
    /// Settlement totals for the acquirer.
    /// </summary>
    [IsoId("_ukPEIFdGEeeIAMBcVOw01w")]
    [DisplayName("Acquirer Totals")]
    [IsoXmlTag("AcqrrTtls")]
    public SettlementCategoryTotal1? AcquirerTotals { get; init; }

    /// <summary>
    /// Settlement totals for the issuer.
    /// </summary>
    [IsoId("_28ZB4FdGEeeIAMBcVOw01w")]
    [DisplayName("Issuer Totals")]
    [IsoXmlTag("IssrTtls")]
    public SettlementCategoryTotal1? IssuerTotals { get; init; }

    /// <summary>
    /// Other settlement totals.
    /// </summary>
    [IsoId("_8iNa4FdGEeeIAMBcVOw01w")]
    [DisplayName("Other Totals")]
    [IsoXmlTag("OthrTtls")]
    public SettlementCategoryTotal1? OtherTotals { get; init; }

    /// <summary>
    /// Total amount settled.
    /// </summary>
    [IsoId("_2zMkYNvyEeeOusYHZbyj7w")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public SettlementCategoryTotal1? TotalSettlementAmount { get; init; }
}
