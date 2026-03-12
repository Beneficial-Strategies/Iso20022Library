// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the exception.
/// </summary>
[IsoId("_CdeSga5EEeWCgYcWSNgX5g")]
[DisplayName("ATM Context")]
public partial record ATMContext20
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the exception occurred.
    /// </summary>
    [IsoId("_Cp_rka5EEeWCgYcWSNgX5g")]
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SessionReference { get; init; } 
    
    /// <summary>
    /// Service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_Cp_rk65EEeWCgYcWSNgX5g")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService24 Service { get; init; } 
    
    
    #nullable disable
    
}
