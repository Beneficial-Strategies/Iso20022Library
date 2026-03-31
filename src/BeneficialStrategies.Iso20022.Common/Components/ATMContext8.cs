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
[IsoId("_KFQnga15EeWMg5rOByfExw")]
[DisplayName("ATM Context")]
public record ATMContext8
{
    /// <summary>
    /// Unique identification of the customer session in which the service is performed.
    /// </summary>
    [IsoId("_KSX2ca15EeWMg5rOByfExw")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; }

    /// <summary>
    /// Withdrawal service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_KSX2c615EeWMg5rOByfExw")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public ATMService9? Service { get; init; }
}
