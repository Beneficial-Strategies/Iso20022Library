// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Input Data6.
/// </summary>
[IsoId("_C98WQZB_Ee6FLLjWp95ntQ")]
[DisplayName("Input Data6")]
public partial record InputData6
{
    #nullable enable

    /// <summary>
    /// Beep Key Flag.
    /// </summary>
    [DisplayName("Beep Key Flag")]
    [IsoXmlTag("BeepKeyFlg")]
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 

    /// <summary>
    /// Device Type.
    /// </summary>
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required SaleCapabilities2Code DeviceType { get; init; } 

    /// <summary>
    /// Disable Cancel Flag.
    /// </summary>
    [DisplayName("Disable Cancel Flag")]
    [IsoXmlTag("DsblCclFlg")]
    public IsoTrueFalseIndicator? DisableCancelFlag { get; init; } 

    /// <summary>
    /// Disable Correct Flag.
    /// </summary>
    [DisplayName("Disable Correct Flag")]
    [IsoXmlTag("DsblCrrctFlg")]
    public IsoTrueFalseIndicator? DisableCorrectFlag { get; init; } 

    /// <summary>
    /// Disable Valid Flag.
    /// </summary>
    [DisplayName("Disable Valid Flag")]
    [IsoXmlTag("DsblVldFlg")]
    public IsoTrueFalseIndicator? DisableValidFlag { get; init; } 

    /// <summary>
    /// Global Correction Flag.
    /// </summary>
    [DisplayName("Global Correction Flag")]
    [IsoXmlTag("GblCrrctnFlg")]
    public IsoTrueFalseIndicator? GlobalCorrectionFlag { get; init; } 

    /// <summary>
    /// Immediate Response Flag.
    /// </summary>
    [DisplayName("Immediate Response Flag")]
    [IsoXmlTag("ImdtRspnFlg")]
    public IsoTrueFalseIndicator? ImmediateResponseFlag { get; init; } 

    /// <summary>
    /// Information Qualifier.
    /// </summary>
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public required InformationQualify1Code InformationQualifier { get; init; } 

    /// <summary>
    /// Input Command.
    /// </summary>
    [DisplayName("Input Command")]
    [IsoXmlTag("InptCmd")]
    public required InputCommand1Code InputCommand { get; init; } 

    /// <summary>
    /// Input Text.
    /// </summary>
    [DisplayName("Input Text")]
    [IsoXmlTag("InptTxt")]
    public ActionMessage11? InputText { get; init; } 

    /// <summary>
    /// Maximum Input Time.
    /// </summary>
    [DisplayName("Maximum Input Time")]
    [IsoXmlTag("MaxInptTm")]
    public IsoNumber? MaximumInputTime { get; init; } 

    /// <summary>
    /// Menu Back Flag.
    /// </summary>
    [DisplayName("Menu Back Flag")]
    [IsoXmlTag("MenuBckFlg")]
    public IsoTrueFalseIndicator? MenuBackFlag { get; init; } 

    /// <summary>
    /// Notify Card Input Flag.
    /// </summary>
    [DisplayName("Notify Card Input Flag")]
    [IsoXmlTag("NtfyCardInptFlg")]
    public required IsoTrueFalseIndicator NotifyCardInputFlag { get; init; } 

    /// <summary>
    /// Wait User Validation Flag.
    /// </summary>
    [DisplayName("Wait User Validation Flag")]
    [IsoXmlTag("WaitUsrVldtnFlg")]
    public IsoTrueFalseIndicator? WaitUserValidationFlag { get; init; } 

    
    #nullable disable
    
}
