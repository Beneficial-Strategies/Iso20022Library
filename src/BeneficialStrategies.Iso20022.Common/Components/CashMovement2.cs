// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash movement.
/// </summary>
[IsoId("_UJIWkNp-Ed-ak6NoX_4Aeg_908062376")]
[DisplayName("Cash Movement")]
public record CashMovement2
{
    /// <summary>
    /// Cash amount.
    /// </summary>
    [IsoId("_UJIWkdp-Ed-ak6NoX_4Aeg_1564685216")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    [IsoId("_UJIWktp-Ed-ak6NoX_4Aeg_1455708824")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CashAccount19> AccountDetails { get; init; } = [];
}
