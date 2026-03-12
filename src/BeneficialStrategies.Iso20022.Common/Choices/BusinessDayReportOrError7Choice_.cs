// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between business day information details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(BusinessDayReportOrError7Choice.BusinessReport))]
    [KnownType(typeof(BusinessDayReportOrError7Choice.OperationalError))]
    [JsonDerivedType(typeof(BusinessDayReportOrError7Choice.BusinessReport),nameof(BusinessDayReportOrError7Choice.BusinessReport))]
    [JsonDerivedType(typeof(BusinessDayReportOrError7Choice.OperationalError),nameof(BusinessDayReportOrError7Choice.OperationalError))]
    [IsoId("_wiKh4ZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Day Report Or Error 7 Choice")]
    public abstract partial record BusinessDayReportOrError7Choice_
    {
    }
}
