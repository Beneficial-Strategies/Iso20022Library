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
    /// Choice between a proprietary or narrative reason and no reason for the rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus29Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus29Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus29Choice.NoSpecifiedReason),nameof(RejectedStatus29Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus29Choice.Reason),nameof(RejectedStatus29Choice.Reason))]
    #endif
    [IsoId("_fh9eqYeWEemJ1cSJJmVYRQ")]
    [DisplayName("Rejected Status 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus29Choice_
    #else
    public abstract partial class RejectedStatus29Choice_
    #endif
    {
    }
}
