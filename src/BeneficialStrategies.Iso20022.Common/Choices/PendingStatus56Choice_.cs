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
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingStatus56Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus56Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus56Choice.NoSpecifiedReason),nameof(PendingStatus56Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus56Choice.Reason),nameof(PendingStatus56Choice.Reason))]
    #endif
    [IsoId("_P3Vi4OBgEeiVRbNQx5-Vhg")]
    [DisplayName("Pending Status 56 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus56Choice_
    #else
    public abstract partial class PendingStatus56Choice_
    #endif
    {
    }
}
