// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details related to the undertaking.
/// </summary>
[IsoId("_VAaxMH7pEeGudZE4UaJCHQ")]
[DisplayName("Undertaking")]
public partial record Undertaking10
{
    #nullable enable
    
    /// <summary>
    /// Details related to the requested new amount for the counter-undertaking.
    /// </summary>
    [IsoId("_YWoEwH75EeGvEbxvurqpIg")]
    [DisplayName("New Undertaking Amount")]
    [IsoXmlTag("NewUdrtkgAmt")]
    public UndertakingAmount2? NewUndertakingAmount { get; init; } 
    
    /// <summary>
    /// Details related to the requested new expiry terms for the counter-undertaking.
    /// </summary>
    [IsoId("_vndG8H75EeGvEbxvurqpIg")]
    [DisplayName("New Expiry Details")]
    [IsoXmlTag("NewXpryDtls")]
    public ExpiryDetails1? NewExpiryDetails { get; init; } 
    
    
    #nullable disable
    
}
