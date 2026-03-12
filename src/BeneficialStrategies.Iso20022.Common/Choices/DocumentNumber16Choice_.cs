// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a short document number, a long document number or a proprietary document number.
    /// </summary>
    [KnownType(typeof(DocumentNumber16Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber16Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber16Choice.ProprietaryNumber))]
    [JsonDerivedType(typeof(DocumentNumber16Choice.ShortNumber),nameof(DocumentNumber16Choice.ShortNumber))]
    [JsonDerivedType(typeof(DocumentNumber16Choice.LongNumber),nameof(DocumentNumber16Choice.LongNumber))]
    [JsonDerivedType(typeof(DocumentNumber16Choice.ProprietaryNumber),nameof(DocumentNumber16Choice.ProprietaryNumber))]
    [IsoId("_6GW8w5NLEeWGlc8L7oPDIg")]
    [DisplayName("Document Number 16 Choice")]
    public abstract partial record DocumentNumber16Choice_
    {
    }
}
