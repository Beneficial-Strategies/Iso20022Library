// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// TMS Action13.
/// </summary>
[IsoId("_c9SiUaEtEe-MRKYsaX6JDg")]
[DisplayName("TMS Action13")]
public partial record TMSAction13
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax3000Binary> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Additional Process.
    /// </summary>
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public ValueList<TerminalManagementAdditionalProcess1Code> AdditionalProcess { get; init; } = [];

    /// <summary>
    /// Component Type.
    /// </summary>
    [DisplayName("Component Type")]
    [IsoXmlTag("CmpntTp")]
    public ValueList<DataSetCategory20Code> ComponentType { get; init; } = [];

    /// <summary>
    /// Data Set Identification.
    /// </summary>
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification11? DataSetIdentification { get; init; } 

    /// <summary>
    /// Delegation Proof.
    /// </summary>
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    public IsoMax5000Binary? DelegationProof { get; init; } 

    /// <summary>
    /// Delegation Scope Definition.
    /// </summary>
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 

    /// <summary>
    /// Delegation Scope Identification.
    /// </summary>
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 

    /// <summary>
    /// Device Request.
    /// </summary>
    [DisplayName("Device Request")]
    [IsoXmlTag("DvcReq")]
    public DeviceRequest8? DeviceRequest { get; init; } 

    /// <summary>
    /// Error Action.
    /// </summary>
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ValueList<ErrorAction5> ErrorAction { get; init; } = [];

    /// <summary>
    /// Key.
    /// </summary>
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<KEKIdentifier5> Key { get; init; } = [];

    /// <summary>
    /// Key Encipherment Certificate.
    /// </summary>
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    public ValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = [];

    /// <summary>
    /// Message Item.
    /// </summary>
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = [];

    /// <summary>
    /// Protected Delegation Proof.
    /// </summary>
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType39? ProtectedDelegationProof { get; init; } 

    /// <summary>
    /// Remote Access.
    /// </summary>
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters7? RemoteAccess { get; init; } 

    /// <summary>
    /// Re Try.
    /// </summary>
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry3? ReTry { get; init; } 

    /// <summary>
    /// Terminal Manager Identification.
    /// </summary>
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification176? TerminalManagerIdentification { get; init; } 

    /// <summary>
    /// Time Condition.
    /// </summary>
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming5? TimeCondition { get; init; } 

    /// <summary>
    /// TM Challenge.
    /// </summary>
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    public IsoMax140Binary? TMChallenge { get; init; } 

    /// <summary>
    /// TMS Protocol.
    /// </summary>
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    public IsoMax35Text? TMSProtocol { get; init; } 

    /// <summary>
    /// TMS Protocol Version.
    /// </summary>
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    public IsoMax35Text? TMSProtocolVersion { get; init; } 

    /// <summary>
    /// Trigger.
    /// </summary>
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction5Code Type { get; init; } 

    
    #nullable disable
    
}
