// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Describes the multimodal or the individual transport of goods.
    /// </summary>
    [KnownType(typeof(TransportMeans2Choice.IndividualTransport))]
    [KnownType(typeof(TransportMeans2Choice.MultimodalTransport))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransportMeans2Choice.IndividualTransport),nameof(TransportMeans2Choice.IndividualTransport))]
    [JsonDerivedType(typeof(TransportMeans2Choice.MultimodalTransport),nameof(TransportMeans2Choice.MultimodalTransport))]
    #endif
    [IsoId("_U7oxkdp-Ed-ak6NoX_4Aeg_-761772709")]
    [DisplayName("Transport Means 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransportMeans2Choice_
    #else
    public abstract partial class TransportMeans2Choice_
    #endif
    {
    }
}
