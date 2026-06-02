// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account balances shared with issuer agent.
/// </summary>
[IsoId("_gC4scaNWEfC9id413JK-Ig")]
[DisplayName("Corporate Action Balance Details48")]
public record CorporateActionBalanceDetails48
{
    /// <summary>
    /// Total called amount of the security that has been called for redemption on a specific payable date.
    /// </summary>
    [IsoId("_gK1ukaNWEfC9id413JK-Ig")]
    [DisplayName("Security Called Amount")]
    [IsoXmlTag("SctyClldAmt")]
    public RestrictedFINImpliedCurrencyAndAmount? SecurityCalledAmount { get; init; }

    /// <summary>
    /// Total amount outstanding for the underlying security.
    /// </summary>
    [IsoId("_gK1uk6NWEfC9id413JK-Ig")]
    [DisplayName("Total Amount Outstanding")]
    [IsoXmlTag("TtlAmtOutsdng")]
    public RestrictedFINImpliedCurrencyAndAmount? TotalAmountOutstanding { get; init; }
}
