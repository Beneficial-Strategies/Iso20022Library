// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Conversion30.
/// </summary>
[IsoId("_BICSkZFFEe6reqfAp4CunQ")]
[DisplayName("Currency Conversion30")]
public partial record CurrencyConversion30
{
    #nullable enable

    /// <summary>
    /// Accepted By Cardholder.
    /// </summary>
    [DisplayName("Accepted By Cardholder")]
    [IsoXmlTag("AccptdByCrdhldr")]
    public IsoTrueFalseIndicator? AcceptedByCardholder { get; init; } 

    /// <summary>
    /// Conversion.
    /// </summary>
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public CurrencyConversion29? Conversion { get; init; } 

    
    #nullable disable
    
}
