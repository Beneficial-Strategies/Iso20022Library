// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data on collateral used for the securities lending transaction.
    /// </summary>
    [KnownType(typeof(CollateralFlag13Choice.Collateralised))]
    [KnownType(typeof(CollateralFlag13Choice.Uncollateralised))]
    [JsonDerivedType(
        typeof(CollateralFlag13Choice.Collateralised),
        nameof(CollateralFlag13Choice.Collateralised)
    )]
    [JsonDerivedType(
        typeof(CollateralFlag13Choice.Uncollateralised),
        nameof(CollateralFlag13Choice.Uncollateralised)
    )]
    [IsoId("_J9q9scg5Eeu4ecZgAYuz5w")]
    [DisplayName("Collateral Flag 13 Choice")]
    public abstract record CollateralFlag13Choice_ { }
}
