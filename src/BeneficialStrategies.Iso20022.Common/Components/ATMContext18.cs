// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transfer is performed.
/// </summary>
[IsoId("_irEvUa4sEeWLdt0vLARX2Q")]
[DisplayName("ATM Context")]
public record ATMContext18
{
    /// <summary>
    /// Unique identification of the customer session in which the transfer is performed.
    /// </summary>
    [IsoId("_i2i_ga4sEeWLdt0vLARX2Q")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; }

    /// <summary>
    /// Fund transfer service requested by the ATM inside the session.
    /// </summary>
    [IsoId("_i2i_g64sEeWLdt0vLARX2Q")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService22 Service { get; init; }
}
