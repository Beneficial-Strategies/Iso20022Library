// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action to perform on a terminal management system.
/// </summary>
[IsoId("_AOesQbYFEfCUZfsQO4rYeA")]
[DisplayName("TMS Action14")]
public record TMSAction14
{
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction5Code Type { get; init; }

    /// <summary>
    /// Host access information.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-rmt")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmtAcs")]
    public NetworkParameters7? RemoteAccess { get; init; }

    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-key")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<CryptographicKey19> Key { get; init; } = [];

    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tmid")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TrmnlMgrId")]
    public GenericIdentification176? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tpro")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcl")]
    public IsoMax35Text? TMSProtocol { get; init; }

    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tpvr")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtclVrsn")]
    public IsoMax35Text? TMSProtocolVersion { get; init; }

    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dsid")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification11? DataSetIdentification { get; init; }

    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-cmpt")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmptTp")]
    public SimpleValueList<DataSetCategory20Code> ComponentType { get; init; } = [];

    /// <summary>
    /// Identifies the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dlsc")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScopeId")]
    public IsoMax35Text? DelegationScopeIdentification { get; init; }

    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dlsd")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScopeDfntn")]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; }

    /// <summary>
    /// Contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dlsp")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnPrf")]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-prdp")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnPrf")]
    public ContentInformationType39? ProtectedDelegationProof { get; init; }

    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-trgr")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trgr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; }

    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-adpr")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrcs")]
    public SimpleValueList<TerminalManagementAdditionalProcess1Code> AdditionalProcess { get; init; } = [];

    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-rtry")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry3? ReTry { get; init; }

    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tmcd")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming5? TimeCondition { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tmch")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-kecr")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcrptnCert")]
    public SimpleValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = [];

    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-erac")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ValueList<ErrorAction5> ErrorAction { get; init; } = [];

    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-adif")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax3000Binary> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-msgi")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = [];

    /// <summary>
    /// Information related to a device request of the POI.
    /// </summary>
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dvrq")]
    [DisplayName("Device Request")]
    [IsoXmlTag("DvcRq")]
    public DeviceRequest9? DeviceRequest { get; init; }
}
