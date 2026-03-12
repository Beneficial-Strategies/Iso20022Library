// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between business day information details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(BusinessDayReportOrError9Choice.BusinessReport))]
    [KnownType(typeof(BusinessDayReportOrError9Choice.OperationalError))]
    [JsonDerivedType(typeof(BusinessDayReportOrError9Choice.BusinessReport),nameof(BusinessDayReportOrError9Choice.BusinessReport))]
    [JsonDerivedType(typeof(BusinessDayReportOrError9Choice.OperationalError),nameof(BusinessDayReportOrError9Choice.OperationalError))]
    [IsoId("_N58csXXyEei3jO6riKEVXg")]
    [DisplayName("Business Day Report Or Error 9 Choice")]
    public abstract partial record BusinessDayReportOrError9Choice_
    {
    }
}
