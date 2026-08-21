// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a party.
/// </summary>
[IsoId("_0MzpxzEyEe6g-ffJsqGiSA")]
[Description(@"Information that locates and identifies a party.")]
[DisplayName("Name And Address18")]
public record NameAndAddress18
{
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress27 Address { get; init; }

    /// <summary>
    /// Name by which a party is known and is usually used to identify that party.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required IsoMax140Text Name { get; init; }
}
