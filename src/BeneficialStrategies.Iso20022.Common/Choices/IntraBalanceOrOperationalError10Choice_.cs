// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Intra Balance Or Operational Error10Choice.
    /// </summary>
    [KnownType(typeof(IntraBalanceOrOperationalError10Choice.Cancellations))]
    [KnownType(typeof(IntraBalanceOrOperationalError10Choice.OperationalError))]
    [JsonDerivedType(
        typeof(IntraBalanceOrOperationalError10Choice.Cancellations),
        nameof(IntraBalanceOrOperationalError10Choice.Cancellations)
    )]
    [JsonDerivedType(
        typeof(IntraBalanceOrOperationalError10Choice.OperationalError),
        nameof(IntraBalanceOrOperationalError10Choice.OperationalError)
    )]
    [IsoId("_3c9y8TEyEe6g-ffJsqGiSA")]
    [DisplayName("Intra Balance Or Operational Error10Choice")]
    public abstract record IntraBalanceOrOperationalError10Choice_ { }
}
