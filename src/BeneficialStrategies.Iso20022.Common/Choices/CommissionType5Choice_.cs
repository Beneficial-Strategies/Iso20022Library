// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the commission type.
    /// </summary>
    [KnownType(typeof(CommissionType5Choice.Code))]
    [KnownType(typeof(CommissionType5Choice.Proprietary))]
    [JsonDerivedType(typeof(CommissionType5Choice.Code), nameof(CommissionType5Choice.Code))]
    [JsonDerivedType(
        typeof(CommissionType5Choice.Proprietary),
        nameof(CommissionType5Choice.Proprietary)
    )]
    [IsoId("_sQfTQWW6EeSHcOWXSsMhqw")]
    [DisplayName("Commission Type 5 Choice")]
    public abstract record CommissionType5Choice_ { }
}
