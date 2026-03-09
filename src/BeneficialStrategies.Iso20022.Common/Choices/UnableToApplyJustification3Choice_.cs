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
    /// Specifies the details of missing or incorrect information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustification3Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification3Choice.MissingOrIncorrectInformation))]
    [KnownType(typeof(UnableToApplyJustification3Choice.PossibleDuplicateInstruction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnableToApplyJustification3Choice.AnyInformation),nameof(UnableToApplyJustification3Choice.AnyInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification3Choice.MissingOrIncorrectInformation),nameof(UnableToApplyJustification3Choice.MissingOrIncorrectInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification3Choice.PossibleDuplicateInstruction),nameof(UnableToApplyJustification3Choice.PossibleDuplicateInstruction))]
    #endif
    [IsoId("_SzxmAUgoEeaGKYpLDboHPQ")]
    [DisplayName("Unable To Apply Justification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnableToApplyJustification3Choice_
    #else
    public abstract partial class UnableToApplyJustification3Choice_
    #endif
    {
    }
}
