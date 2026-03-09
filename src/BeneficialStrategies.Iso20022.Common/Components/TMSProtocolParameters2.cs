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
/// Configuration parameters of the TMS protocol between a POI and a terminal manager.
/// </summary>
[IsoId("_XdvNQY34EeWRwov1g9WL_A")]
[DisplayName("TMS Protocol Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSProtocolParameters2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSProtocolParameters2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSProtocolParameters2( TerminalManagementAction3Code reqActionType,GenericIdentification71 reqTerminalManagerIdentification,System.String reqVersion,System.String reqHostIdentification )
    {
        ActionType = reqActionType;
        TerminalManagerIdentification = reqTerminalManagerIdentification;
        Version = reqVersion;
        HostIdentification = reqHostIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_041ZUI34EeWRwov1g9WL_A")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction3Code ActionType { get; init; } 
    #else
    public TerminalManagementAction3Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager.
    /// </summary>
    [IsoId("_Xp9rYY34EeWRwov1g9WL_A")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification71 TerminalManagerIdentification { get; init; } 
    #else
    public GenericIdentification71 TerminalManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance services provided by the terminal manager.
    /// </summary>
    [IsoId("_Xp9rY434EeWRwov1g9WL_A")]
    [DisplayName("Maintenance Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncSvc")]
    #endif
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory10Code> MaintenanceService { get; init; } = new SimpleValueList<DataSetCategory10Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Xp9rY434EeWRwov1g9WL_A
    
    /// <summary>
    /// Version of the TMS protocol parameters.
    /// </summary>
    [IsoId("_Xp9rZY34EeWRwov1g9WL_A")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Version { get; init; } 
    #else
    public System.String Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of applications which may be managed by the TM, partially or globally.
    /// </summary>
    [IsoId("_Xp9rZ434EeWRwov1g9WL_A")]
    [DisplayName("Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplId")]
    #endif
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicationIdentification { get; init; } 
    #else
    public System.String? ApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal manager host.
    /// </summary>
    [IsoId("_rbv-YI35EeWRwov1g9WL_A")]
    [DisplayName("Host Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstId")]
    #endif
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text HostIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String HostIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HostIdentification { get; init; } 
    #else
    public System.String HostIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New identification of the POI for the terminal manager.
    /// </summary>
    [IsoId("_Xp9rbY34EeWRwov1g9WL_A")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIIdentification { get; init; } 
    #else
    public System.String? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New identification of the initiating party to set in TMS messages with this terminal manager.
    /// </summary>
    [IsoId("_Xp9rb434EeWRwov1g9WL_A")]
    [DisplayName("Initiating Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPtyId")]
    #endif
    [IsoXmlTag("InitgPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InitiatingPartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InitiatingPartyIdentification { get; init; } 
    #else
    public System.String? InitiatingPartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New identification of the recipient party to set in TMS messages with this terminal manager.
    /// </summary>
    [IsoId("_Xp9rcY34EeWRwov1g9WL_A")]
    [DisplayName("Recipient Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptPtyId")]
    #endif
    [IsoXmlTag("RcptPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RecipientPartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RecipientPartyIdentification { get; init; } 
    #else
    public System.String? RecipientPartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [IsoId("_22s-wI35EeWRwov1g9WL_A")]
    [DisplayName("File Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileTrf")]
    #endif
    [IsoXmlTag("FileTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? FileTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FileTransfer { get; init; } 
    #else
    public System.String? FileTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
