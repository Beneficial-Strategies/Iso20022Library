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
[IsoId("_X1Y0ca4GEeWL1uap3dNhCQ")]
[DisplayName("ATM Context")]
public record ATMContext11
{
    /// <summary>
    /// Unique identification of the customer session in which the service is performed.
    /// </summary>
    [IsoId("_YAROwa4GEeWL1uap3dNhCQ")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; }

    /// <summary>
    /// Deposit service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_YAROw64GEeWL1uap3dNhCQ")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public ATMService12? Service { get; init; }
}
