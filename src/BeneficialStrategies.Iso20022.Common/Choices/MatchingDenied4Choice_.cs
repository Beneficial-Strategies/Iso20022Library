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
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(MatchingDenied4Choice.Code))]
    [KnownType(typeof(MatchingDenied4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingDenied4Choice.Code),nameof(MatchingDenied4Choice.Code))]
    [JsonDerivedType(typeof(MatchingDenied4Choice.Proprietary),nameof(MatchingDenied4Choice.Proprietary))]
    #endif
    [IsoId("_6GWWDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Denied 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingDenied4Choice_
    #else
    public abstract partial class MatchingDenied4Choice_
    #endif
    {
    }
}
