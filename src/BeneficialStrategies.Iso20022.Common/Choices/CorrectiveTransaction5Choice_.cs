// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the corrective transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(CorrectiveTransaction5Choice.Initiation))]
    [KnownType(typeof(CorrectiveTransaction5Choice.Interbank))]
    [JsonDerivedType(
        typeof(CorrectiveTransaction5Choice.Initiation),
        nameof(CorrectiveTransaction5Choice.Initiation)
    )]
    [JsonDerivedType(
        typeof(CorrectiveTransaction5Choice.Interbank),
        nameof(CorrectiveTransaction5Choice.Interbank)
    )]
    [IsoId("_tNTsINizEeq5MfBBxQig1Q")]
    [DisplayName("Corrective Transaction 5 Choice")]
    public abstract record CorrectiveTransaction5Choice_ { }
}
