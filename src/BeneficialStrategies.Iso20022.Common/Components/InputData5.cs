// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an input request.
/// </summary>
[IsoId("_iw6rEXGaEe2TbaNWBpRZpQ")]
[DisplayName("Input Data")]
public partial record InputData5
{
    #nullable enable
    
    /// <summary>
    /// Type of logical device located on a Sale Terminal or a POI Terminal.
    /// </summary>
    [IsoId("_i3hpYXGaEe2TbaNWBpRZpQ")]
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required SaleCapabilities2Code DeviceType { get; init; } 
    
    /// <summary>
    /// Qualification of the information to output to the logical device.
    /// </summary>
    [IsoId("_i3hpY3GaEe2TbaNWBpRZpQ")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public required InformationQualify1Code InformationQualifier { get; init; } 
    
    /// <summary>
    /// Type of requested input.
    /// </summary>
    [IsoId("_i3hpZXGaEe2TbaNWBpRZpQ")]
    [DisplayName("Input Command")]
    [IsoXmlTag("InptCmd")]
    public required InputCommand1Code InputCommand { get; init; } 
    
    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    [IsoId("_i3hpZ3GaEe2TbaNWBpRZpQ")]
    [DisplayName("Notify Card Input Flag")]
    [IsoXmlTag("NtfyCardInptFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator NotifyCardInputFlag { get; init; } 
    
    /// <summary>
    /// Maximum input time in seconds.
    /// </summary>
    [IsoId("_i3hpaXGaEe2TbaNWBpRZpQ")]
    [DisplayName("Maximum Input Time")]
    [IsoXmlTag("MaxInptTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumInputTime { get; init; } 
    
    /// <summary>
    /// Text value set for an input command.
    /// </summary>
    [IsoId("_i3hpa3GaEe2TbaNWBpRZpQ")]
    [DisplayName("Input Text")]
    [IsoXmlTag("InptTxt")]
    public ActionMessage10? InputText { get; init; } 
    
    /// <summary>
    /// Flag to request Immediate response without waiting for the completion of the command.
    /// </summary>
    [IsoId("_i3hpbXGaEe2TbaNWBpRZpQ")]
    [DisplayName("Immediate Response Flag")]
    [IsoXmlTag("ImdtRspnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ImmediateResponseFlag { get; init; } 
    
    /// <summary>
    /// Flag to confirm by the user the entered characters, when the maximum allowed length is reached.
    /// </summary>
    [IsoId("_i3hpb3GaEe2TbaNWBpRZpQ")]
    [DisplayName("Wait User Validation Flag")]
    [IsoXmlTag("WaitUsrVldtnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? WaitUserValidationFlag { get; init; } 
    
    /// <summary>
    /// Flag to indicate that when the user press a key, a beep has to be generated.
    /// </summary>
    [IsoId("_i3hpcXGaEe2TbaNWBpRZpQ")]
    [DisplayName("Beep Key Flag")]
    [IsoXmlTag("BeepKeyFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 
    
    /// <summary>
    /// Flag to correct all characters (True) or just the last one (False).
    /// </summary>
    [IsoId("_i3hpc3GaEe2TbaNWBpRZpQ")]
    [DisplayName("Global Correction Flag")]
    [IsoXmlTag("GblCrrctnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GlobalCorrectionFlag { get; init; } 
    
    /// <summary>
    /// Flag to deactivate the &quot;Cancel&quot; function key.
    /// </summary>
    [IsoId("_i3hpdXGaEe2TbaNWBpRZpQ")]
    [DisplayName("Disable Cancel Flag")]
    [IsoXmlTag("DsblCclFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisableCancelFlag { get; init; } 
    
    /// <summary>
    /// Flag to deactivate the &quot;Correct&quot; function key.
    /// </summary>
    [IsoId("_i3hpd3GaEe2TbaNWBpRZpQ")]
    [DisplayName("Disable Correct Flag")]
    [IsoXmlTag("DsblCrrctFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisableCorrectFlag { get; init; } 
    
    /// <summary>
    /// Flag to disable the &quot;Valid&quot; function key.
    /// </summary>
    [IsoId("_i3hpeXGaEe2TbaNWBpRZpQ")]
    [DisplayName("Disable Valid Flag")]
    [IsoXmlTag("DsblVldFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisableValidFlag { get; init; } 
    
    /// <summary>
    /// Flag to enable the &quot;Back&quot; function key to go the upper level.
    /// </summary>
    [IsoId("_i3hpe3GaEe2TbaNWBpRZpQ")]
    [DisplayName("Menu Back Flag")]
    [IsoXmlTag("MenuBckFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MenuBackFlag { get; init; } 
    
    
    #nullable disable
    
}
