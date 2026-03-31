// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numerical representation of the net increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
/// </summary>
[IsoId("_S3i5sAEcEeCQm6a_G2yO_w_756219526")]
[DisplayName("Balance Status")]
public record BalanceStatus2
{
    /// <summary>
    /// Balance in each currency calculated at the value date and time indicated in the report.
    /// </summary>
    [IsoId("_S3i5sQEcEeCQm6a_G2yO_w_642380460")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public required ActiveCurrencyAndAmount Balance { get; init; }
}
