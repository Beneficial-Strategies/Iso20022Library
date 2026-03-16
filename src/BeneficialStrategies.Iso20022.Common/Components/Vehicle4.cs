// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of vehicle.
/// </summary>
[IsoId("_fX6l4PTaEeife6veM7daYw")]
[DisplayName("Vehicle")]
public record Vehicle4
{
    /// <summary>
    /// Contains the classification of the vehicle (for example, economy, intermediate, luxury, etc.)
    /// </summary>
    [IsoId("_fX6l6PTaEeife6veM7daYw")]
    [DisplayName("Class")]
    [IsoXmlTag("Clss")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Class { get; init; }

    /// <summary>
    /// Brand or manufacturer of the vehicle.
    /// </summary>
    [IsoId("_fX6l7fTaEeife6veM7daYw")]
    [DisplayName("Make")]
    [IsoXmlTag("Make")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? Make { get; init; }

    /// <summary>
    /// Product line of vehicle within the make.
    /// </summary>
    [IsoId("_fX6l5_TaEeife6veM7daYw")]
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? Model { get; init; }

    /// <summary>
    /// Registration number of vehicle.
    /// </summary>
    [IsoId("_fX6l4vTaEeife6veM7daYw")]
    [DisplayName("Registration Number")]
    [IsoXmlTag("RegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrationNumber { get; init; }
}
