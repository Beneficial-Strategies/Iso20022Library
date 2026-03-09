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
/// Configuration parameters to communicate with a host.
/// </summary>
[IsoId("_-yW3QQufEeqw5uEXxQ9H4g")]
[DisplayName("Host Communication Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HostCommunicationParameter6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HostCommunicationParameter6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HostCommunicationParameter6( TerminalManagementAction3Code reqActionType,System.String reqHostIdentification )
    {
        ActionType = reqActionType;
        HostIdentification = reqHostIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_-9KZEQufEeqw5uEXxQ9H4g")]
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
    /// Identification of the host.
    /// </summary>
    [IsoId("_-9KZEwufEeqw5uEXxQ9H4g")]
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
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_-9KZFQufEeqw5uEXxQ9H4g")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters7? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters7? Address { get; init; } 
    #else
    public NetworkParameters7? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_-9KZFwufEeqw5uEXxQ9H4g")]
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
    /// Access information to reach an intermediate network service provider.
    /// </summary>
    [IsoId("_-9KZGQufEeqw5uEXxQ9H4g")]
    [DisplayName("Network Service Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtwkSvcPrvdr")]
    #endif
    [IsoXmlTag("NtwkSvcPrvdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters7? NetworkServiceProvider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters7? NetworkServiceProvider { get; init; } 
    #else
    public NetworkParameters7? NetworkServiceProvider { get; set; } 
    #endif
    
    /// <summary>
    /// Physical Interface where the host is connected.
    /// </summary>
    [IsoId("_-9KZGwufEeqw5uEXxQ9H4g")]
    [DisplayName("Physical Interface")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysIntrfc")]
    #endif
    [IsoXmlTag("PhysIntrfc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    #else
    public PhysicalInterfaceParameter1? PhysicalInterface { get; set; } 
    #endif
    
    
    #nullable disable
    
}
