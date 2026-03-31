// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the letter of guarantee information.
    /// </summary>
    [KnownType(typeof(LetterOfGuarantee4Choice.Indicator))]
    [KnownType(typeof(LetterOfGuarantee4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(LetterOfGuarantee4Choice.Indicator),
        nameof(LetterOfGuarantee4Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(LetterOfGuarantee4Choice.Proprietary),
        nameof(LetterOfGuarantee4Choice.Proprietary)
    )]
    [IsoId("_H0FFUTqJEeWVrPy0StzzSg")]
    [DisplayName("Letter Of Guarantee 4 Choice")]
    public abstract record LetterOfGuarantee4Choice_ { }
}
