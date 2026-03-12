// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a short document number, a long document number or a proprietary document number.
    /// </summary>
    [KnownType(typeof(DocumentNumber5Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber5Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber5Choice.ProprietaryNumber))]
    [JsonDerivedType(typeof(DocumentNumber5Choice.ShortNumber),nameof(DocumentNumber5Choice.ShortNumber))]
    [JsonDerivedType(typeof(DocumentNumber5Choice.LongNumber),nameof(DocumentNumber5Choice.LongNumber))]
    [JsonDerivedType(typeof(DocumentNumber5Choice.ProprietaryNumber),nameof(DocumentNumber5Choice.ProprietaryNumber))]
    [IsoId("_CkuCkTnbEeWLJsP1cO-amg")]
    [DisplayName("Document Number 5 Choice")]
    public abstract partial record DocumentNumber5Choice_
    {
    }
}
