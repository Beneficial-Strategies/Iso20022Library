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
    /// Choice of format for the statement query unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason8Choice.Code))]
    [KnownType(typeof(UnmatchedReason8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedReason8Choice.Code),nameof(UnmatchedReason8Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason8Choice.Proprietary),nameof(UnmatchedReason8Choice.Proprietary))]
    #endif
    [IsoId("_E2Dtd_4hEeCH9dkaY_DhYw")]
    [DisplayName("Unmatched Reason 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedReason8Choice_
    #else
    public abstract partial class UnmatchedReason8Choice_
    #endif
    {
    }
}
