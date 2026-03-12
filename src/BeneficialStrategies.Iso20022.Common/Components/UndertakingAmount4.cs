// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defined variation amount and balance.
/// </summary>
[IsoId("_945Ng3ltEeG7BsjMvd1mEw_1350790559")]
[DisplayName("Undertaking Amount")]
public partial record UndertakingAmount4
{
    #nullable enable
    
    /// <summary>
    /// Variation amount and currency.
    /// </summary>
    [IsoId("_945NhHltEeG7BsjMvd1mEw_1236951493")]
    [DisplayName("Variation Amount")]
    [IsoXmlTag("VartnAmt")]
    public required ActiveCurrencyAndAmount VariationAmount { get; init; } 
    
    /// <summary>
    /// Calculated undertaking available balance amount resulting from the application of the variation amount.
    /// </summary>
    [IsoId("_95C-gHltEeG7BsjMvd1mEw_1336485232")]
    [DisplayName("Balance Amount")]
    [IsoXmlTag("BalAmt")]
    public ActiveCurrencyAndAmount? BalanceAmount { get; init; } 
    
    
    #nullable disable
    
}
