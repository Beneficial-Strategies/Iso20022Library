// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason for no activity and the secured market segment transaction details.
    /// </summary>
    [KnownType(typeof(SecuredMarketReport4Choice.DataSetAction))]
    [KnownType(typeof(SecuredMarketReport4Choice.Transaction))]
    [JsonDerivedType(
        typeof(SecuredMarketReport4Choice.DataSetAction),
        nameof(SecuredMarketReport4Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(SecuredMarketReport4Choice.Transaction),
        nameof(SecuredMarketReport4Choice.Transaction)
    )]
    [IsoId("_GQHsIcEREea7jLfvGi1PDw")]
    [DisplayName("Secured Market Report 4 Choice")]
    public abstract record SecuredMarketReport4Choice_ { }
}
