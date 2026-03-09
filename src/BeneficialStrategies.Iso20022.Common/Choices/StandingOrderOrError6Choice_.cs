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
    /// Choice between the standing order details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError6Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrError6Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StandingOrderOrError6Choice.StandingOrder),nameof(StandingOrderOrError6Choice.StandingOrder))]
    [JsonDerivedType(typeof(StandingOrderOrError6Choice.BusinessError),nameof(StandingOrderOrError6Choice.BusinessError))]
    #endif
    [IsoId("_Cj8r6W4-EeiU9cctagi5ow")]
    [DisplayName("Standing Order Or Error 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingOrderOrError6Choice_
    #else
    public abstract partial class StandingOrderOrError6Choice_
    #endif
    {
    }
}
