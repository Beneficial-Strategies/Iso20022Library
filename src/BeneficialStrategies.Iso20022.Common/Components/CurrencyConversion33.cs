// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Conversion33.
/// </summary>
[IsoId("_IWRjgZ-XEe-nbM0aSPcoiQ")]
[DisplayName("Currency Conversion33")]
public partial record CurrencyConversion33
{
    #nullable enable

    /// <summary>
    /// Conversion.
    /// </summary>
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public CurrencyConversion32? Conversion { get; init; } 

    /// <summary>
    /// Result.
    /// </summary>
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required CurrencyConversionResponse2Code Result { get; init; } 

    /// <summary>
    /// Result Reason.
    /// </summary>
    [DisplayName("Result Reason")]
    [IsoXmlTag("RsltRsn")]
    public IsoMax35Text? ResultReason { get; init; } 

    
    #nullable disable
    
}
