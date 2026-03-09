// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
[IsoId("_YR3KUU6nEeyGi9JAv6wq7Q")]
[DisplayName("TMS Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSAction10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSAction10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSAction10( TerminalManagementAction5Code reqType,TerminalManagementActionTrigger1Code reqTrigger )
    {
        Type = reqType;
        Trigger = reqTrigger;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_YYHjUU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction5Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction5Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction5Code Type { get; init; } 
    #else
    public TerminalManagementAction5Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Host access information.
    /// </summary>
    [IsoId("_YYHjU06nEeyGi9JAv6wq7Q")]
    [DisplayName("Remote Access")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmotAccs")]
    #endif
    [IsoXmlTag("RmotAccs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters7? RemoteAccess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters7? RemoteAccess { get; init; } 
    #else
    public NetworkParameters7? RemoteAccess { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_YYHjVU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Key")]
    #endif
    [IsoXmlTag("Key")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KEKIdentifier5? Key { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KEKIdentifier5? Key { get; init; } 
    #else
    public KEKIdentifier5? Key { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    [IsoId("_YYHjV06nEeyGi9JAv6wq7Q")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification176? TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176? TerminalManagerIdentification { get; init; } 
    #else
    public GenericIdentification176? TerminalManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    [IsoId("_YYHjWU6nEeyGi9JAv6wq7Q")]
    [DisplayName("TMS Protocol")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSPrtcol")]
    #endif
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TMSProtocol { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TMSProtocol { get; init; } 
    #else
    public System.String? TMSProtocol { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_YYHjW06nEeyGi9JAv6wq7Q")]
    [DisplayName("TMS Protocol Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSPrtcolVrsn")]
    #endif
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TMSProtocolVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TMSProtocolVersion { get; init; } 
    #else
    public System.String? TMSProtocolVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_YYHjXU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetIdentification9? DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification9? DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification9? DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    [IsoId("_YYHjX06nEeyGi9JAv6wq7Q")]
    [DisplayName("Component Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpntTp")]
    #endif
    [IsoXmlTag("CmpntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetCategory17Code? ComponentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetCategory17Code? ComponentType { get; init; } 
    #else
    public DataSetCategory17Code? ComponentType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_YYHjYU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Delegation Scope Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnScpId")]
    #endif
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DelegationScopeIdentification { get; init; } 
    #else
    public System.String? DelegationScopeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_YYHjY06nEeyGi9JAv6wq7Q")]
    [DisplayName("Delegation Scope Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnScpDef")]
    #endif
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DelegationScopeDefinition { get; init; } 
    #else
    public System.Byte[]? DelegationScopeDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// This element contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_YYHjZU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnProof")]
    #endif
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? DelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DelegationProof { get; init; } 
    #else
    public System.Byte[]? DelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_YYHjZ06nEeyGi9JAv6wq7Q")]
    [DisplayName("Protected Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdDlgtnProof")]
    #endif
    [IsoXmlTag("PrtctdDlgtnProof")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType30? ProtectedDelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType30? ProtectedDelegationProof { get; init; } 
    #else
    public ContentInformationType30? ProtectedDelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_YYHjaU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trggr")]
    #endif
    [IsoXmlTag("Trggr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementActionTrigger1Code Trigger { get; init; } 
    #else
    public TerminalManagementActionTrigger1Code Trigger { get; set; } 
    #endif
    
    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_YYHja06nEeyGi9JAv6wq7Q")]
    [DisplayName("Additional Process")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPrc")]
    #endif
    [IsoXmlTag("AddtlPrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; } 
    #else
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_YYHjbU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Re Try")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReTry")]
    #endif
    [IsoXmlTag("ReTry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessRetry3? ReTry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessRetry3? ReTry { get; init; } 
    #else
    public ProcessRetry3? ReTry { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_YYHjb06nEeyGi9JAv6wq7Q")]
    [DisplayName("Time Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmCond")]
    #endif
    [IsoXmlTag("TmCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessTiming5? TimeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessTiming5? TimeCondition { get; init; } 
    #else
    public ProcessTiming5? TimeCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_YYHjcU6nEeyGi9JAv6wq7Q")]
    [DisplayName("TM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMChllng")]
    #endif
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? TMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TMChallenge { get; init; } 
    #else
    public System.Byte[]? TMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_YYHjc06nEeyGi9JAv6wq7Q")]
    [DisplayName("Key Encipherment Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyNcphrmntCert")]
    #endif
    [IsoXmlTag("KeyNcphrmntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? KeyEnciphermentCertificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? KeyEnciphermentCertificate { get; init; } 
    #else
    public System.Byte[]? KeyEnciphermentCertificate { get; set; } 
    #endif
    
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_YYHjdU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Error Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrActn")]
    #endif
    [IsoXmlTag("ErrActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ErrorAction5? ErrorAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ErrorAction5? ErrorAction { get; init; } 
    #else
    public ErrorAction5? ErrorAction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    [IsoId("_YYHjd06nEeyGi9JAv6wq7Q")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AdditionalInformation { get; init; } 
    #else
    public System.Byte[]? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_YYHjeU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Message Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgItm")]
    #endif
    [IsoXmlTag("MsgItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageItemCondition1? MessageItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageItemCondition1? MessageItem { get; init; } 
    #else
    public MessageItemCondition1? MessageItem { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a device request of the POI.
    /// </summary>
    [IsoId("_YYHje06nEeyGi9JAv6wq7Q")]
    [DisplayName("Device Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvcReq")]
    #endif
    [IsoXmlTag("DvcReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceRequest5? DeviceRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceRequest5? DeviceRequest { get; init; } 
    #else
    public DeviceRequest5? DeviceRequest { get; set; } 
    #endif
    
    
    #nullable disable
    
}
