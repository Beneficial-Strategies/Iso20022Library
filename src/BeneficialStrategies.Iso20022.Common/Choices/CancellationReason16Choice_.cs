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
    [KnownType(typeof(CancellationReason16Choice.Code))]
    [KnownType(typeof(CancellationReason16Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationReason16Choice.Code),nameof(CancellationReason16Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason16Choice.Proprietary),nameof(CancellationReason16Choice.Proprietary))]
    #endif
    [IsoId("_jG0jFu5NEeCisYr99QEiWA_-267474018")]
    [DisplayName("Cancellation Reason 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason16Choice_
    #else
    public abstract partial class CancellationReason16Choice_
    #endif
    {
    }
}
