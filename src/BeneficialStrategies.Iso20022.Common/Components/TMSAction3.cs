// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
[IsoId("_8fKyYTV_EeODSIIQsYYKhw")]
[DisplayName("TMS Action")]
public record TMSAction3
{
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_8vr6oTV_EeODSIIQsYYKhw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction1Code Type { get; init; }

    /// <summary>
    /// Communication parameters of the terminal management system to contact.
    /// </summary>
    [IsoId("_8vr6ozV_EeODSIIQsYYKhw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters1? Address { get; init; }

    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_8vr6pTV_EeODSIIQsYYKhw")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification3? DataSetIdentification { get; init; }

    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_8vr6pzV_EeODSIIQsYYKhw")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; }

    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_8vr6qTV_EeODSIIQsYYKhw")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; }

    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_FGE90DWAEeODSIIQsYYKhw")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; }

    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_8vr6qzV_EeODSIIQsYYKhw")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming3? TimeCondition { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_8vr6rTV_EeODSIIQsYYKhw")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_8vr6rzV_EeODSIIQsYYKhw")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? KeyEnciphermentCertificate { get; init; }

    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_8vr6sTV_EeODSIIQsYYKhw")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ErrorAction2? ErrorAction { get; init; }
}
