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
    [KnownType(typeof(ClosingBalance5Choice.Final))]
    [KnownType(typeof(ClosingBalance5Choice.Intermediary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClosingBalance5Choice.Final),nameof(ClosingBalance5Choice.Final))]
    [JsonDerivedType(typeof(ClosingBalance5Choice.Intermediary),nameof(ClosingBalance5Choice.Intermediary))]
    #endif
    [IsoId("_8bhd_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Closing Balance 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosingBalance5Choice_
    #else
    public abstract partial class ClosingBalance5Choice_
    #endif
    {
    }
}
