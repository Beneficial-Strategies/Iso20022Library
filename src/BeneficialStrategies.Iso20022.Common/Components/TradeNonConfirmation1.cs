// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies contract that is not confirmed.
/// </summary>
[IsoId("_8sHJ5A27EeWmAKKPnqYEVQ")]
[DisplayName("Trade Non Confirmation")]
public partial record TradeNonConfirmation1
{
    #nullable enable
    
    /// <summary>
    /// Specifies that the contract remains unconfirmed.
    /// </summary>
    [IsoId("_8sHJ5w27EeWmAKKPnqYEVQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TradeConfirmationType2Code Type { get; init; } 
    
    
    #nullable disable
    
}
