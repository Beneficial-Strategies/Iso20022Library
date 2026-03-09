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
    [KnownType(typeof(TransportMeans1Choice.IndividualTransport))]
    [KnownType(typeof(TransportMeans1Choice.MultimodalTransport))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransportMeans1Choice.IndividualTransport),nameof(TransportMeans1Choice.IndividualTransport))]
    [JsonDerivedType(typeof(TransportMeans1Choice.MultimodalTransport),nameof(TransportMeans1Choice.MultimodalTransport))]
    #endif
    [IsoId("_U7oxlNp-Ed-ak6NoX_4Aeg_1112735251")]
    [DisplayName("Transport Means 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransportMeans1Choice_
    #else
    public abstract partial class TransportMeans1Choice_
    #endif
    {
    }
}
