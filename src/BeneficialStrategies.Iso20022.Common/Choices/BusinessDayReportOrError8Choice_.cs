// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between business day information details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(BusinessDayReportOrError8Choice.BusinessDayInformation))]
    [KnownType(typeof(BusinessDayReportOrError8Choice.BusinessError))]
    [JsonDerivedType(
        typeof(BusinessDayReportOrError8Choice.BusinessDayInformation),
        nameof(BusinessDayReportOrError8Choice.BusinessDayInformation)
    )]
    [JsonDerivedType(
        typeof(BusinessDayReportOrError8Choice.BusinessError),
        nameof(BusinessDayReportOrError8Choice.BusinessError)
    )]
    [IsoId("_wy9-B5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Day Report Or Error 8 Choice")]
    public abstract record BusinessDayReportOrError8Choice_ { }
}
