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
    [KnownType(typeof(OpeningBalance5Choice.First))]
    [KnownType(typeof(OpeningBalance5Choice.Intermediary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OpeningBalance5Choice.First),nameof(OpeningBalance5Choice.First))]
    [JsonDerivedType(typeof(OpeningBalance5Choice.Intermediary),nameof(OpeningBalance5Choice.Intermediary))]
    #endif
    [IsoId("_8bhdbZNLEeWGlc8L7oPDIg")]
    [DisplayName("Opening Balance 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OpeningBalance5Choice_
    #else
    public abstract partial class OpeningBalance5Choice_
    #endif
    {
    }
}
