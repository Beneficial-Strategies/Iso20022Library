// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Command result for reinitialization of the transaction counters.
/// </summary>
[IsoId("_XgXzoa47EeWRfYPBaeOY8w")]
[DisplayName("ATM Command")]
public partial record ATMCommand8
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_XrkXAa47EeWRfYPBaeOY8w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand5Code Type { get; init; } 
    
    /// <summary>
    /// Date time on which the command has been requested to be performed.
    /// </summary>
    [IsoId("_XrkXA647EeWRfYPBaeOY8w")]
    [DisplayName("Required Date Time")]
    [IsoXmlTag("ReqrdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequiredDateTime { get; init; } 
    
    /// <summary>
    /// Date time on which the command has been performed.
    /// </summary>
    [IsoId("_XrkXBa47EeWRfYPBaeOY8w")]
    [DisplayName("Processed Date Time")]
    [IsoXmlTag("PrcdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ProcessedDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_XrkXB647EeWRfYPBaeOY8w")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
    /// <summary>
    /// Final result of the processed command at the ATM.
    /// </summary>
    [IsoId("_XrkXCa47EeWRfYPBaeOY8w")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult2Code Result { get; init; } 
    
    /// <summary>
    /// Additional information on the failure to be logged for further examination.
    /// </summary>
    [IsoId("_XrkXC647EeWRfYPBaeOY8w")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalErrorInformation { get; init; } 
    
    
    #nullable disable
    
}
