// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the report data or an operational error.
    /// </summary>
    [KnownType(typeof(IntraBalanceOrOperationalError8Choice.Modifications))]
    [KnownType(typeof(IntraBalanceOrOperationalError8Choice.OperationalError))]
    [JsonDerivedType(
        typeof(IntraBalanceOrOperationalError8Choice.Modifications),
        nameof(IntraBalanceOrOperationalError8Choice.Modifications)
    )]
    [JsonDerivedType(
        typeof(IntraBalanceOrOperationalError8Choice.OperationalError),
        nameof(IntraBalanceOrOperationalError8Choice.OperationalError)
    )]
    [IsoId("_ZhRzuzneEem7JZMuWtwtsg")]
    [DisplayName("Intra Balance Or Operational Error 8 Choice")]
    public abstract record IntraBalanceOrOperationalError8Choice_ { }
}
