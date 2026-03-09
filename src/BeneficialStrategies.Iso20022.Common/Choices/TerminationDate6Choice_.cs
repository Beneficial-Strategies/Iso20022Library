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
    /// Choice of format for the termination date.
    /// </summary>
    [KnownType(typeof(TerminationDate6Choice.Date))]
    [KnownType(typeof(TerminationDate6Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TerminationDate6Choice.Date),nameof(TerminationDate6Choice.Date))]
    [JsonDerivedType(typeof(TerminationDate6Choice.Code),nameof(TerminationDate6Choice.Code))]
    #endif
    [IsoId("_hE2NAbPvEeelzbgsFa3sqQ")]
    [DisplayName("Termination Date 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TerminationDate6Choice_
    #else
    public abstract partial class TerminationDate6Choice_
    #endif
    {
    }
}
