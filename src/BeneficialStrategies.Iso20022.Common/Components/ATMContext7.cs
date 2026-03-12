// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transaction is performed.
/// </summary>
[IsoId("_A8ILgYrAEeSgLpgNvMAP2g")]
[DisplayName("ATM Context")]
public partial record ATMContext7
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the service is performed.
    /// </summary>
    [IsoId("_BI8fgYrAEeSgLpgNvMAP2g")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_BI8fg4rAEeSgLpgNvMAP2g")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService8 Service { get; init; } 
    
    
    #nullable disable
    
}
