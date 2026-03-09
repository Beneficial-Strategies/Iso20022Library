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
/// Describes the multimodal or the individual transport of goods.
/// </summary>
[IsoId("_2vnszzckEeSaC-PiOaz_KQ")]
[DisplayName("Transport Means")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportMeans6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportMeans6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportMeans6( SingleTransport8 reqIndividualTransport )
    {
        IndividualTransport = reqIndividualTransport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_3FpAETckEeSaC-PiOaz_KQ")]
    [DisplayName("Individual Transport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvTrnsprt")]
    #endif
    [IsoXmlTag("IndvTrnsprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SingleTransport8 IndividualTransport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SingleTransport8 IndividualTransport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SingleTransport8 IndividualTransport { get; init; } 
    #else
    public SingleTransport8 IndividualTransport { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the different movements and places and their role in a multimodal conveyance of goods.
    /// </summary>
    [IsoId("_3FpAEzckEeSaC-PiOaz_KQ")]
    [DisplayName("Multimodal Transport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MltmdlTrnsprt")]
    #endif
    [IsoXmlTag("MltmdlTrnsprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MultimodalTransport3? MultimodalTransport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MultimodalTransport3? MultimodalTransport { get; init; } 
    #else
    public MultimodalTransport3? MultimodalTransport { get; set; } 
    #endif
    
    
    #nullable disable
    
}
