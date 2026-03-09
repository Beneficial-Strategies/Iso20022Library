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
    [KnownType(typeof(TimeFrame8Choice.TradePlus))]
    [KnownType(typeof(TimeFrame8Choice.RenunciationPlus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TimeFrame8Choice.TradePlus),nameof(TimeFrame8Choice.TradePlus))]
    [JsonDerivedType(typeof(TimeFrame8Choice.RenunciationPlus),nameof(TimeFrame8Choice.RenunciationPlus))]
    #endif
    [IsoId("_bxgQATgFEei6RvewLQWEqw")]
    [DisplayName("Time Frame 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeFrame8Choice_
    #else
    public abstract partial class TimeFrame8Choice_
    #endif
    {
    }
}
