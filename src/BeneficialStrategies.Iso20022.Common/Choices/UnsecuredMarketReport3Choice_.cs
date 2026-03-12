// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason for no activity and the unsecured market segment transaction details.
    /// </summary>
    [KnownType(typeof(UnsecuredMarketReport3Choice.DataSetAction))]
    [KnownType(typeof(UnsecuredMarketReport3Choice.Transaction))]
    [JsonDerivedType(typeof(UnsecuredMarketReport3Choice.DataSetAction),nameof(UnsecuredMarketReport3Choice.DataSetAction))]
    [JsonDerivedType(typeof(UnsecuredMarketReport3Choice.Transaction),nameof(UnsecuredMarketReport3Choice.Transaction))]
    [IsoId("_Gm8z9aifEeWHO_l3hf2rlA")]
    [DisplayName("Unsecured Market Report 3 Choice")]
    public abstract partial record UnsecuredMarketReport3Choice_
    {
    }
}
