// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Intra Balance Or Operational Error12Choice.
    /// </summary>
    [KnownType(typeof(IntraBalanceOrOperationalError12Choice.Modifications))]
    [KnownType(typeof(IntraBalanceOrOperationalError12Choice.OperationalError))]
    [JsonDerivedType(
        typeof(IntraBalanceOrOperationalError12Choice.Modifications),
        nameof(IntraBalanceOrOperationalError12Choice.Modifications)
    )]
    [JsonDerivedType(
        typeof(IntraBalanceOrOperationalError12Choice.OperationalError),
        nameof(IntraBalanceOrOperationalError12Choice.OperationalError)
    )]
    [IsoId("_7riFITEyEe6g-ffJsqGiSA")]
    [DisplayName("Intra Balance Or Operational Error12Choice")]
    public abstract record IntraBalanceOrOperationalError12Choice_ { }
}
