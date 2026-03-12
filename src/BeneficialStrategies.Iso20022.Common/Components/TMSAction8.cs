// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
[IsoId("_DNBOIQ00EeqUVL7sB4m7NA")]
[DisplayName("TMS Action")]
public partial record TMSAction8
{
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_DYsSoQ00EeqUVL7sB4m7NA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction4Code Type { get; init; } 
    
    /// <summary>
    /// Host access information.
    /// </summary>
    [IsoId("_DYsSow00EeqUVL7sB4m7NA")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters7? RemoteAccess { get; init; } 
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_DYsSpQ00EeqUVL7sB4m7NA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public KEKIdentifier5? Key { get; init; } 
    
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    [IsoId("_DYsSpw00EeqUVL7sB4m7NA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification176? TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    [IsoId("_DYsSqQ00EeqUVL7sB4m7NA")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TMSProtocol { get; init; } 
    
    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_DYsSqw00EeqUVL7sB4m7NA")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TMSProtocolVersion { get; init; } 
    
    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_DYsSrQ00EeqUVL7sB4m7NA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification8? DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    [IsoId("_DYsSrw00EeqUVL7sB4m7NA")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmpntTp")]
    public DataSetCategory14Code? ComponentType { get; init; } 
    
    /// <summary>
    /// Identification of the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_DYsSsQ00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_DYsSsw00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    
    /// <summary>
    /// This element contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_DYsStQ00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; } 
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_DYsStw00EeqUVL7sB4m7NA")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType23? ProtectedDelegationProof { get; init; } 
    
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_DYsSuQ00EeqUVL7sB4m7NA")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    
    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_DYsSuw00EeqUVL7sB4m7NA")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; } 
    
    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_DYsSvQ00EeqUVL7sB4m7NA")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; } 
    
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_DYsSvw00EeqUVL7sB4m7NA")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming3? TimeCondition { get; init; } 
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_DYsSwQ00EeqUVL7sB4m7NA")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; } 
    
    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_DYsSww00EeqUVL7sB4m7NA")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? KeyEnciphermentCertificate { get; init; } 
    
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_DYsSxQ00EeqUVL7sB4m7NA")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ErrorAction4? ErrorAction { get; init; } 
    
    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    [IsoId("_DYsSxw00EeqUVL7sB4m7NA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_DYsSyQ00EeqUVL7sB4m7NA")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public MessageItemCondition1? MessageItem { get; init; } 
    
    
    #nullable disable
    
}
