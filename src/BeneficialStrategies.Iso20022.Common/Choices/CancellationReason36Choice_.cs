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
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason36Choice.Code))]
    [KnownType(typeof(CancellationReason36Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationReason36Choice.Code),nameof(CancellationReason36Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason36Choice.Proprietary),nameof(CancellationReason36Choice.Proprietary))]
    #endif
    [IsoId("_HkfY8dB7EeihG9bKfarOOA")]
    [DisplayName("Cancellation Reason 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason36Choice_
    #else
    public abstract partial class CancellationReason36Choice_
    #endif
    {
    }
}
