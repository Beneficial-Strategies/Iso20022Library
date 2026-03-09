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
[IsoId("_dnyOAGpbEeS4r8z7dKyh1g")]
[DisplayName("TMS Protocol Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSProtocolParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSProtocolParameters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSProtocolParameters1( GenericIdentification71 reqTerminalManagerIdentification,System.String reqVersion )
    {
        TerminalManagerIdentification = reqTerminalManagerIdentification;
        Version = reqVersion;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager.
    /// </summary>
    [IsoId("_4uhx0GpbEeS4r8z7dKyh1g")]
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
    [IsoId("_CoSFMGpcEeS4r8z7dKyh1g")]
    [DisplayName("Maintenance Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncSvc")]
    #endif
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory5Code> MaintenanceService { get; init; } = new SimpleValueList<DataSetCategory5Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CoSFMGpcEeS4r8z7dKyh1g
    
    /// <summary>
    /// Version of the TMS protocol parameters.
    /// </summary>
    [IsoId("_uWz6oGpcEeS4r8z7dKyh1g")]
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
    [IsoId("_zmYW0GpcEeS4r8z7dKyh1g")]
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
    /// Addresses of the terminal manager host.
    /// </summary>
    [IsoId("_wteusGpqEeSMqvBfBY1c9A")]
    [DisplayName("Host Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstAdr")]
    #endif
    [IsoXmlTag("HstAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters3? HostAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters3? HostAddress { get; init; } 
    #else
    public NetworkParameters3? HostAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic key used to communicate with the terminal manager host.
    /// </summary>
    [IsoId("_Iby-IGprEeSMqvBfBY1c9A")]
    [DisplayName("Host Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstKey")]
    #endif
    [IsoXmlTag("HstKey")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KEKIdentifier2? HostKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KEKIdentifier2? HostKey { get; init; } 
    #else
    public KEKIdentifier2? HostKey { get; set; } 
    #endif
    
    /// <summary>
    /// New identification of the POI for the terminal manager.
    /// </summary>
    [IsoId("_OnH38GprEeSMqvBfBY1c9A")]
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
    [IsoId("_UK63sGprEeSMqvBfBY1c9A")]
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
    [IsoId("_nSjP4GprEeSMqvBfBY1c9A")]
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
    
    
    #nullable disable
    
}
