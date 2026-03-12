// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of missing or incorrect information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustification3Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification3Choice.MissingOrIncorrectInformation))]
    [KnownType(typeof(UnableToApplyJustification3Choice.PossibleDuplicateInstruction))]
    [JsonDerivedType(typeof(UnableToApplyJustification3Choice.AnyInformation),nameof(UnableToApplyJustification3Choice.AnyInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification3Choice.MissingOrIncorrectInformation),nameof(UnableToApplyJustification3Choice.MissingOrIncorrectInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification3Choice.PossibleDuplicateInstruction),nameof(UnableToApplyJustification3Choice.PossibleDuplicateInstruction))]
    [IsoId("_SzxmAUgoEeaGKYpLDboHPQ")]
    [DisplayName("Unable To Apply Justification 3 Choice")]
    public abstract partial record UnableToApplyJustification3Choice_
    {
    }
}
