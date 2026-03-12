// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount to be authorised by the issuer.
/// </summary>
[IsoId("_nuIgAIolEeSaAcF2oE2GNQ")]
[DisplayName("Amount And Currency")]
public partial record AmountAndCurrency1
{
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_0LTLUIolEeSaAcF2oE2GNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_4QPncIolEeSaAcF2oE2GNQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    
    #nullable disable
    
}
