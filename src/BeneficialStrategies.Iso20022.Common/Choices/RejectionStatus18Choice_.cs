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
    [KnownType(typeof(RejectionStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus18Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionStatus18Choice.NoSpecifiedReason),nameof(RejectionStatus18Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus18Choice.Reason),nameof(RejectionStatus18Choice.Reason))]
    #endif
    [IsoId("_QpvlATq2EeWyoP0PbocV1Q")]
    [DisplayName("Rejection Status 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus18Choice_
    #else
    public abstract partial class RejectionStatus18Choice_
    #endif
    {
    }
}
