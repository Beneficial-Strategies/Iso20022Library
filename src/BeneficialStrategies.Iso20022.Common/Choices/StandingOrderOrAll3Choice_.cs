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
    [KnownType(typeof(StandingOrderOrAll3Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrAll3Choice.AllStandingOrders))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StandingOrderOrAll3Choice.StandingOrder),nameof(StandingOrderOrAll3Choice.StandingOrder))]
    [JsonDerivedType(typeof(StandingOrderOrAll3Choice.AllStandingOrders),nameof(StandingOrderOrAll3Choice.AllStandingOrders))]
    #endif
    [IsoId("_ewVxkdcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Or All 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingOrderOrAll3Choice_
    #else
    public abstract partial class StandingOrderOrAll3Choice_
    #endif
    {
    }
}
