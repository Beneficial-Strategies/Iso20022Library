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
    [KnownType(typeof(TerminationDate7Choice.Date))]
    [KnownType(typeof(TerminationDate7Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TerminationDate7Choice.Date),nameof(TerminationDate7Choice.Date))]
    [JsonDerivedType(typeof(TerminationDate7Choice.Code),nameof(TerminationDate7Choice.Code))]
    #endif
    [IsoId("_5TocY83yEee5nJBZsW8MFQ")]
    [DisplayName("Termination Date 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TerminationDate7Choice_
    #else
    public abstract partial class TerminationDate7Choice_
    #endif
    {
    }
}
