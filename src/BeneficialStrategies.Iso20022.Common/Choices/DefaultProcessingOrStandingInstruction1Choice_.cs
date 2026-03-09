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
    /// Choice between default processing or standing instruction.
    /// </summary>
    [KnownType(typeof(DefaultProcessingOrStandingInstruction1Choice.DefaultOptionIndicator))]
    [KnownType(typeof(DefaultProcessingOrStandingInstruction1Choice.StandingInstructionIndicator))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DefaultProcessingOrStandingInstruction1Choice.DefaultOptionIndicator),nameof(DefaultProcessingOrStandingInstruction1Choice.DefaultOptionIndicator))]
    [JsonDerivedType(typeof(DefaultProcessingOrStandingInstruction1Choice.StandingInstructionIndicator),nameof(DefaultProcessingOrStandingInstruction1Choice.StandingInstructionIndicator))]
    #endif
    [IsoId("_Q0VlAtp-Ed-ak6NoX_4Aeg_-931844170")]
    [DisplayName("Default Processing Or Standing Instruction 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DefaultProcessingOrStandingInstruction1Choice_
    #else
    public abstract partial class DefaultProcessingOrStandingInstruction1Choice_
    #endif
    {
    }
}
