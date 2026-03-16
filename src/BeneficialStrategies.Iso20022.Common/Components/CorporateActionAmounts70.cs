// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Amounts70.
/// </summary>
[IsoId("_AERn0EnGEe-NocYul3BKXQ")]
[DisplayName("Corporate Action Amounts70")]
public partial record CorporateActionAmounts70
{
    #nullable enable

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

    
    #nullable disable
    
}
