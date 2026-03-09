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
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus1Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingCancellationStatus1Choice.NotSpecifiedReason),nameof(PendingCancellationStatus1Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus1Choice.Reason),nameof(PendingCancellationStatus1Choice.Reason))]
    #endif
    [IsoId("_Qx8_atp-Ed-ak6NoX_4Aeg_-810729399")]
    [DisplayName("Pending Cancellation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationStatus1Choice_
    #else
    public abstract partial class PendingCancellationStatus1Choice_
    #endif
    {
    }
}
