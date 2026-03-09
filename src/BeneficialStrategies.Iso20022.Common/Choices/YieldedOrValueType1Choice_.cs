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
    [KnownType(typeof(YieldedOrValueType1Choice.Yielded))]
    [KnownType(typeof(YieldedOrValueType1Choice.ValueType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(YieldedOrValueType1Choice.Yielded),nameof(YieldedOrValueType1Choice.Yielded))]
    [JsonDerivedType(typeof(YieldedOrValueType1Choice.ValueType),nameof(YieldedOrValueType1Choice.ValueType))]
    #endif
    [IsoId("_RdBVptp-Ed-ak6NoX_4Aeg_510883553")]
    [DisplayName("Yielded Or Value Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record YieldedOrValueType1Choice_
    #else
    public abstract partial class YieldedOrValueType1Choice_
    #endif
    {
    }
}
