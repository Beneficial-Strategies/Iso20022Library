// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an Input request.
/// </summary>
[IsoId("_KWsQoN6mEeiwsev40qZGEQ")]
[DisplayName("Input Data")]
public partial record InputData1
{
    #nullable enable
    
    /// <summary>
    /// Type of logical device located on a Sale Terminal or a POI Terminal.
    /// </summary>
    [IsoId("_RtI5wN6mEeiwsev40qZGEQ")]
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required SaleCapabilities2Code DeviceType { get; init; } 
    
    /// <summary>
    /// Qualification of the information to output to the logical device.
    /// </summary>
    [IsoId("_RO_IsN6nEeiwsev40qZGEQ")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public required InformationQualify1Code InformationQualifier { get; init; } 
    
    /// <summary>
    /// Type of requested input.
    /// </summary>
    [IsoId("_hCQ0MN6nEeiwsev40qZGEQ")]
    [DisplayName("Input Command")]
    [IsoXmlTag("InptCmd")]
    public required InputCommand1Code InputCommand { get; init; } 
    
    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    [IsoId("_MLfkMN6oEeiwsev40qZGEQ")]
    [DisplayName("Notify Card Input Flag")]
    [IsoXmlTag("NtfyCardInptFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator NotifyCardInputFlag { get; init; } 
    
    /// <summary>
    /// Maximum input time in seconds.
    /// </summary>
    [IsoId("_PgM2MN6oEeiwsev40qZGEQ")]
    [DisplayName("Maximum Input Time")]
    [IsoXmlTag("MaxInptTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumInputTime { get; init; } 
    
    /// <summary>
    /// Text value set for an input command.
    /// </summary>
    [IsoId("_VZeWsN6oEeiwsev40qZGEQ")]
    [DisplayName("Input Text")]
    [IsoXmlTag("InptTxt")]
    public ActionMessage6? InputText { get; init; } 
    
    /// <summary>
    /// Flag to request Immediate response without waiting for the completion of the command.
    /// </summary>
    [IsoId("_YpmqsN6oEeiwsev40qZGEQ")]
    [DisplayName("Immediate Response Flag")]
    [IsoXmlTag("ImdtRspnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ImmediateResponseFlag { get; init; } 
    
    /// <summary>
    /// Flag to confirm by the user the entered characters, when the maximum allowed length is reached.
    /// </summary>
    [IsoId("_c03KMN6oEeiwsev40qZGEQ")]
    [DisplayName("Wait User Validation Flag")]
    [IsoXmlTag("WaitUsrVldtnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? WaitUserValidationFlag { get; init; } 
    
    /// <summary>
    /// Flag to indicate that when the user press a key, a beep has to be generated.
    /// </summary>
    [IsoId("_269k4F9TEemO-eIlMympSQ")]
    [DisplayName("Beep Key Flag")]
    [IsoXmlTag("BeepKeyFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 
    
    /// <summary>
    /// Flag to correct all characters (True) or just the last one (False).
    /// </summary>
    [IsoId("_g5jusN6oEeiwsev40qZGEQ")]
    [DisplayName("Global Correction Flag")]
    [IsoXmlTag("GblCrrctnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GlobalCorrectionFlag { get; init; } 
    
    /// <summary>
    /// Flag to deactivate the &quot;Cancel&quot; function key.
    /// </summary>
    [IsoId("_jogBMN6oEeiwsev40qZGEQ")]
    [DisplayName("Disable Cancel Flag")]
    [IsoXmlTag("DsblCclFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisableCancelFlag { get; init; } 
    
    /// <summary>
    /// Flag to deactivate the &quot;Correct&quot; function key.
    /// </summary>
    [IsoId("_8ipmIF9TEemO-eIlMympSQ")]
    [DisplayName("Disable Correct Flag")]
    [IsoXmlTag("DsblCrrctFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisableCorrectFlag { get; init; } 
    
    /// <summary>
    /// Flag to disable the &quot;Valid&quot; function key.
    /// </summary>
    [IsoId("_l80NMN6oEeiwsev40qZGEQ")]
    [DisplayName("Disable Valid Flag")]
    [IsoXmlTag("DsblVldFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisableValidFlag { get; init; } 
    
    /// <summary>
    /// Flag to enable the &quot;Back&quot; function key to go the upper level.
    /// </summary>
    [IsoId("_r8HdMN6oEeiwsev40qZGEQ")]
    [DisplayName("Menu Back Flag")]
    [IsoXmlTag("MenuBckFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MenuBackFlag { get; init; } 
    
    
    #nullable disable
    
}
