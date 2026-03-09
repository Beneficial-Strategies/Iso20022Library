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
[IsoId("_K8dXQH1DEeCF8NjrBemJWQ_-885383868")]
[DisplayName("Acquirer Host Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcquirerHostConfiguration1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcquirerHostConfiguration1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcquirerHostConfiguration1( System.String reqHostIdentification )
    {
        HostIdentification = reqHostIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a host.
    /// </summary>
    [IsoId("_K8nIQH1DEeCF8NjrBemJWQ_-2088821006")]
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
    [IsoId("_K8nIQX1DEeCF8NjrBemJWQ_-2022756489")]
    [DisplayName("Message To Send")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgToSnd")]
    #endif
    [IsoXmlTag("MsgToSnd")]
    public SimpleValueList<MessageFunction3Code> MessageToSend { get; init; } = new SimpleValueList<MessageFunction3Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _K8nIQX1DEeCF8NjrBemJWQ_-2022756489
    
    
    #nullable disable
    
}
