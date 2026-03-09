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
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason11Choice.Code))]
    [KnownType(typeof(CancelledReason11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancelledReason11Choice.Code),nameof(CancelledReason11Choice.Code))]
    [JsonDerivedType(typeof(CancelledReason11Choice.Proprietary),nameof(CancelledReason11Choice.Proprietary))]
    #endif
    [IsoId("_cgnRw5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cancelled Reason 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledReason11Choice_
    #else
    public abstract partial class CancelledReason11Choice_
    #endif
    {
    }
}
