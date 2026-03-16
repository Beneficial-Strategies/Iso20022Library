// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Intra Balance Or Operational Error11Choice.
    /// </summary>
    [KnownType(typeof(IntraBalanceOrOperationalError11Choice.Movements))]
    [KnownType(typeof(IntraBalanceOrOperationalError11Choice.OperationalError))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError11Choice.Movements),nameof(IntraBalanceOrOperationalError11Choice.Movements))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError11Choice.OperationalError),nameof(IntraBalanceOrOperationalError11Choice.OperationalError))]
    [IsoId("_3qht0TEyEe6g-ffJsqGiSA")]
    [DisplayName("Intra Balance Or Operational Error11Choice")]
    public abstract partial record IntraBalanceOrOperationalError11Choice_
    {
    }
}
