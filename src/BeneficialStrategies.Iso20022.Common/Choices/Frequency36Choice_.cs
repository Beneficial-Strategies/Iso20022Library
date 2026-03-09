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
    /// Choice of format for a frequency, for example, the frequency of payment.
    /// </summary>
    [KnownType(typeof(Frequency36Choice.Type))]
    [KnownType(typeof(Frequency36Choice.Period))]
    [KnownType(typeof(Frequency36Choice.PointInTime))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Frequency36Choice.Type),nameof(Frequency36Choice.Type))]
    [JsonDerivedType(typeof(Frequency36Choice.Period),nameof(Frequency36Choice.Period))]
    [JsonDerivedType(typeof(Frequency36Choice.PointInTime),nameof(Frequency36Choice.PointInTime))]
    #endif
    [IsoId("_sVM2vWk2Eeanu6HLe77Rkg")]
    [DisplayName("Frequency 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency36Choice_
    #else
    public abstract partial class Frequency36Choice_
    #endif
    {
    }
}
