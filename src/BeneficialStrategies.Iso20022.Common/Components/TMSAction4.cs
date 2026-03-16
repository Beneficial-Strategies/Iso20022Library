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
[IsoId("_7FMksWpPEeSR-ZWLvO-1dg")]
[DisplayName("TMS Action")]
public record TMSAction4
{
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_7Rt9wWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction1Code Type { get; init; }

    /// <summary>
    /// Host access information.
    /// </summary>
    [IsoId("_GKDccGpUEeSR-ZWLvO-1dg")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters3? RemoteAccess { get; init; }

    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    [IsoId("_MpSCUGpXEeSR-ZWLvO-1dg")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification71? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    [IsoId("_PYYF0GpXEeSR-ZWLvO-1dg")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocol { get; init; }

    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_RCeQIGpXEeSR-ZWLvO-1dg")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocolVersion { get; init; }

    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_7Rt9xWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification4? DataSetIdentification { get; init; }

    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    [IsoId("_wTMhEGpXEeSR-ZWLvO-1dg")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmpntTp")]
    public SimpleValueList<DataSetCategory4Code> ComponentType { get; init; } = [];

    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("_6uR_4GpXEeSR-ZWLvO-1dg")]
    [DisplayName("Parameters Subset Identification")]
    [IsoXmlTag("ParamsSubsetId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ParametersSubsetIdentification { get; init; }

    /// <summary>
    /// Definition of the subset of application parameters, for instance the range of application profiles, the RID (registered application provider identification).
    /// </summary>
    [IsoId("_DzkwcGpYEeSR-ZWLvO-1dg")]
    [DisplayName("Parameters Subset Definition")]
    [IsoXmlTag("ParamsSubsetDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? ParametersSubsetDefinition { get; init; }

    /// <summary>
    /// Proof of delegation to be verified by the POI, when performing the delegated actions.
    /// </summary>
    [IsoId("_MsNlEGpYEeSR-ZWLvO-1dg")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_dFybkGpYEeSR-ZWLvO-1dg")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType12? ProtectedDelegationProof { get; init; }

    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_7Rt9x2pPEeSR-ZWLvO-1dg")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; }

    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_7Rt9yWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public SimpleValueList<TerminalManagementAdditionalProcess1Code> AdditionalProcess { get; init; } =
        [];

    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_7Rt9y2pPEeSR-ZWLvO-1dg")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; }

    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_7Rt9zWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming3? TimeCondition { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_7Rt9z2pPEeSR-ZWLvO-1dg")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_7Rt90WpPEeSR-ZWLvO-1dg")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    public SimpleValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = [];

    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_7Rt902pPEeSR-ZWLvO-1dg")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ValueList<ErrorAction2> ErrorAction { get; init; } = [];

    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    [IsoId("_n_nr4GpYEeSR-ZWLvO-1dg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax3000Binary> AdditionalInformation { get; init; } = [];
}
