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
    [KnownType(typeof(PendingStatus37Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus37Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus37Choice.NoSpecifiedReason),nameof(PendingStatus37Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus37Choice.Reason),nameof(PendingStatus37Choice.Reason))]
    #endif
    [IsoId("_h0uKcTqOEeWyoP0PbocV1Q")]
    [DisplayName("Pending Status 37 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus37Choice_
    #else
    public abstract partial class PendingStatus37Choice_
    #endif
    {
    }
}
