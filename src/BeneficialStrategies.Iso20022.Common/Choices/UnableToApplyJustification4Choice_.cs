// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of missing or incorrect information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustification4Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification4Choice.MissingOrIncorrectInformation))]
    [KnownType(typeof(UnableToApplyJustification4Choice.PossibleDuplicateInstruction))]
    [JsonDerivedType(typeof(UnableToApplyJustification4Choice.AnyInformation),nameof(UnableToApplyJustification4Choice.AnyInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification4Choice.MissingOrIncorrectInformation),nameof(UnableToApplyJustification4Choice.MissingOrIncorrectInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification4Choice.PossibleDuplicateInstruction),nameof(UnableToApplyJustification4Choice.PossibleDuplicateInstruction))]
    [IsoId("_7JifAdjKEeq5MfBBxQig1Q")]
    [DisplayName("Unable To Apply Justification 4 Choice")]
    public abstract partial record UnableToApplyJustification4Choice_
    {
    }
}
