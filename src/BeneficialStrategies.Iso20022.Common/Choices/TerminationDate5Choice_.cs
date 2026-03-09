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
    [KnownType(typeof(TerminationDate5Choice.Date))]
    [KnownType(typeof(TerminationDate5Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TerminationDate5Choice.Date),nameof(TerminationDate5Choice.Date))]
    [JsonDerivedType(typeof(TerminationDate5Choice.Code),nameof(TerminationDate5Choice.Code))]
    #endif
    [IsoId("_5mw3n5NLEeWGlc8L7oPDIg")]
    [DisplayName("Termination Date 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TerminationDate5Choice_
    #else
    public abstract partial class TerminationDate5Choice_
    #endif
    {
    }
}
