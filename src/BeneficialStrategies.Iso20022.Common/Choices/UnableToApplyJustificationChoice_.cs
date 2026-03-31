// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between details of missing information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustificationChoice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustificationChoice.MissingOrIncorrectInformation))]
    [JsonDerivedType(
        typeof(UnableToApplyJustificationChoice.AnyInformation),
        nameof(UnableToApplyJustificationChoice.AnyInformation)
    )]
    [JsonDerivedType(
        typeof(UnableToApplyJustificationChoice.MissingOrIncorrectInformation),
        nameof(UnableToApplyJustificationChoice.MissingOrIncorrectInformation)
    )]
    [IsoId("_VFn0Dtp-Ed-ak6NoX_4Aeg_811633564")]
    [DisplayName("Unable To Apply Justification Choice")]
    public abstract record UnableToApplyJustificationChoice_ { }
}
