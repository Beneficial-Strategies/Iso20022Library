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
    /// Status applying to the instruction cancellation request received.
    /// </summary>
    [KnownType(typeof(CancellationStatus1Choice.ProcessingStatus))]
    [KnownType(typeof(CancellationStatus1Choice.RejectionStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancellationStatus1Choice.ProcessingStatus),nameof(CancellationStatus1Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(CancellationStatus1Choice.RejectionStatus),nameof(CancellationStatus1Choice.RejectionStatus))]
    #endif
    [IsoId("_RVa41dp-Ed-ak6NoX_4Aeg_-538392841")]
    [DisplayName("Cancellation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatus1Choice_
    #else
    public abstract partial class CancellationStatus1Choice_
    #endif
    {
    }
}
