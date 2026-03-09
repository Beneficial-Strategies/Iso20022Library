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
    /// Contains information describing the fulfilment information delivery methods.
    /// </summary>
    [KnownType(typeof(RetrievalDeliveryMethod1Choice.RequestedMethod))]
    [KnownType(typeof(RetrievalDeliveryMethod1Choice.EstablishedMethod))]
    [KnownType(typeof(RetrievalDeliveryMethod1Choice.ActualDeliveryMethod))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RetrievalDeliveryMethod1Choice.RequestedMethod),nameof(RetrievalDeliveryMethod1Choice.RequestedMethod))]
    [JsonDerivedType(typeof(RetrievalDeliveryMethod1Choice.EstablishedMethod),nameof(RetrievalDeliveryMethod1Choice.EstablishedMethod))]
    [JsonDerivedType(typeof(RetrievalDeliveryMethod1Choice.ActualDeliveryMethod),nameof(RetrievalDeliveryMethod1Choice.ActualDeliveryMethod))]
    #endif
    [IsoId("_wPBNlewhEeiMkKo2clXHdQ")]
    [DisplayName("Retrieval Delivery Method 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RetrievalDeliveryMethod1Choice_
    #else
    public abstract partial class RetrievalDeliveryMethod1Choice_
    #endif
    {
    }
}
