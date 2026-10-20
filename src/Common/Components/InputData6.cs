// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Input Data6.
/// </summary>
[IsoId("_C98WQZB_Ee6FLLjWp95ntQ")]
[DisplayName("Input Data6")]
public partial record InputData6
{
    /// <summary>
    /// Device Type.
    /// </summary>
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required SaleCapabilities2Code DeviceType { get; init; }

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
    /// Notify Card Input Flag.
    /// </summary>
    [DisplayName("Notify Card Input Flag")]
    [IsoXmlTag("NtfyCardInptFlg")]
    public required TrueFalseIndicator NotifyCardInputFlag { get; init; }

    /// <summary>
    /// Maximum Input Time.
    /// </summary>
    [DisplayName("Maximum Input Time")]
    [IsoXmlTag("MaxInptTm")]
    public Number? MaximumInputTime { get; init; }

    /// <summary>
    /// Input Text.
    /// </summary>
    [DisplayName("Input Text")]
    [IsoXmlTag("InptTxt")]
    public ActionMessage11? InputText { get; init; }

    /// <summary>
    /// Immediate Response Flag.
    /// </summary>
    [DisplayName("Immediate Response Flag")]
    [IsoXmlTag("ImdtRspnFlg")]
    public TrueFalseIndicator? ImmediateResponseFlag { get; init; }

    /// <summary>
    /// Wait User Validation Flag.
    /// </summary>
    [DisplayName("Wait User Validation Flag")]
    [IsoXmlTag("WaitUsrVldtnFlg")]
    public TrueFalseIndicator? WaitUserValidationFlag { get; init; }

    /// <summary>
    /// Beep Key Flag.
    /// </summary>
    [DisplayName("Beep Key Flag")]
    [IsoXmlTag("BeepKeyFlg")]
    public TrueFalseIndicator? BeepKeyFlag { get; init; }

    /// <summary>
    /// Global Correction Flag.
    /// </summary>
    [DisplayName("Global Correction Flag")]
    [IsoXmlTag("GblCrrctnFlg")]
    public TrueFalseIndicator? GlobalCorrectionFlag { get; init; }

    /// <summary>
    /// Disable Cancel Flag.
    /// </summary>
    [DisplayName("Disable Cancel Flag")]
    [IsoXmlTag("DsblCclFlg")]
    public TrueFalseIndicator? DisableCancelFlag { get; init; }

    /// <summary>
    /// Disable Correct Flag.
    /// </summary>
    [DisplayName("Disable Correct Flag")]
    [IsoXmlTag("DsblCrrctFlg")]
    public TrueFalseIndicator? DisableCorrectFlag { get; init; }

    /// <summary>
    /// Disable Valid Flag.
    /// </summary>
    [DisplayName("Disable Valid Flag")]
    [IsoXmlTag("DsblVldFlg")]
    public TrueFalseIndicator? DisableValidFlag { get; init; }

    /// <summary>
    /// Menu Back Flag.
    /// </summary>
    [DisplayName("Menu Back Flag")]
    [IsoXmlTag("MenuBckFlg")]
    public TrueFalseIndicator? MenuBackFlag { get; init; }
}
