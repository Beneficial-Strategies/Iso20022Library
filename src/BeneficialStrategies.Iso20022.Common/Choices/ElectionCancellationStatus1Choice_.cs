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
    /// Choice between various statuses for an corporate action election cancellation.
    /// </summary>
    [KnownType(typeof(ElectionCancellationStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(ElectionCancellationStatus1Choice.RejectedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ElectionCancellationStatus1Choice.ProcessedStatus),nameof(ElectionCancellationStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(ElectionCancellationStatus1Choice.RejectedStatus),nameof(ElectionCancellationStatus1Choice.RejectedStatus))]
    #endif
    [IsoId("_RiiHwtp-Ed-ak6NoX_4Aeg_1698122957")]
    [DisplayName("Election Cancellation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ElectionCancellationStatus1Choice_
    #else
    public abstract partial class ElectionCancellationStatus1Choice_
    #endif
    {
    }
}
