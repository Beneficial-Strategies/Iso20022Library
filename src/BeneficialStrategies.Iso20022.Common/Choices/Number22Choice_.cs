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
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number22Choice.Short))]
    [KnownType(typeof(Number22Choice.Long))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Number22Choice.Short),nameof(Number22Choice.Short))]
    [JsonDerivedType(typeof(Number22Choice.Long),nameof(Number22Choice.Long))]
    #endif
    [IsoId("_GgDHITnEEeWV5sr121Fc8A")]
    [DisplayName("Number 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Number22Choice_
    #else
    public abstract partial class Number22Choice_
    #endif
    {
    }
}
