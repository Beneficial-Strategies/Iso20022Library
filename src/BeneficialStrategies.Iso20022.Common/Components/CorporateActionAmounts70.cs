// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Amounts70.
/// </summary>
[IsoId("_AERn0EnGEe-NocYul3BKXQ")]
[DisplayName("Corporate Action Amounts70")]
public record CorporateActionAmounts70
{
    /// <summary>
    /// Non Refunded Amount.
    /// </summary>
    [DisplayName("Non Refunded Amount")]
    [IsoXmlTag("NonRfnddAmt")]
    public RestrictedFINImpliedCurrencyAndAmount? NonRefundedAmount { get; init; }

    /// <summary>
    /// Refunded Amount.
    /// </summary>
    [DisplayName("Refunded Amount")]
    [IsoXmlTag("RfnddAmt")]
    public RestrictedFINImpliedCurrencyAndAmount? RefundedAmount { get; init; }
}
