// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
/// </summary>
[IsoId("_kd6Sk2zIEeWAUO-90GtZEg")]
[DisplayName("Safe Keeping Place")]
public record SafeKeepingPlace1
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_kd6SlGzIEeWAUO-90GtZEg")]
    [DisplayName("Safekeeping Place Format")]
    [IsoXmlTag("SfkpgPlcFrmt")]
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlaceFormat { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a place of safekeeping.
    /// </summary>
    [IsoId("_kd6SlWzIEeWAUO-90GtZEg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
