// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of an individual terminal management action performed by the point of interaction.
/// </summary>
[IsoId("_FRf68U6rEeyGi9JAv6wq7Q")]
[DisplayName("TMS Event")]
public partial record TMSEvent9
{
    #nullable enable
    
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_FXo_MU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; } 
    
    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_FXo_M06rEeyGi9JAv6wq7Q")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult5Code Result { get; init; } 
    
    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_FXo_NU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Action Identification")]
    [IsoXmlTag("ActnId")]
    public required TMSActionIdentification8 ActionIdentification { get; init; } 
    
    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_FXo_N06rEeyGi9JAv6wq7Q")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalErrorInformation { get; init; } 
    
    /// <summary>
    /// Identification of the terminal management system (TMS) used with the action.
    /// </summary>
    [IsoId("_FXo_OU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Response  of a device request done previously. 
    /// </summary>
    [IsoId("_FXo_O06rEeyGi9JAv6wq7Q")]
    [DisplayName("Device Response")]
    [IsoXmlTag("DvcRspn")]
    public DeviceResponse5? DeviceResponse { get; init; } 
    
    
    #nullable disable
    
}
