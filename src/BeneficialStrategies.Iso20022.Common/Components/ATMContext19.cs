// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transfer is performed.
/// </summary>
[IsoId("_fmq7ca4yEeWpsoxRhdX-8A")]
[DisplayName("ATM Context")]
public partial record ATMContext19
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the transfer is performed.
    /// </summary>
    [IsoId("_fxZkwa4yEeWpsoxRhdX-8A")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; } 
    
    /// <summary>
    /// Fund transfer service requested by the ATM inside the session.
    /// </summary>
    [IsoId("_fxZkw64yEeWpsoxRhdX-8A")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService23 Service { get; init; } 
    
    
    #nullable disable
    
}
