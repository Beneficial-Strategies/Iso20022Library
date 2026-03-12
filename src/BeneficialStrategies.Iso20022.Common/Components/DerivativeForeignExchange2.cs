// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of non-financial instrument of type foreign exchange as underlying.
/// </summary>
[IsoId("_AkuzscnZEeWpf-ImB_F2gQ")]
[DisplayName("Derivative Foreign Exchange")]
public partial record DerivativeForeignExchange2
{
    #nullable enable
    
    /// <summary>
    /// Underlying currency 2 of the currency pair (the currency 1 will be populated in the notional currency).
    /// </summary>
    [IsoId("_BDX3g8nZEeWpf-ImB_F2gQ")]
    [DisplayName("Other Notional Currency")]
    [IsoXmlTag("OthrNtnlCcy")]
    public required ActiveOrHistoricCurrencyCode OtherNotionalCurrency { get; init; } 
    
    
    #nullable disable
    
}
