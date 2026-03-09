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
    /// Specifies the reason for the cancellation request of a cheque presentment.
    /// </summary>
    [KnownType(typeof(ChequeCancellationReason1Choice.Code))]
    [KnownType(typeof(ChequeCancellationReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChequeCancellationReason1Choice.Code),nameof(ChequeCancellationReason1Choice.Code))]
    [JsonDerivedType(typeof(ChequeCancellationReason1Choice.Proprietary),nameof(ChequeCancellationReason1Choice.Proprietary))]
    #endif
    [IsoId("_kwwc-7tvEeq_cfXrH83Rcw")]
    [DisplayName("Cheque Cancellation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChequeCancellationReason1Choice_
    #else
    public abstract partial class ChequeCancellationReason1Choice_
    #endif
    {
    }
}
