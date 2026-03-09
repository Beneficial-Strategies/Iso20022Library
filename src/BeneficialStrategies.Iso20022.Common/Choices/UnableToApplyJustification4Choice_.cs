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
    [KnownType(typeof(UnableToApplyJustification4Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification4Choice.MissingOrIncorrectInformation))]
    [KnownType(typeof(UnableToApplyJustification4Choice.PossibleDuplicateInstruction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnableToApplyJustification4Choice.AnyInformation),nameof(UnableToApplyJustification4Choice.AnyInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification4Choice.MissingOrIncorrectInformation),nameof(UnableToApplyJustification4Choice.MissingOrIncorrectInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification4Choice.PossibleDuplicateInstruction),nameof(UnableToApplyJustification4Choice.PossibleDuplicateInstruction))]
    #endif
    [IsoId("_7JifAdjKEeq5MfBBxQig1Q")]
    [DisplayName("Unable To Apply Justification 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnableToApplyJustification4Choice_
    #else
    public abstract partial class UnableToApplyJustification4Choice_
    #endif
    {
    }
}
