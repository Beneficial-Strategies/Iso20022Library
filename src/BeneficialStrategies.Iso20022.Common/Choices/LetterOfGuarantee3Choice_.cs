// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the letter of guarantee information.
    /// </summary>
    [KnownType(typeof(LetterOfGuarantee3Choice.Indicator))]
    [KnownType(typeof(LetterOfGuarantee3Choice.Proprietary))]
    [JsonDerivedType(typeof(LetterOfGuarantee3Choice.Indicator),nameof(LetterOfGuarantee3Choice.Indicator))]
    [JsonDerivedType(typeof(LetterOfGuarantee3Choice.Proprietary),nameof(LetterOfGuarantee3Choice.Proprietary))]
    [IsoId("_AY9vEdokEeC60axPepSq7g_-1666647769")]
    [DisplayName("Letter Of Guarantee 3 Choice")]
    public abstract partial record LetterOfGuarantee3Choice_
    {
    }
}
