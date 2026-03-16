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
[IsoId("_e7XxUXGkEe2TbaNWBpRZpQ")]
[DisplayName("TMS Action")]
public record TMSAction11
{
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_fC8Y8XGkEe2TbaNWBpRZpQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction5Code Type { get; init; }

    /// <summary>
    /// Host access information.
    /// </summary>
    [IsoId("_fC8Y83GkEe2TbaNWBpRZpQ")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters7? RemoteAccess { get; init; }

    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_fC8Y9XGkEe2TbaNWBpRZpQ")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<KEKIdentifier5> Key { get; init; } = [];

    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    [IsoId("_fC8Y93GkEe2TbaNWBpRZpQ")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification176? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    [IsoId("_fC8Y-XGkEe2TbaNWBpRZpQ")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocol { get; init; }

    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_fC8Y-3GkEe2TbaNWBpRZpQ")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocolVersion { get; init; }

    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_fC8Y_XGkEe2TbaNWBpRZpQ")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification10? DataSetIdentification { get; init; }

    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    [IsoId("_fC8Y_3GkEe2TbaNWBpRZpQ")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmpntTp")]
    public SimpleValueList<DataSetCategory18Code> ComponentType { get; init; } = [];

    /// <summary>
    /// Identifies the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_fC8ZAXGkEe2TbaNWBpRZpQ")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; }

    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_fC9nEHGkEe2TbaNWBpRZpQ")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; }

    /// <summary>
    /// Contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_fC9nEnGkEe2TbaNWBpRZpQ")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_fC9nFHGkEe2TbaNWBpRZpQ")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType34? ProtectedDelegationProof { get; init; }

    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_fC9nFnGkEe2TbaNWBpRZpQ")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; }

    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_fC9nGHGkEe2TbaNWBpRZpQ")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public SimpleValueList<TerminalManagementAdditionalProcess1Code> AdditionalProcess { get; init; } =
        [];

    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_fC9nGnGkEe2TbaNWBpRZpQ")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry3? ReTry { get; init; }

    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_fC9nHHGkEe2TbaNWBpRZpQ")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming5? TimeCondition { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_fC9nHnGkEe2TbaNWBpRZpQ")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_fC9nIHGkEe2TbaNWBpRZpQ")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    public SimpleValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = [];

    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_fC9nInGkEe2TbaNWBpRZpQ")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ValueList<ErrorAction5> ErrorAction { get; init; } = [];

    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    [IsoId("_fC9nJHGkEe2TbaNWBpRZpQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax3000Binary> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_fC9nJnGkEe2TbaNWBpRZpQ")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = [];

    /// <summary>
    /// Information related to a device request of the POI.
    /// </summary>
    [IsoId("_fC9nKHGkEe2TbaNWBpRZpQ")]
    [DisplayName("Device Request")]
    [IsoXmlTag("DvcReq")]
    public DeviceRequest6? DeviceRequest { get; init; }
}
