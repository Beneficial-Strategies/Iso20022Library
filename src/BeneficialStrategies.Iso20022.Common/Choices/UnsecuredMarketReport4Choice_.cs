// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason for no activity and the unsecured market segment transaction details.
    /// </summary>
    [KnownType(typeof(UnsecuredMarketReport4Choice.DataSetAction))]
    [KnownType(typeof(UnsecuredMarketReport4Choice.Transaction))]
    [JsonDerivedType(
        typeof(UnsecuredMarketReport4Choice.DataSetAction),
        nameof(UnsecuredMarketReport4Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(UnsecuredMarketReport4Choice.Transaction),
        nameof(UnsecuredMarketReport4Choice.Transaction)
    )]
    [IsoId("_G-P9i8EREea7jLfvGi1PDw")]
    [DisplayName("Unsecured Market Report 4 Choice")]
    public abstract record UnsecuredMarketReport4Choice_ { }
}
