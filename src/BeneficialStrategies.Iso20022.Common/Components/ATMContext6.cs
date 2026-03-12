// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the inquiry is performed.
/// </summary>
[IsoId("_RGIdUYqyEeSIDtZ76p6McQ")]
[DisplayName("ATM Context")]
public partial record ATMContext6
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the service is performed.
    /// </summary>
    [IsoId("_RSzAUYqyEeSIDtZ76p6McQ")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; } 
    
    /// <summary>
    /// Withdrawal service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_RSzAU4qyEeSIDtZ76p6McQ")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService6 Service { get; init; } 
    
    
    #nullable disable
    
}
