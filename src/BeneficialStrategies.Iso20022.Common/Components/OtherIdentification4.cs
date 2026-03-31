// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial instrument using an accepted format other than an ISIN.
/// </summary>
[IsoId("_fMy68V9NEeS7xuKaq75oiQ")]
[DisplayName("Other Identification")]
public record OtherIdentification4
{
    /// <summary>
    /// Identification of the fund/sub fund.
    /// </summary>
    [IsoId("_fn3tYV9NEeS7xuKaq75oiQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Identification source.
    /// </summary>
    [IsoId("_fn3tZV9NEeS7xuKaq75oiQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IdentificationSource5Choice_ Type { get; init; }
}
