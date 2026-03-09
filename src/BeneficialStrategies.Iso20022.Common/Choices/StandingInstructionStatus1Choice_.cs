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
    /// Choice between various statuses.
    /// </summary>
    [KnownType(typeof(StandingInstructionStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(StandingInstructionStatus1Choice.RejectedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StandingInstructionStatus1Choice.ProcessedStatus),nameof(StandingInstructionStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(StandingInstructionStatus1Choice.RejectedStatus),nameof(StandingInstructionStatus1Choice.RejectedStatus))]
    #endif
    [IsoId("_RiiHyNp-Ed-ak6NoX_4Aeg_-2004656056")]
    [DisplayName("Standing Instruction Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingInstructionStatus1Choice_
    #else
    public abstract partial class StandingInstructionStatus1Choice_
    #endif
    {
    }
}
