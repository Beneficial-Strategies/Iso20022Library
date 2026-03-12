// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of a maintenance command performed by the ATM.
/// </summary>
[IsoId("_QlA-MV_UEeeD0NpJQPACzA")]
[DisplayName("ATM Command")]
public partial record ATMCommand11
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_Qtzt0V_UEeeD0NpJQPACzA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand6Code Type { get; init; } 
    
    /// <summary>
    /// Date time on which the command has been requested to be performed.
    /// </summary>
    [IsoId("_Qtzt01_UEeeD0NpJQPACzA")]
    [DisplayName("Required Date Time")]
    [IsoXmlTag("ReqrdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequiredDateTime { get; init; } 
    
    /// <summary>
    /// Date time on which the command has been performed.
    /// </summary>
    [IsoId("_Qtzt1V_UEeeD0NpJQPACzA")]
    [DisplayName("Processed Date Time")]
    [IsoXmlTag("PrcdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ProcessedDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_Qtzt11_UEeeD0NpJQPACzA")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
    /// <summary>
    /// Final result of the processed command at the ATM.
    /// </summary>
    [IsoId("_Qtzt2V_UEeeD0NpJQPACzA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult2Code Result { get; init; } 
    
    /// <summary>
    /// Additional information on the failure to be logged for further examination.
    /// </summary>
    [IsoId("_Qtzt21_UEeeD0NpJQPACzA")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalErrorInformation { get; init; } 
    
    
    #nullable disable
    
}
