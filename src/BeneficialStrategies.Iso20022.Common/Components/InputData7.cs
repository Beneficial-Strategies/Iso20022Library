// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an input request.
/// </summary>
[IsoId("_R_2h4bZiEfCUZfsQO4rYeA")]
[DisplayName("Input Data7")]
public record InputData7
{
    /// <summary>
    /// Type of logical device located on a Sale Terminal or a POI Terminal.
    /// </summary>
    [IsoId("_SAwg1bZiEfCUZfsQO4rYeA")]
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required SaleCapabilities2Code DeviceType { get; init; }

    /// <summary>
    /// Qualification of the information to output to the logical device.
    /// </summary>
    [IsoId("_SAwg27ZiEfCUZfsQO4rYeA")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public required InformationQualify1Code InformationQualifier { get; init; }

    /// <summary>
    /// Type of requested input.
    /// </summary>
    [IsoId("_SAwg4bZiEfCUZfsQO4rYeA")]
    [DisplayName("Input Command")]
    [IsoXmlTag("InptCmd")]
    public required InputCommand1Code InputCommand { get; init; }

    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    [IsoId("_SAwg57ZiEfCUZfsQO4rYeA")]
    [DisplayName("Notify Card Input Flag")]
    [IsoXmlTag("NtfyCardInptFlg")]
    public required IsoTrueFalseIndicator NotifyCardInputFlag { get; init; }

    /// <summary>
    /// Maximum input time in seconds.
    /// </summary>
    [IsoId("_SAwg7bZiEfCUZfsQO4rYeA")]
    [DisplayName("Maximum Input Time")]
    [IsoXmlTag("MaxInptTm")]
    public IsoNumber? MaximumInputTime { get; init; }

    /// <summary>
    /// Text value set for an input command.
    /// </summary>
    [IsoId("_SAwg87ZiEfCUZfsQO4rYeA")]
    [DisplayName("Input Text")]
    [IsoXmlTag("InptTxt")]
    public ActionMessage12? InputText { get; init; }

    /// <summary>
    /// Flag to request Immediate response without waiting for the completion of the command.
    /// </summary>
    [IsoId("_SAwg-bZiEfCUZfsQO4rYeA")]
    [DisplayName("Immediate Response Flag")]
    [IsoXmlTag("ImdtRspnFlg")]
    public IsoTrueFalseIndicator? ImmediateResponseFlag { get; init; }

    /// <summary>
    /// Flag to confirm by the user the entered characters, when the maximum allowed length is reached.
    /// </summary>
    [IsoId("_SAwg_7ZiEfCUZfsQO4rYeA")]
    [DisplayName("Wait User Validation Flag")]
    [IsoXmlTag("WaitUsrVldtnFlg")]
    public IsoTrueFalseIndicator? WaitUserValidationFlag { get; init; }

    /// <summary>
    /// Flag to indicate that when the user press a key, a beep has to be generated.
    /// </summary>
    [IsoId("_SAwhBbZiEfCUZfsQO4rYeA")]
    [DisplayName("Beep Key Flag")]
    [IsoXmlTag("BeepKeyFlg")]
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; }

    /// <summary>
    /// Flag to correct all characters (True) or just the last one (False).
    /// </summary>
    [IsoId("_SAwhC7ZiEfCUZfsQO4rYeA")]
    [DisplayName("Global Correction Flag")]
    [IsoXmlTag("GblCrrctnFlg")]
    public IsoTrueFalseIndicator? GlobalCorrectionFlag { get; init; }

    /// <summary>
    /// Flag to deactivate the "Cancel" function key.
    /// </summary>
    [IsoId("_SAwhEbZiEfCUZfsQO4rYeA")]
    [DisplayName("Disable Cancel Flag")]
    [IsoXmlTag("DsblCclFlg")]
    public IsoTrueFalseIndicator? DisableCancelFlag { get; init; }

    /// <summary>
    /// Flag to deactivate the "Correct" function key.
    /// </summary>
    [IsoId("_SAwhF7ZiEfCUZfsQO4rYeA")]
    [DisplayName("Disable Correct Flag")]
    [IsoXmlTag("DsblCrrctFlg")]
    public IsoTrueFalseIndicator? DisableCorrectFlag { get; init; }

    /// <summary>
    /// Flag to disable the "Valid" function key.
    /// </summary>
    [IsoId("_SAwhHbZiEfCUZfsQO4rYeA")]
    [DisplayName("Disable Valid Flag")]
    [IsoXmlTag("DsblVldFlg")]
    public IsoTrueFalseIndicator? DisableValidFlag { get; init; }

    /// <summary>
    /// Flag to enable the "Back" function key to go the upper level.
    /// </summary>
    [IsoId("_SAwhI7ZiEfCUZfsQO4rYeA")]
    [DisplayName("Menu Back Flag")]
    [IsoXmlTag("MenuBckFlg")]
    public IsoTrueFalseIndicator? MenuBackFlag { get; init; }
}
