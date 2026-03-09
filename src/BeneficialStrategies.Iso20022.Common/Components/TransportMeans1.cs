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
[IsoId("_Stoo-Np-Ed-ak6NoX_4Aeg_165416872")]
[DisplayName("Transport Means")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportMeans1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportMeans1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportMeans1( SingleTransport4 reqIndividualTransport )
    {
        IndividualTransport = reqIndividualTransport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_Stoo-dp-Ed-ak6NoX_4Aeg_165417133")]
    [DisplayName("Individual Transport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvTrnsprt")]
    #endif
    [IsoXmlTag("IndvTrnsprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SingleTransport4 IndividualTransport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SingleTransport4 IndividualTransport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SingleTransport4 IndividualTransport { get; init; } 
    #else
    public SingleTransport4 IndividualTransport { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the different movements and places and their role in a multimodal conveyance of goods.
    /// </summary>
    [IsoId("_Stoo-tp-Ed-ak6NoX_4Aeg_165417254")]
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
