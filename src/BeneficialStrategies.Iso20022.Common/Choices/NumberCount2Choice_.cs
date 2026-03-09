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
    /// Choice of number count type.
    /// </summary>
    [KnownType(typeof(NumberCount2Choice.CurrentInstructionNumber))]
    [KnownType(typeof(NumberCount2Choice.TotalNumber))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NumberCount2Choice.CurrentInstructionNumber),nameof(NumberCount2Choice.CurrentInstructionNumber))]
    [JsonDerivedType(typeof(NumberCount2Choice.TotalNumber),nameof(NumberCount2Choice.TotalNumber))]
    #endif
    [IsoId("_JBmOYSgdEey2k_sfZmJz4g")]
    [DisplayName("Number Count 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NumberCount2Choice_
    #else
    public abstract partial class NumberCount2Choice_
    #endif
    {
    }
}
