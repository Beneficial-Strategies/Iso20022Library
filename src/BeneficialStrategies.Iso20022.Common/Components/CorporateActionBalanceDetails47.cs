// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Balance Details47.
/// </summary>
[IsoId("_v78-0KD4Ee-4O7NbwmwJkQ")]
[DisplayName("Corporate Action Balance Details47")]
public record CorporateActionBalanceDetails47
{
    /// <summary>
    /// Security Called Amount.
    /// </summary>
    [DisplayName("Security Called Amount")]
    [IsoXmlTag("SctyClldAmt")]
    public RestrictedFINImpliedCurrencyAndAmount? SecurityCalledAmount { get; init; }

    /// <summary>
    /// Total Amount Outstanding.
    /// </summary>
    [DisplayName("Total Amount Outstanding")]
    [IsoXmlTag("TtlAmtOutsdng")]
    public RestrictedFINImpliedCurrencyAndAmount? TotalAmountOutstanding { get; init; }
}
