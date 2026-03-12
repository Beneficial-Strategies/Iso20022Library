// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Contains information describing the fulfilment information delivery methods.
    /// </summary>
    [KnownType(typeof(RetrievalDeliveryMethod1Choice.RequestedMethod))]
    [KnownType(typeof(RetrievalDeliveryMethod1Choice.EstablishedMethod))]
    [KnownType(typeof(RetrievalDeliveryMethod1Choice.ActualDeliveryMethod))]
    [JsonDerivedType(typeof(RetrievalDeliveryMethod1Choice.RequestedMethod),nameof(RetrievalDeliveryMethod1Choice.RequestedMethod))]
    [JsonDerivedType(typeof(RetrievalDeliveryMethod1Choice.EstablishedMethod),nameof(RetrievalDeliveryMethod1Choice.EstablishedMethod))]
    [JsonDerivedType(typeof(RetrievalDeliveryMethod1Choice.ActualDeliveryMethod),nameof(RetrievalDeliveryMethod1Choice.ActualDeliveryMethod))]
    [IsoId("_wPBNlewhEeiMkKo2clXHdQ")]
    [DisplayName("Retrieval Delivery Method 1 Choice")]
    public abstract partial record RetrievalDeliveryMethod1Choice_
    {
    }
}
