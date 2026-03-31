// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of missing information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustification2Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification2Choice.MissingOrIncorrectInformation))]
    [KnownType(typeof(UnableToApplyJustification2Choice.PossibleDuplicateInstruction))]
    [JsonDerivedType(
        typeof(UnableToApplyJustification2Choice.AnyInformation),
        nameof(UnableToApplyJustification2Choice.AnyInformation)
    )]
    [JsonDerivedType(
        typeof(UnableToApplyJustification2Choice.MissingOrIncorrectInformation),
        nameof(UnableToApplyJustification2Choice.MissingOrIncorrectInformation)
    )]
    [JsonDerivedType(
        typeof(UnableToApplyJustification2Choice.PossibleDuplicateInstruction),
        nameof(UnableToApplyJustification2Choice.PossibleDuplicateInstruction)
    )]
    [IsoId("_T-i3M9p-Ed-ak6NoX_4Aeg_-1089125452")]
    [DisplayName("Unable To Apply Justification 2 Choice")]
    public abstract record UnableToApplyJustification2Choice_ { }
}
