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
    [KnownType(typeof(UnmatchedReason3Choice.Code))]
    [KnownType(typeof(UnmatchedReason3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedReason3Choice.Code),nameof(UnmatchedReason3Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason3Choice.Proprietary),nameof(UnmatchedReason3Choice.Proprietary))]
    #endif
    [IsoId("_UWYvd9p-Ed-ak6NoX_4Aeg_1064638160")]
    [DisplayName("Unmatched Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedReason3Choice_
    #else
    public abstract partial class UnmatchedReason3Choice_
    #endif
    {
    }
}
