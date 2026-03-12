// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Global status of the ATM.
/// </summary>
[IsoId("__xSdUIrxEeSvuOJS0mmL0g")]
[DisplayName("ATM Status")]
public partial record ATMStatus1
{
    #nullable enable
    
    /// <summary>
    /// Actual status of the ATM.
    /// </summary>
    [IsoId("_O76NYIryEeSvuOJS0mmL0g")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required ATMStatus1Code CurrentStatus { get; init; } 
    
    /// <summary>
    /// Present if the status required by the ATM manager is different from the current status.
    /// </summary>
    [IsoId("_TTaZIIryEeSvuOJS0mmL0g")]
    [DisplayName("Demanded Status")]
    [IsoXmlTag("DmnddSts")]
    public ATMStatus1Code? DemandedStatus { get; init; } 
    
    
    #nullable disable
    
}
