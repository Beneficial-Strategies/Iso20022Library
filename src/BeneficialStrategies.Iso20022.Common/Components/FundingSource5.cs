// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Source of funding.
/// </summary>
[IsoId("_kuj4gT_ZEfCQAqQ9lolFUg")]
[DisplayName("Funding Source5")]
public record FundingSource5
{
    /// <summary>
    /// Type of source funding used to perform the transfer of funds. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_kw7QAT_ZEfCQAqQ9lolFUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public FundingSourceType4Code? Type { get; init; }

    /// <summary>
    /// Reference to the funding source.
    /// </summary>
    [IsoId("_kw7QBT_ZEfCQAqQ9lolFUg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }
}
