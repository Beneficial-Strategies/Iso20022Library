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
    /// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
    /// </summary>
    [KnownType(typeof(CancellationReason38Choice.Code))]
    [KnownType(typeof(CancellationReason38Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationReason38Choice.Code),nameof(CancellationReason38Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason38Choice.Proprietary),nameof(CancellationReason38Choice.Proprietary))]
    #endif
    [IsoId("_PYWmAOBOEeiVRbNQx5-Vhg")]
    [DisplayName("Cancellation Reason 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason38Choice_
    #else
    public abstract partial class CancellationReason38Choice_
    #endif
    {
    }
}
