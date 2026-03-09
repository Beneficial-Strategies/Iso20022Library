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
[IsoId("_LYnu0H1DEeCF8NjrBemJWQ_436596133")]
[DisplayName("Host Communication Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HostCommunicationParameter1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HostCommunicationParameter1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HostCommunicationParameter1( System.String reqHostIdentification )
    {
        HostIdentification = reqHostIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_LYnu0X1DEeCF8NjrBemJWQ_-1252337300")]
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
    [IsoId("_LYnu0n1DEeCF8NjrBemJWQ_-813704955")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters1? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters1? Address { get; init; } 
    #else
    public NetworkParameters1? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_LYnu031DEeCF8NjrBemJWQ_-209462385")]
    [DisplayName("Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Key")]
    #endif
    [IsoXmlTag("Key")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey1? Key { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey1? Key { get; init; } 
    #else
    public CryptographicKey1? Key { get; set; } 
    #endif
    
    
    #nullable disable
    
}
