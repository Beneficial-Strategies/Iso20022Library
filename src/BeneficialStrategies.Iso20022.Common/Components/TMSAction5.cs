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
[IsoId("_NZSNIY31EeWYyJ6P6VfQMg")]
[DisplayName("TMS Action")]
public partial record TMSAction5
{
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_NlgrQY31EeWYyJ6P6VfQMg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction2Code Type { get; init; } 
    
    /// <summary>
    /// Host access information.
    /// </summary>
    [IsoId("_NlgrQ431EeWYyJ6P6VfQMg")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters5? RemoteAccess { get; init; } 
    
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    [IsoId("_NlgrRY31EeWYyJ6P6VfQMg")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification71? TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    [IsoId("_NlgrR431EeWYyJ6P6VfQMg")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TMSProtocol { get; init; } 
    
    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_NlgrSY31EeWYyJ6P6VfQMg")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TMSProtocolVersion { get; init; } 
    
    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_NlgrS431EeWYyJ6P6VfQMg")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification6? DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    [IsoId("_NlgrTY31EeWYyJ6P6VfQMg")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmpntTp")]
    public DataSetCategory9Code? ComponentType { get; init; } 
    
    /// <summary>
    /// Identification of the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_NlgrT431EeWYyJ6P6VfQMg")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    
    /// <summary>
    /// Definition of the delegation scope, for instance inside the payment application parameters the range of application profiles, the RID (Registered application provider Identification).
    /// </summary>
    [IsoId("_NlgrUY31EeWYyJ6P6VfQMg")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    
    /// <summary>
    /// Proof of delegation to be verified by the POI, when performing the delegated actions.
    /// </summary>
    [IsoId("_NlgrU431EeWYyJ6P6VfQMg")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; } 
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_NlgrVY31EeWYyJ6P6VfQMg")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType12? ProtectedDelegationProof { get; init; } 
    
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_NlgrV431EeWYyJ6P6VfQMg")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    
    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_NlgrWY31EeWYyJ6P6VfQMg")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; } 
    
    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_NlgrW431EeWYyJ6P6VfQMg")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; } 
    
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_NlgrXY31EeWYyJ6P6VfQMg")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming3? TimeCondition { get; init; } 
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_NlgrX431EeWYyJ6P6VfQMg")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; } 
    
    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_NlgrYY31EeWYyJ6P6VfQMg")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? KeyEnciphermentCertificate { get; init; } 
    
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_NlgrY431EeWYyJ6P6VfQMg")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ErrorAction2? ErrorAction { get; init; } 
    
    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    [IsoId("_NlgrZY31EeWYyJ6P6VfQMg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
