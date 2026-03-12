// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command the ATM must perform.
/// </summary>
[IsoId("_dy_AoYtFEeSxlKlAGYErFg")]
[DisplayName("ATM Command")]
public partial record ATMCommand4
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_eFAkwYtFEeSxlKlAGYErFg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand2Code Type { get; init; } 
    
    /// <summary>
    /// Urgency of the command.
    /// </summary>
    [IsoId("_eFAkw4tFEeSxlKlAGYErFg")]
    [DisplayName("Urgency")]
    [IsoXmlTag("Urgcy")]
    public required TMSContactLevel2Code Urgency { get; init; } 
    
    /// <summary>
    /// Date time on which the command must be performed.
    /// </summary>
    [IsoId("_eFAkxYtFEeSxlKlAGYErFg")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateTime { get; init; } 
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_eFAkx4tFEeSxlKlAGYErFg")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
    /// <summary>
    /// Reason for sending the command.
    /// </summary>
    [IsoId("_JejzQItHEeSxlKlAGYErFg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ATMCommandReason1Code? Reason { get; init; } 
    
    /// <summary>
    /// Trace of reasons by the entities in the path from the origin of the command to the ATM.
    /// </summary>
    [IsoId("_VhtcEItHEeSxlKlAGYErFg")]
    [DisplayName("Trace Reason")]
    [IsoXmlTag("TracRsn")]
    public ATMCommandReason1Code? TraceReason { get; init; } 
    
    /// <summary>
    /// Additional information about the reason to request this command.
    /// </summary>
    [IsoId("_gOMz8ItHEeSxlKlAGYErFg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalReasonInformation { get; init; } 
    
    /// <summary>
    /// Specific parameters attached to the command.
    /// </summary>
    [IsoId("_eFAkyYtFEeSxlKlAGYErFg")]
    [DisplayName("Command Parameters")]
    [IsoXmlTag("CmdParams")]
    public ATMCommandParameters2Choice_? CommandParameters { get; init; } 
    
    
    #nullable disable
    
}
