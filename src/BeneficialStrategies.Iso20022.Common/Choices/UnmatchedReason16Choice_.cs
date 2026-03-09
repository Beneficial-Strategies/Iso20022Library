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
    [KnownType(typeof(UnmatchedReason16Choice.Code))]
    [KnownType(typeof(UnmatchedReason16Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedReason16Choice.Code),nameof(UnmatchedReason16Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason16Choice.Proprietary),nameof(UnmatchedReason16Choice.Proprietary))]
    #endif
    [IsoId("_zbyVoSwkEeOEV5XHD-BKpw")]
    [DisplayName("Unmatched Reason 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedReason16Choice_
    #else
    public abstract partial class UnmatchedReason16Choice_
    #endif
    {
    }
}
