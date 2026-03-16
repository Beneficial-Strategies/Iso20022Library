// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transaction is performed.
/// </summary>
[IsoId("_HBudca4bEeW_TaP-ygI0SQ")]
[DisplayName("ATM Context")]
public record ATMContext17
{
    /// <summary>
    /// Unique identification of the customer session in which the service is performed.
    /// </summary>
    [IsoId("_HMwBsa4bEeW_TaP-ygI0SQ")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; }

    /// <summary>
    /// Withdrawal service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_HMwBs64bEeW_TaP-ygI0SQ")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService21 Service { get; init; }
}
