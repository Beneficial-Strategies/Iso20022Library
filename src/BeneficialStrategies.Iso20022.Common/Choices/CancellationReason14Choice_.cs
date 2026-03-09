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
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [KnownType(typeof(CancellationReason14Choice.Code))]
    [KnownType(typeof(CancellationReason14Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationReason14Choice.Code),nameof(CancellationReason14Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason14Choice.Proprietary),nameof(CancellationReason14Choice.Proprietary))]
    #endif
    [IsoId("_t3j1IFkyEeGeoaLUQk__nA_1418440673")]
    [DisplayName("Cancellation Reason 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason14Choice_
    #else
    public abstract partial class CancellationReason14Choice_
    #endif
    {
    }
}
