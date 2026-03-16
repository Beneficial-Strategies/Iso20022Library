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
[IsoId("_puMT0dLFEeiN28wlpBQScw")]
[DisplayName("Safe Keeping Place")]
public record SafeKeepingPlace3
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_qVK0Q9LFEeiN28wlpBQScw")]
    [DisplayName("Safekeeping Place Format")]
    [IsoXmlTag("SfkpgPlcFrmt")]
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlaceFormat { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a place of safekeeping.
    /// </summary>
    [IsoId("_qVK0RdLFEeiN28wlpBQScw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
