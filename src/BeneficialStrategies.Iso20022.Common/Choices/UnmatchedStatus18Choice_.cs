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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus18Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedStatus18Choice.NoSpecifiedReason),nameof(UnmatchedStatus18Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus18Choice.Reason),nameof(UnmatchedStatus18Choice.Reason))]
    #endif
    [IsoId("_CDyTATw8EeW3QqUkIQtIUA")]
    [DisplayName("Unmatched Status 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedStatus18Choice_
    #else
    public abstract partial class UnmatchedStatus18Choice_
    #endif
    {
    }
}
