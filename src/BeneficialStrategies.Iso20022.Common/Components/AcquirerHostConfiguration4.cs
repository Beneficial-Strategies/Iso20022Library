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
/// Acquirer configuration parameters for a host.
/// </summary>
[IsoId("_A4Mg8bDFEeamYaqfhG1ZuA")]
[DisplayName("Acquirer Host Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcquirerHostConfiguration4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcquirerHostConfiguration4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcquirerHostConfiguration4( System.String reqHostIdentification )
    {
        HostIdentification = reqHostIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_BCpdcbDFEeamYaqfhG1ZuA")]
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
    /// Types of message to sent to this host.
    /// </summary>
    [IsoId("_BCqEgLDFEeamYaqfhG1ZuA")]
    [DisplayName("Message To Send")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgToSnd")]
    #endif
    [IsoXmlTag("MsgToSnd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageFunction12Code? MessageToSend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageFunction12Code? MessageToSend { get; init; } 
    #else
    public MessageFunction12Code? MessageToSend { get; set; } 
    #endif
    
    
    #nullable disable
    
}
