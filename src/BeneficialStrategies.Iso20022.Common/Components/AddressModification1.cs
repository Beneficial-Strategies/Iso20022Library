// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to the address.
/// </summary>
[IsoId("__2QXEA4jEeK3IMoVvcTkkg")]
[DisplayName("Address Modification")]
public partial record AddressModification1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_LfDmMA4kEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; } 
    
    /// <summary>
    /// Postal address.
    /// </summary>
    [IsoId("_RcjfYA4kEeK3IMoVvcTkkg")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress6 Address { get; init; } 
    
    
    #nullable disable
    
}
