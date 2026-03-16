// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Safe Keeping Place5.
/// </summary>
[IsoId("_PERT24-4Ee-nyIlugK8fOQ")]
[DisplayName("Safe Keeping Place5")]
public record SafeKeepingPlace5
{
    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Safekeeping Place Format.
    /// </summary>
    [DisplayName("Safekeeping Place Format")]
    [IsoXmlTag("SfkpgPlcFrmt")]
    public SafekeepingPlaceFormat41Choice_? SafekeepingPlaceFormat { get; init; }
}
