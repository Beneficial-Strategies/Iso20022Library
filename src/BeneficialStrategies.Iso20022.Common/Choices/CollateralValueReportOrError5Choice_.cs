// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports on collateral values or error report in case of business processing of the related request.
    /// </summary>
    [KnownType(typeof(CollateralValueReportOrError5Choice.BusinessReport))]
    [KnownType(typeof(CollateralValueReportOrError5Choice.OperationalError))]
    [JsonDerivedType(
        typeof(CollateralValueReportOrError5Choice.BusinessReport),
        nameof(CollateralValueReportOrError5Choice.BusinessReport)
    )]
    [JsonDerivedType(
        typeof(CollateralValueReportOrError5Choice.OperationalError),
        nameof(CollateralValueReportOrError5Choice.OperationalError)
    )]
    [IsoId("_95GpHzpvEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value Report Or Error 5 Choice")]
    public abstract record CollateralValueReportOrError5Choice_ { }
}
