// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the report data or an operational error.
    /// </summary>
    [KnownType(typeof(IntraBalanceOrOperationalError9Choice.Cancellations))]
    [KnownType(typeof(IntraBalanceOrOperationalError9Choice.OperationalError))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError9Choice.Cancellations),nameof(IntraBalanceOrOperationalError9Choice.Cancellations))]
    [JsonDerivedType(typeof(IntraBalanceOrOperationalError9Choice.OperationalError),nameof(IntraBalanceOrOperationalError9Choice.OperationalError))]
    [IsoId("_p0siMTnfEem7JZMuWtwtsg")]
    [DisplayName("Intra Balance Or Operational Error 9 Choice")]
    public abstract partial record IntraBalanceOrOperationalError9Choice_
    {
    }
}
