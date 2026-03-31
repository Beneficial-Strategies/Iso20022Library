// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral details for the secured markets.
    /// </summary>
    [KnownType(typeof(SecuredCollateral2Choice.SingleCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.MultipleCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.PoolCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.OtherCollateral))]
    [JsonDerivedType(
        typeof(SecuredCollateral2Choice.SingleCollateral),
        nameof(SecuredCollateral2Choice.SingleCollateral)
    )]
    [JsonDerivedType(
        typeof(SecuredCollateral2Choice.MultipleCollateral),
        nameof(SecuredCollateral2Choice.MultipleCollateral)
    )]
    [JsonDerivedType(
        typeof(SecuredCollateral2Choice.PoolCollateral),
        nameof(SecuredCollateral2Choice.PoolCollateral)
    )]
    [JsonDerivedType(
        typeof(SecuredCollateral2Choice.OtherCollateral),
        nameof(SecuredCollateral2Choice.OtherCollateral)
    )]
    [IsoId("_h6SUN6idEeWHO_l3hf2rlA")]
    [DisplayName("Secured Collateral 2 Choice")]
    public abstract record SecuredCollateral2Choice_ { }
}
