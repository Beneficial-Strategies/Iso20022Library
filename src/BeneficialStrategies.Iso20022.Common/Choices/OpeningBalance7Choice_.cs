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
    /// Choice of opening balance.
    /// </summary>
    [KnownType(typeof(OpeningBalance7Choice.First))]
    [KnownType(typeof(OpeningBalance7Choice.Intermediary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OpeningBalance7Choice.First),nameof(OpeningBalance7Choice.First))]
    [JsonDerivedType(typeof(OpeningBalance7Choice.Intermediary),nameof(OpeningBalance7Choice.Intermediary))]
    #endif
    [IsoId("_gJxZ8zi8Eeydid5dcNPKvg")]
    [DisplayName("Opening Balance 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OpeningBalance7Choice_
    #else
    public abstract partial class OpeningBalance7Choice_
    #endif
    {
    }
}
