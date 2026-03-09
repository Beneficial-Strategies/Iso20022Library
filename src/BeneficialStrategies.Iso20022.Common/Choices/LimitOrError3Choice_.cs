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
    [KnownType(typeof(LimitOrError3Choice.Limit))]
    [KnownType(typeof(LimitOrError3Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LimitOrError3Choice.Limit),nameof(LimitOrError3Choice.Limit))]
    [JsonDerivedType(typeof(LimitOrError3Choice.BusinessError),nameof(LimitOrError3Choice.BusinessError))]
    #endif
    [IsoId("_RRErR5lhEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Or Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LimitOrError3Choice_
    #else
    public abstract partial class LimitOrError3Choice_
    #endif
    {
    }
}
