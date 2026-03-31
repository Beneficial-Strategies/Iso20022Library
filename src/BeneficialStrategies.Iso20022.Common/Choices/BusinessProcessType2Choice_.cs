// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the business process type.
    /// </summary>
    [KnownType(typeof(BusinessProcessType2Choice.Code))]
    [KnownType(typeof(BusinessProcessType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BusinessProcessType2Choice.Code),
        nameof(BusinessProcessType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(BusinessProcessType2Choice.Proprietary),
        nameof(BusinessProcessType2Choice.Proprietary)
    )]
    [IsoId("_0hNQAZBgEeakHoV5BVecAQ")]
    [DisplayName("Business Process Type 2 Choice")]
    public abstract record BusinessProcessType2Choice_ { }
}
