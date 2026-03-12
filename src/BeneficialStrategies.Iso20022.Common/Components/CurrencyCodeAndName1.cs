// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a currency by its code or its name.
/// </summary>
[IsoId("_cIJQQMOVEeWiEtRBUJSIaA")]
[DisplayName("Currency Code And Name")]
public partial record CurrencyCodeAndName1
{
    #nullable enable
    
    /// <summary>
    /// Currency is specified by its code.
    /// </summary>
    [IsoId("_mbXMgMOVEeWiEtRBUJSIaA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ActiveOrHistoricCurrencyCode Code { get; init; } 
    
    /// <summary>
    /// Currency is specified by its name.
    /// </summary>
    [IsoId("_rJgWoMOVEeWiEtRBUJSIaA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; } 
    
    
    #nullable disable
    
}
