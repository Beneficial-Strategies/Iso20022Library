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
    /// Choice to provide the summation of the call amounts for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(MarginCallResult2Choice.MarginCallResultDetails))]
    [KnownType(typeof(MarginCallResult2Choice.MarginCallAmount))]
    [KnownType(typeof(MarginCallResult2Choice.SegregatedIndependentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarginCallResult2Choice.MarginCallResultDetails),nameof(MarginCallResult2Choice.MarginCallResultDetails))]
    [JsonDerivedType(typeof(MarginCallResult2Choice.MarginCallAmount),nameof(MarginCallResult2Choice.MarginCallAmount))]
    [JsonDerivedType(typeof(MarginCallResult2Choice.SegregatedIndependentAmount),nameof(MarginCallResult2Choice.SegregatedIndependentAmount))]
    #endif
    [IsoId("_9beRS6MPEeCojJW5vEuTEQ_-1338603652")]
    [DisplayName("Margin Call Result 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarginCallResult2Choice_
    #else
    public abstract partial class MarginCallResult2Choice_
    #endif
    {
    }
}
