// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to the address.
/// </summary>
[IsoId("_-fsW0W4-EeiU9cctagi5ow")]
[DisplayName("Address Modification")]
public record AddressModification2
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_-rUYAW4-EeiU9cctagi5ow")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Postal address.
    /// </summary>
    [IsoId("_-rUYA24-EeiU9cctagi5ow")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress24 Address { get; init; }
}
