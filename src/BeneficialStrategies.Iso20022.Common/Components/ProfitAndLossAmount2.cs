// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Profit And Loss Amount2.
/// </summary>
[IsoId("_KhTLAYe5Ee-ZMOT1CLcLaw")]
[DisplayName("Profit And Loss Amount2")]
public partial record ProfitAndLossAmount2
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 

    /// <summary>
    /// Sign.
    /// </summary>
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    public IsoPlusOrMinusIndicator? Sign { get; init; } 

    
    #nullable disable
    
}
