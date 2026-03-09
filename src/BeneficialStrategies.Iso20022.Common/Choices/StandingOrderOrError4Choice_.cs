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
    [KnownType(typeof(StandingOrderOrError4Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrError4Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StandingOrderOrError4Choice.StandingOrder),nameof(StandingOrderOrError4Choice.StandingOrder))]
    [JsonDerivedType(typeof(StandingOrderOrError4Choice.BusinessError),nameof(StandingOrderOrError4Choice.BusinessError))]
    #endif
    [IsoId("_kIiN9RbvEeOy-PlRuFSUzQ")]
    [DisplayName("Standing Order Or Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingOrderOrError4Choice_
    #else
    public abstract partial class StandingOrderOrError4Choice_
    #endif
    {
    }
}
