// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a model form.
/// </summary>
[IsoId("_94mSlXltEeG7BsjMvd1mEw_-921216115")]
[DisplayName("Model Form Identification")]
public record ModelFormIdentification1
{
    /// <summary>
    /// Identification of the model form.
    /// </summary>
    [IsoId("_94wDkHltEeG7BsjMvd1mEw_-1915765475")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required ModelFormIdentification1Choice_ Identification { get; init; }

    /// <summary>
    /// Version of the model form.
    /// </summary>
    [IsoId("_94wDkXltEeG7BsjMvd1mEw_-2048295830")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Version { get; init; }
}
