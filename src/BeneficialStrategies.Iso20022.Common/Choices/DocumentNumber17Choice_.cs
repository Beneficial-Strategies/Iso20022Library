// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a short document number, a long document number or a proprietary document number.
    /// </summary>
    [KnownType(typeof(DocumentNumber17Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber17Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber17Choice.ProprietaryNumber))]
    [JsonDerivedType(typeof(DocumentNumber17Choice.ShortNumber),nameof(DocumentNumber17Choice.ShortNumber))]
    [JsonDerivedType(typeof(DocumentNumber17Choice.LongNumber),nameof(DocumentNumber17Choice.LongNumber))]
    [JsonDerivedType(typeof(DocumentNumber17Choice.ProprietaryNumber),nameof(DocumentNumber17Choice.ProprietaryNumber))]
    [IsoId("_dAFvEZBgEeakHoV5BVecAQ")]
    [DisplayName("Document Number 17 Choice")]
    public abstract partial record DocumentNumber17Choice_
    {
    }
}
