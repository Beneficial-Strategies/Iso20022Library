// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the corrective transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(CorrectiveTransaction4Choice.Initiation))]
    [KnownType(typeof(CorrectiveTransaction4Choice.Interbank))]
    [JsonDerivedType(
        typeof(CorrectiveTransaction4Choice.Initiation),
        nameof(CorrectiveTransaction4Choice.Initiation)
    )]
    [JsonDerivedType(
        typeof(CorrectiveTransaction4Choice.Interbank),
        nameof(CorrectiveTransaction4Choice.Interbank)
    )]
    [IsoId("_3bNYAXuSEeivKIBRHeTQRQ")]
    [DisplayName("Corrective Transaction 4 Choice")]
    public abstract record CorrectiveTransaction4Choice_ { }
}
