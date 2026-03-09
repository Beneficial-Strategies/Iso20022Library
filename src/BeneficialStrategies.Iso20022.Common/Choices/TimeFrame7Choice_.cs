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
    /// Choice between elements to define a time period.
    /// </summary>
    [KnownType(typeof(TimeFrame7Choice.TradePlus))]
    [KnownType(typeof(TimeFrame7Choice.Prepayment))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TimeFrame7Choice.TradePlus),nameof(TimeFrame7Choice.TradePlus))]
    [JsonDerivedType(typeof(TimeFrame7Choice.Prepayment),nameof(TimeFrame7Choice.Prepayment))]
    #endif
    [IsoId("_5ufTETgDEei6RvewLQWEqw")]
    [DisplayName("Time Frame 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeFrame7Choice_
    #else
    public abstract partial class TimeFrame7Choice_
    #endif
    {
    }
}
