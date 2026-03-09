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
    /// Choice between risk management limit details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(LimitOrError4Choice.Limit))]
    [KnownType(typeof(LimitOrError4Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LimitOrError4Choice.Limit),nameof(LimitOrError4Choice.Limit))]
    [JsonDerivedType(typeof(LimitOrError4Choice.BusinessError),nameof(LimitOrError4Choice.BusinessError))]
    #endif
    [IsoId("_RYTBoXhdEeidzqjNEfehPg")]
    [DisplayName("Limit Or Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LimitOrError4Choice_
    #else
    public abstract partial class LimitOrError4Choice_
    #endif
    {
    }
}
