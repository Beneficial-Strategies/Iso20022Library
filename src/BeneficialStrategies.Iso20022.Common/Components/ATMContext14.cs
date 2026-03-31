// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the inquiry is performed.
/// </summary>
[IsoId("_4koUAa4VEeW_TaP-ygI0SQ")]
[DisplayName("ATM Context")]
public record ATMContext14
{
    /// <summary>
    /// Unique identification of the customer session in which the service is performed.
    /// </summary>
    [IsoId("_4vp4Qa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; }

    /// <summary>
    /// Withdrawal service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_4vp4Q64VEeW_TaP-ygI0SQ")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService15 Service { get; init; }
}
