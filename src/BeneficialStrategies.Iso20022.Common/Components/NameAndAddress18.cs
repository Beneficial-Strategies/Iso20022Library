// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="INameAndAddress18"/>
[IsoId("_0MzpxzEyEe6g-ffJsqGiSA")]
[Description(@"Information that locates and identifies a party.")]
[DisplayName("Name And Address18")]
public partial record NameAndAddress18
{
    /// <inheritdoc cref="INameAndAddress18.Address"/>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress27 Address { get; init; }

    /// <inheritdoc cref="INameAndAddress18.Name"/>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required IsoMax140Text Name { get; init; }
}
