// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat10Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat10Choice.Code),
        nameof(AdditionalBusinessProcessFormat10Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat10Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat10Choice.Proprietary)
    )]
    [IsoId("_mNJOwUGKEeWqy4niLuXETA")]
    [DisplayName("Additional Business Process Format 10 Choice")]
    public abstract record AdditionalBusinessProcessFormat10Choice_ { }
}
