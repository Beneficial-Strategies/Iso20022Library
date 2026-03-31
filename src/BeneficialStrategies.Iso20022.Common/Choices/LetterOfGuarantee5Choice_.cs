// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the letter of guarantee information.
    /// </summary>
    [KnownType(typeof(LetterOfGuarantee5Choice.Indicator))]
    [KnownType(typeof(LetterOfGuarantee5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(LetterOfGuarantee5Choice.Indicator),
        nameof(LetterOfGuarantee5Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(LetterOfGuarantee5Choice.Proprietary),
        nameof(LetterOfGuarantee5Choice.Proprietary)
    )]
    [IsoId("_6ScRhZNLEeWGlc8L7oPDIg")]
    [DisplayName("Letter Of Guarantee 5 Choice")]
    public abstract record LetterOfGuarantee5Choice_ { }
}
