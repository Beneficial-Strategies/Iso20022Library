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
    /// Characteristics of one or all standing orders set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(StandingOrderOrAll1Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrAll1Choice.AllStandingOrders))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StandingOrderOrAll1Choice.StandingOrder),nameof(StandingOrderOrAll1Choice.StandingOrder))]
    [JsonDerivedType(typeof(StandingOrderOrAll1Choice.AllStandingOrders),nameof(StandingOrderOrAll1Choice.AllStandingOrders))]
    #endif
    [IsoId("_79r04KMgEeCJ6YNENx4h-w_1637966113")]
    [DisplayName("Standing Order Or All 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingOrderOrAll1Choice_
    #else
    public abstract partial class StandingOrderOrAll1Choice_
    #endif
    {
    }
}
