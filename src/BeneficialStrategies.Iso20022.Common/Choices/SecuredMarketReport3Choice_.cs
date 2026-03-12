// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason for no activity and the secured market segment transaction details.
    /// </summary>
    [KnownType(typeof(SecuredMarketReport3Choice.DataSetAction))]
    [KnownType(typeof(SecuredMarketReport3Choice.Transaction))]
    [JsonDerivedType(typeof(SecuredMarketReport3Choice.DataSetAction),nameof(SecuredMarketReport3Choice.DataSetAction))]
    [JsonDerivedType(typeof(SecuredMarketReport3Choice.Transaction),nameof(SecuredMarketReport3Choice.Transaction))]
    [IsoId("_ghnREaidEeWHO_l3hf2rlA")]
    [DisplayName("Secured Market Report 3 Choice")]
    public abstract partial record SecuredMarketReport3Choice_
    {
    }
}
