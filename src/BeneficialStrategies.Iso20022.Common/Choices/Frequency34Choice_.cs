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
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency34Choice.Code))]
    [KnownType(typeof(Frequency34Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Frequency34Choice.Code),nameof(Frequency34Choice.Code))]
    [JsonDerivedType(typeof(Frequency34Choice.Proprietary),nameof(Frequency34Choice.Proprietary))]
    #endif
    [IsoId("_5ePNP5NLEeWGlc8L7oPDIg")]
    [DisplayName("Frequency 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency34Choice_
    #else
    public abstract partial class Frequency34Choice_
    #endif
    {
    }
}
