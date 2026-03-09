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
    [KnownType(typeof(ClosingBalance7Choice.Final))]
    [KnownType(typeof(ClosingBalance7Choice.Intermediary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClosingBalance7Choice.Final),nameof(ClosingBalance7Choice.Final))]
    [JsonDerivedType(typeof(ClosingBalance7Choice.Intermediary),nameof(ClosingBalance7Choice.Intermediary))]
    #endif
    [IsoId("_gJxaizi8Eeydid5dcNPKvg")]
    [DisplayName("Closing Balance 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosingBalance7Choice_
    #else
    public abstract partial class ClosingBalance7Choice_
    #endif
    {
    }
}
