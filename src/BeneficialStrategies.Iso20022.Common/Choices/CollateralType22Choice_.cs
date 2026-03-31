// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Collateral Type22Choice.
    /// </summary>
    [KnownType(typeof(CollateralType22Choice.GeneralCollateral))]
    [KnownType(typeof(CollateralType22Choice.SpecificCollateral))]
    [JsonDerivedType(
        typeof(CollateralType22Choice.GeneralCollateral),
        nameof(CollateralType22Choice.GeneralCollateral)
    )]
    [JsonDerivedType(
        typeof(CollateralType22Choice.SpecificCollateral),
        nameof(CollateralType22Choice.SpecificCollateral)
    )]
    [IsoId("_wj3iwChKEe2H2s7qerne1w")]
    [DisplayName("Collateral Type22Choice")]
    public abstract record CollateralType22Choice_ { }
}
