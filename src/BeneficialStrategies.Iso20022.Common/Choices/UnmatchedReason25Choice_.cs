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
    /// Choice of format for the securities financing unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason25Choice.Code))]
    [KnownType(typeof(UnmatchedReason25Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedReason25Choice.Code),nameof(UnmatchedReason25Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason25Choice.Proprietary),nameof(UnmatchedReason25Choice.Proprietary))]
    #endif
    [IsoId("_6BIelZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Reason 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedReason25Choice_
    #else
    public abstract partial class UnmatchedReason25Choice_
    #endif
    {
    }
}
