// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the corrective transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(CorrectiveTransaction2Choice.Initiation))]
    [KnownType(typeof(CorrectiveTransaction2Choice.Interbank))]
    [JsonDerivedType(
        typeof(CorrectiveTransaction2Choice.Initiation),
        nameof(CorrectiveTransaction2Choice.Initiation)
    )]
    [JsonDerivedType(
        typeof(CorrectiveTransaction2Choice.Interbank),
        nameof(CorrectiveTransaction2Choice.Interbank)
    )]
    [IsoId("_wO4VgWXqEeap-P22vGV91g")]
    [DisplayName("Corrective Transaction 2 Choice")]
    public abstract record CorrectiveTransaction2Choice_ { }
}
