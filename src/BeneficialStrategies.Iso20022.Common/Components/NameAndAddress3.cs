// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="INameAndAddress3"/>
[IsoId("_PZcUU9p-Ed-ak6NoX_4Aeg_-2099385393")]
[DisplayName("Name And Address")]
public partial record NameAndAddress3
{
    /// <inheritdoc cref="INameAndAddress3.Name"/>
    [IsoId("_PZcUVNp-Ed-ak6NoX_4Aeg_-2047670244")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; }

    /// <inheritdoc cref="INameAndAddress3.Address"/>
    [IsoId("_PZcUVdp-Ed-ak6NoX_4Aeg_-1111154172")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress1 Address { get; init; }
}
