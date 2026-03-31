// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Name and address of an institution.
/// </summary>
[IsoId("_PZleQdp-Ed-ak6NoX_4Aeg_1385273164")]
[DisplayName("Name And Address")]
public record NameAndAddress7
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PZleQtp-Ed-ak6NoX_4Aeg_1385273243")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_PZleQ9p-Ed-ak6NoX_4Aeg_1385275042")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public required PostalAddress1 PostalAddress { get; init; }
}
