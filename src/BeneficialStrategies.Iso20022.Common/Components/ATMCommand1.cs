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
[IsoId("_Dv4KgIqJEeSRT5rEzcAHEw")]
[DisplayName("ATM Command")]
public partial record ATMCommand1
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_KWk8QIqKEeSRT5rEzcAHEw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand1Code Type { get; init; } 
    
    /// <summary>
    /// Urgency of the command.
    /// </summary>
    [IsoId("_j-ET0IqKEeSRT5rEzcAHEw")]
    [DisplayName("Urgency")]
    [IsoXmlTag("Urgcy")]
    public required TMSContactLevel2Code Urgency { get; init; } 
    
    /// <summary>
    /// Date time on which the command must be performed.
    /// </summary>
    [IsoId("_p7kNAIqKEeSRT5rEzcAHEw")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateTime { get; init; } 
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_zuDawIqKEeSRT5rEzcAHEw")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
    /// <summary>
    /// Specific parameters attached to the command.
    /// </summary>
    [IsoId("_R9z98IqLEeSRT5rEzcAHEw")]
    [DisplayName("Command Parameters")]
    [IsoXmlTag("CmdParams")]
    public ATMCommandParameters1Choice_? CommandParameters { get; init; } 
    
    
    #nullable disable
    
}
