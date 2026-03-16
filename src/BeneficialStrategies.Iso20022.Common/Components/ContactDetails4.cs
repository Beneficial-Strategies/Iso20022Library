// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_TVX6Ae3mEeaWjpoyrnG6Rw")]
[DisplayName("Contact Details")]
public record ContactDetails4
{
    /// <summary>
    /// Name of the liaison at the Settlement Internaliser.
    /// </summary>
    [IsoId("_TiBO5e3mEeaWjpoyrnG6Rw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Phone number of the liaison at the Settlement Internaliser.
    /// </summary>
    [IsoId("_TiBO5-3mEeaWjpoyrnG6Rw")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public required IsoPhoneNumber PhoneNumber { get; init; }

    /// <summary>
    /// Electronic mail (e-mail) address of the liaison at the Settlement Internaliser.
    /// </summary>
    [IsoId("_TiBO7e3mEeaWjpoyrnG6Rw")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public required IsoMax2048Text EmailAddress { get; init; }

    /// <summary>
    /// Function of the liaison at the Settlement Internaliser.
    /// </summary>
    [IsoId("_TiBO7-3mEeaWjpoyrnG6Rw")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Function { get; init; }
}
