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
    /// Choice between a code and or a data source scheme to determine the rate.
    /// </summary>
    [KnownType(typeof(RateType35Choice.Code))]
    [KnownType(typeof(RateType35Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateType35Choice.Code),nameof(RateType35Choice.Code))]
    [JsonDerivedType(typeof(RateType35Choice.Proprietary),nameof(RateType35Choice.Proprietary))]
    #endif
    [IsoId("_4YCkYTqkEeWyoP0PbocV1Q")]
    [DisplayName("Rate Type 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType35Choice_
    #else
    public abstract partial class RateType35Choice_
    #endif
    {
    }
}
