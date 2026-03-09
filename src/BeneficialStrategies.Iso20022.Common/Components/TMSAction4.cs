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
[IsoId("_7FMksWpPEeSR-ZWLvO-1dg")]
[DisplayName("TMS Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSAction4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSAction4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSAction4( TerminalManagementAction1Code reqType,TerminalManagementActionTrigger1Code reqTrigger )
    {
        Type = reqType;
        Trigger = reqTrigger;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_7Rt9wWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction1Code Type { get; init; } 
    #else
    public TerminalManagementAction1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Host access information.
    /// </summary>
    [IsoId("_GKDccGpUEeSR-ZWLvO-1dg")]
    [DisplayName("Remote Access")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmotAccs")]
    #endif
    [IsoXmlTag("RmotAccs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters3? RemoteAccess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters3? RemoteAccess { get; init; } 
    #else
    public NetworkParameters3? RemoteAccess { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    [IsoId("_MpSCUGpXEeSR-ZWLvO-1dg")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification71? TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification71? TerminalManagerIdentification { get; init; } 
    #else
    public GenericIdentification71? TerminalManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    [IsoId("_PYYF0GpXEeSR-ZWLvO-1dg")]
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
    [IsoId("_RCeQIGpXEeSR-ZWLvO-1dg")]
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
    [IsoId("_7Rt9xWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetIdentification4? DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification4? DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification4? DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    [IsoId("_wTMhEGpXEeSR-ZWLvO-1dg")]
    [DisplayName("Component Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpntTp")]
    #endif
    [IsoXmlTag("CmpntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetCategory4Code? ComponentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetCategory4Code? ComponentType { get; init; } 
    #else
    public DataSetCategory4Code? ComponentType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("_6uR_4GpXEeSR-ZWLvO-1dg")]
    [DisplayName("Parameters Subset Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamsSubsetId")]
    #endif
    [IsoXmlTag("ParamsSubsetId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ParametersSubsetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ParametersSubsetIdentification { get; init; } 
    #else
    public System.String? ParametersSubsetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of the subset of application parameters, for instance the range of application profiles, the RID (registered application provider identification).
    /// </summary>
    [IsoId("_DzkwcGpYEeSR-ZWLvO-1dg")]
    [DisplayName("Parameters Subset Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamsSubsetDef")]
    #endif
    [IsoXmlTag("ParamsSubsetDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? ParametersSubsetDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ParametersSubsetDefinition { get; init; } 
    #else
    public System.Byte[]? ParametersSubsetDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Proof of delegation to be verified by the POI, when performing the delegated actions.
    /// </summary>
    [IsoId("_MsNlEGpYEeSR-ZWLvO-1dg")]
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
    [IsoId("_dFybkGpYEeSR-ZWLvO-1dg")]
    [DisplayName("Protected Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdDlgtnProof")]
    #endif
    [IsoXmlTag("PrtctdDlgtnProof")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType12? ProtectedDelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType12? ProtectedDelegationProof { get; init; } 
    #else
    public ContentInformationType12? ProtectedDelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_7Rt9x2pPEeSR-ZWLvO-1dg")]
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
    [IsoId("_7Rt9yWpPEeSR-ZWLvO-1dg")]
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
    [IsoId("_7Rt9y2pPEeSR-ZWLvO-1dg")]
    [DisplayName("Re Try")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReTry")]
    #endif
    [IsoXmlTag("ReTry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessRetry2? ReTry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessRetry2? ReTry { get; init; } 
    #else
    public ProcessRetry2? ReTry { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_7Rt9zWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Time Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmCond")]
    #endif
    [IsoXmlTag("TmCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessTiming3? TimeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessTiming3? TimeCondition { get; init; } 
    #else
    public ProcessTiming3? TimeCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_7Rt9z2pPEeSR-ZWLvO-1dg")]
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
    [IsoId("_7Rt90WpPEeSR-ZWLvO-1dg")]
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
    [IsoId("_7Rt902pPEeSR-ZWLvO-1dg")]
    [DisplayName("Error Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrActn")]
    #endif
    [IsoXmlTag("ErrActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ErrorAction2? ErrorAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ErrorAction2? ErrorAction { get; init; } 
    #else
    public ErrorAction2? ErrorAction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    [IsoId("_n_nr4GpYEeSR-ZWLvO-1dg")]
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
    
    
    #nullable disable
    
}
