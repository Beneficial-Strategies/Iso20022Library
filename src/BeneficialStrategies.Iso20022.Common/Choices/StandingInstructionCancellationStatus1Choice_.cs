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
    /// Provides information about the status of a standing instruction cancellation request.
    /// </summary>
    [KnownType(typeof(StandingInstructionCancellationStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(StandingInstructionCancellationStatus1Choice.RejectedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StandingInstructionCancellationStatus1Choice.ProcessedStatus),nameof(StandingInstructionCancellationStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(StandingInstructionCancellationStatus1Choice.RejectedStatus),nameof(StandingInstructionCancellationStatus1Choice.RejectedStatus))]
    #endif
    [IsoId("_RirRstp-Ed-ak6NoX_4Aeg_-1572447804")]
    [DisplayName("Standing Instruction Cancellation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingInstructionCancellationStatus1Choice_
    #else
    public abstract partial class StandingInstructionCancellationStatus1Choice_
    #endif
    {
    }
}
