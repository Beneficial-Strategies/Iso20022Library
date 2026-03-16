// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security Identification48.
/// </summary>
[IsoId("_T_NGEZIQEe-HRNGM304Vlw")]
[DisplayName("Security Identification48")]
public record SecurityIdentification48
{
    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax140Text? Description { get; init; }

    /// <summary>
    /// ISIN.
    /// </summary>
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public IsoISINOct2015Identifier? ISIN { get; init; }

    /// <summary>
    /// Other Identification.
    /// </summary>
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public ValueList<OtherIdentification1> OtherIdentification { get; init; } = [];
}
