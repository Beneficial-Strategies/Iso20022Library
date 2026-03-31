// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a short document number, a long document number or a proprietary document number.
    /// </summary>
    [KnownType(typeof(DocumentNumber1Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber1Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber1Choice.ProprietaryNumber))]
    [JsonDerivedType(
        typeof(DocumentNumber1Choice.ShortNumber),
        nameof(DocumentNumber1Choice.ShortNumber)
    )]
    [JsonDerivedType(
        typeof(DocumentNumber1Choice.LongNumber),
        nameof(DocumentNumber1Choice.LongNumber)
    )]
    [JsonDerivedType(
        typeof(DocumentNumber1Choice.ProprietaryNumber),
        nameof(DocumentNumber1Choice.ProprietaryNumber)
    )]
    [IsoId("_QzcNJtp-Ed-ak6NoX_4Aeg_-2100056613")]
    [DisplayName("Document Number 1 Choice")]
    public abstract record DocumentNumber1Choice_ { }
}
