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
    [KnownType(typeof(PendingReason52Choice.Code))]
    [KnownType(typeof(PendingReason52Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason52Choice.Code),nameof(PendingReason52Choice.Code))]
    [JsonDerivedType(typeof(PendingReason52Choice.Proprietary),nameof(PendingReason52Choice.Proprietary))]
    #endif
    [IsoId("_YmUaUOBiEeiVRbNQx5-Vhg")]
    [DisplayName("Pending Reason 52 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason52Choice_
    #else
    public abstract partial class PendingReason52Choice_
    #endif
    {
    }
}
