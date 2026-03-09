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
    [KnownType(typeof(UnmatchedReason22Choice.Code))]
    [KnownType(typeof(UnmatchedReason22Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedReason22Choice.Code),nameof(UnmatchedReason22Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason22Choice.Proprietary),nameof(UnmatchedReason22Choice.Proprietary))]
    #endif
    [IsoId("_SN9toTqyEeWyoP0PbocV1Q")]
    [DisplayName("Unmatched Reason 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedReason22Choice_
    #else
    public abstract partial class UnmatchedReason22Choice_
    #endif
    {
    }
}
