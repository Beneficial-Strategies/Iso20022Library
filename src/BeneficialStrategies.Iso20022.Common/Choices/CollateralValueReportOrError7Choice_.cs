// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Collateral Value Report Or Error7Choice.
    /// </summary>
    [KnownType(typeof(CollateralValueReportOrError7Choice.BusinessReport))]
    [KnownType(typeof(CollateralValueReportOrError7Choice.OperationalError))]
    [JsonDerivedType(typeof(CollateralValueReportOrError7Choice.BusinessReport),nameof(CollateralValueReportOrError7Choice.BusinessReport))]
    [JsonDerivedType(typeof(CollateralValueReportOrError7Choice.OperationalError),nameof(CollateralValueReportOrError7Choice.OperationalError))]
    [IsoId("_zDi7oTEyEe6g-ffJsqGiSA")]
    [DisplayName("Collateral Value Report Or Error7Choice")]
    public abstract partial record CollateralValueReportOrError7Choice_
    {
    }
}
