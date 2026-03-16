// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the corrective transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(CorrectiveTransaction1Choice.Initiation))]
    [KnownType(typeof(CorrectiveTransaction1Choice.Interbank))]
    [JsonDerivedType(
        typeof(CorrectiveTransaction1Choice.Initiation),
        nameof(CorrectiveTransaction1Choice.Initiation)
    )]
    [JsonDerivedType(
        typeof(CorrectiveTransaction1Choice.Interbank),
        nameof(CorrectiveTransaction1Choice.Interbank)
    )]
    [IsoId("_P7RPB9p-Ed-ak6NoX_4Aeg_445154531")]
    [DisplayName("Corrective Transaction 1 Choice")]
    public abstract record CorrectiveTransaction1Choice_ { }
}
