// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the report data or an operational error.
    /// </summary>
    [KnownType(typeof(IntraBalanceOrOperationalError7Choice.Movements))]
    [KnownType(typeof(IntraBalanceOrOperationalError7Choice.OperationalError))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError7Choice.Movements),nameof(IntraBalanceOrOperationalError7Choice.Movements))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError7Choice.OperationalError),nameof(IntraBalanceOrOperationalError7Choice.OperationalError))]
    [IsoId("_X3ej8TneEem7JZMuWtwtsg")]
    [DisplayName("Intra Balance Or Operational Error 7 Choice")]
    public abstract partial record IntraBalanceOrOperationalError7Choice_
    {
    }
}
