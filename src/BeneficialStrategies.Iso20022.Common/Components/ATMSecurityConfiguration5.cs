// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration of the PIN online verification.
/// </summary>
[IsoId("_Xf8qAYr9EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
public partial record ATMSecurityConfiguration5
{
    #nullable enable
    
    /// <summary>
    /// PIN block format the security module is able to manage for online verification of the PIN.
    /// </summary>
    [IsoId("_lihz8Ir9EeSvuOJS0mmL0g")]
    [DisplayName("PIN Format")]
    [IsoXmlTag("PINFrmt")]
    public PINFormat4Code? PINFormat { get; init; } 
    
    /// <summary>
    /// Maximum number of digits the security module is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_5hgD0Ir9EeSvuOJS0mmL0g")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PINLengthCapabilities { get; init; } 
    
    
    #nullable disable
    
}
