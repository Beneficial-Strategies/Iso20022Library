// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Name And Address18.
/// </summary>
[IsoId("_0MzpxzEyEe6g-ffJsqGiSA")]
[DisplayName("Name And Address18")]
public record NameAndAddress18
{
    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress27 Address { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required IsoMax140Text Name { get; init; }
}
