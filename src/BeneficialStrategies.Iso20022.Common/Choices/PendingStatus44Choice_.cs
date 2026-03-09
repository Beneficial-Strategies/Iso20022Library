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
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus44Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus44Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus44Choice.NoSpecifiedReason),nameof(PendingStatus44Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus44Choice.Reason),nameof(PendingStatus44Choice.Reason))]
    #endif
    [IsoId("_cgn4k5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Status 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus44Choice_
    #else
    public abstract partial class PendingStatus44Choice_
    #endif
    {
    }
}
