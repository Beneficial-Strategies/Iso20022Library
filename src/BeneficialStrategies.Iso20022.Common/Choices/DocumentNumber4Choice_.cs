// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a short document number, a long document number or a proprietary document number.
    /// </summary>
    [KnownType(typeof(DocumentNumber4Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber4Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber4Choice.ProprietaryNumber))]
    [JsonDerivedType(
        typeof(DocumentNumber4Choice.ShortNumber),
        nameof(DocumentNumber4Choice.ShortNumber)
    )]
    [JsonDerivedType(
        typeof(DocumentNumber4Choice.LongNumber),
        nameof(DocumentNumber4Choice.LongNumber)
    )]
    [JsonDerivedType(
        typeof(DocumentNumber4Choice.ProprietaryNumber),
        nameof(DocumentNumber4Choice.ProprietaryNumber)
    )]
    [IsoId("_Adb_YNokEeC60axPepSq7g_2005166615")]
    [DisplayName("Document Number 4 Choice")]
    public abstract record DocumentNumber4Choice_ { }
}
