// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command to perform on an ATM.
/// </summary>
[IsoId("_W_3jIa2BEeWMg5rOByfExw")]
[DisplayName("ATM Command")]
public partial record ATMCommand7
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_XMiGIa2BEeWMg5rOByfExw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand4Code Type { get; init; } 
    
    /// <summary>
    /// Urgency of the command.
    /// </summary>
    [IsoId("_XMiGI62BEeWMg5rOByfExw")]
    [DisplayName("Urgency")]
    [IsoXmlTag("Urgcy")]
    public required TMSContactLevel2Code Urgency { get; init; } 
    
    /// <summary>
    /// Date time on which the command must be performed.
    /// </summary>
    [IsoId("_XMiGJa2BEeWMg5rOByfExw")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateTime { get; init; } 
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_XMiGJ62BEeWMg5rOByfExw")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
    /// <summary>
    /// Specific parameters attached to the command.
    /// </summary>
    [IsoId("_XMiGKa2BEeWMg5rOByfExw")]
    [DisplayName("Command Parameters")]
    [IsoXmlTag("CmdParams")]
    public ATMCommandParameters1Choice_? CommandParameters { get; init; } 
    
    
    #nullable disable
    
}
