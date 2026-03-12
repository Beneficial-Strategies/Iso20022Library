// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between details of missing information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustification1Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification1Choice.MissingOrIncorrectInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification1Choice.AnyInformation),nameof(UnableToApplyJustification1Choice.AnyInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification1Choice.MissingOrIncorrectInformation),nameof(UnableToApplyJustification1Choice.MissingOrIncorrectInformation))]
    [IsoId("_T-i3MNp-Ed-ak6NoX_4Aeg_-1347537926")]
    [DisplayName("Unable To Apply Justification 1 Choice")]
    public abstract partial record UnableToApplyJustification1Choice_
    {
    }
}
