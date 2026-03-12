// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the corrective transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(CorrectiveTransaction3Choice.Initiation))]
    [KnownType(typeof(CorrectiveTransaction3Choice.Interbank))]
    [JsonDerivedType(typeof(CorrectiveTransaction3Choice.Initiation),nameof(CorrectiveTransaction3Choice.Initiation))]
    [JsonDerivedType(typeof(CorrectiveTransaction3Choice.Interbank),nameof(CorrectiveTransaction3Choice.Interbank))]
    [IsoId("_88-Vca6UEeexrtTFgmVD3Q")]
    [DisplayName("Corrective Transaction 3 Choice")]
    public abstract partial record CorrectiveTransaction3Choice_
    {
    }
}
