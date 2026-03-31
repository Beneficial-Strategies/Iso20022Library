// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data on collateral used for the securities lending transaction.
    /// </summary>
    [KnownType(typeof(CollateralFlag10Choice.Collateralised))]
    [KnownType(typeof(CollateralFlag10Choice.Uncollateralised))]
    [JsonDerivedType(
        typeof(CollateralFlag10Choice.Collateralised),
        nameof(CollateralFlag10Choice.Collateralised)
    )]
    [JsonDerivedType(
        typeof(CollateralFlag10Choice.Uncollateralised),
        nameof(CollateralFlag10Choice.Uncollateralised)
    )]
    [IsoId("_gDYXUQAAEeqefbt-QjTNnA")]
    [DisplayName("Collateral Flag 10 Choice")]
    public abstract record CollateralFlag10Choice_ { }
}
