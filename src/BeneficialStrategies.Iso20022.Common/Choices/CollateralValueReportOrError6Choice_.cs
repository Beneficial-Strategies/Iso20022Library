// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Business report on collateral value or business error.
    /// </summary>
    [KnownType(typeof(CollateralValueReportOrError6Choice.BusinessError))]
    [KnownType(typeof(CollateralValueReportOrError6Choice.CollateralValue))]
    [JsonDerivedType(
        typeof(CollateralValueReportOrError6Choice.BusinessError),
        nameof(CollateralValueReportOrError6Choice.BusinessError)
    )]
    [JsonDerivedType(
        typeof(CollateralValueReportOrError6Choice.CollateralValue),
        nameof(CollateralValueReportOrError6Choice.CollateralValue)
    )]
    [IsoId("_EFF_UTpyEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value Report Or Error 6 Choice")]
    public abstract record CollateralValueReportOrError6Choice_ { }
}
