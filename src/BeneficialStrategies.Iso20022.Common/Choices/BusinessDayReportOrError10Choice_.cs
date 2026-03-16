// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between business day information details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(BusinessDayReportOrError10Choice.BusinessDayInformation))]
    [KnownType(typeof(BusinessDayReportOrError10Choice.BusinessError))]
    [JsonDerivedType(
        typeof(BusinessDayReportOrError10Choice.BusinessDayInformation),
        nameof(BusinessDayReportOrError10Choice.BusinessDayInformation)
    )]
    [JsonDerivedType(
        typeof(BusinessDayReportOrError10Choice.BusinessError),
        nameof(BusinessDayReportOrError10Choice.BusinessError)
    )]
    [IsoId("_ONBJt3XyEei3jO6riKEVXg")]
    [DisplayName("Business Day Report Or Error 10 Choice")]
    public abstract record BusinessDayReportOrError10Choice_ { }
}
