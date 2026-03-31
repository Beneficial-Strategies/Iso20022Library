// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the letter of guarantee information.
    /// </summary>
    [KnownType(typeof(LetterOfGuarantee1Choice.Indicator))]
    [KnownType(typeof(LetterOfGuarantee1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(LetterOfGuarantee1Choice.Indicator),
        nameof(LetterOfGuarantee1Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(LetterOfGuarantee1Choice.Proprietary),
        nameof(LetterOfGuarantee1Choice.Proprietary)
    )]
    [IsoId("_QvaoxNp-Ed-ak6NoX_4Aeg_3419755")]
    [DisplayName("Letter Of Guarantee 1 Choice")]
    public abstract record LetterOfGuarantee1Choice_ { }
}
