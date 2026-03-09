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
    /// Choice of closing balance.
    /// </summary>
    [KnownType(typeof(ClosingBalance6Choice.Final))]
    [KnownType(typeof(ClosingBalance6Choice.Intermediary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClosingBalance6Choice.Final),nameof(ClosingBalance6Choice.Final))]
    [JsonDerivedType(typeof(ClosingBalance6Choice.Intermediary),nameof(ClosingBalance6Choice.Intermediary))]
    #endif
    [IsoId("_BpAVcyp8EeyR9JrVGfaMKw")]
    [DisplayName("Closing Balance 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosingBalance6Choice_
    #else
    public abstract partial class ClosingBalance6Choice_
    #endif
    {
    }
}
