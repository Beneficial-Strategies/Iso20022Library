// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Conversion33.
/// </summary>
[IsoId("_IWRjgZ-XEe-nbM0aSPcoiQ")]
[DisplayName("Currency Conversion33")]
public record CurrencyConversion33
{
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
}
