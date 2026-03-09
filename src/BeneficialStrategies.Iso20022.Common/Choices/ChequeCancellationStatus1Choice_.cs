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
    /// Specifies the status for the cancellation request of a cheque presentment.
    /// </summary>
    [KnownType(typeof(ChequeCancellationStatus1Choice.Code))]
    [KnownType(typeof(ChequeCancellationStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChequeCancellationStatus1Choice.Code),nameof(ChequeCancellationStatus1Choice.Code))]
    [JsonDerivedType(typeof(ChequeCancellationStatus1Choice.Proprietary),nameof(ChequeCancellationStatus1Choice.Proprietary))]
    #endif
    [IsoId("_PJJT-7tyEeq_cfXrH83Rcw")]
    [DisplayName("Cheque Cancellation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChequeCancellationStatus1Choice_
    #else
    public abstract partial class ChequeCancellationStatus1Choice_
    #endif
    {
    }
}
