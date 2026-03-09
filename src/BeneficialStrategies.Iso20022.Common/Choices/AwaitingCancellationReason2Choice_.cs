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
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AwaitingCancellationReason2Choice.Code))]
    [KnownType(typeof(AwaitingCancellationReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AwaitingCancellationReason2Choice.Code),nameof(AwaitingCancellationReason2Choice.Code))]
    [JsonDerivedType(typeof(AwaitingCancellationReason2Choice.Proprietary),nameof(AwaitingCancellationReason2Choice.Proprietary))]
    #endif
    [IsoId("_mYibFQd4Ee2fOITqoTnSLQ")]
    [DisplayName("Awaiting Cancellation Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AwaitingCancellationReason2Choice_
    #else
    public abstract partial class AwaitingCancellationReason2Choice_
    #endif
    {
    }
}
