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
    /// Choice of value type.
    /// </summary>
    [KnownType(typeof(YieldedOrValueType2Choice.Yielded))]
    [KnownType(typeof(YieldedOrValueType2Choice.ValueType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(YieldedOrValueType2Choice.Yielded),nameof(YieldedOrValueType2Choice.Yielded))]
    [JsonDerivedType(typeof(YieldedOrValueType2Choice.ValueType),nameof(YieldedOrValueType2Choice.ValueType))]
    #endif
    [IsoId("_UyctRQycEeuG8M5giQ2e0w")]
    [DisplayName("Yielded Or Value Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record YieldedOrValueType2Choice_
    #else
    public abstract partial class YieldedOrValueType2Choice_
    #endif
    {
    }
}
