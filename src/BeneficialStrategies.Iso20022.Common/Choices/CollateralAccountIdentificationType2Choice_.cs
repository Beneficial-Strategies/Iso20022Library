// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the identification of the collateral account.
    /// </summary>
    [KnownType(typeof(CollateralAccountIdentificationType2Choice.Type))]
    [KnownType(typeof(CollateralAccountIdentificationType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CollateralAccountIdentificationType2Choice.Type),
        nameof(CollateralAccountIdentificationType2Choice.Type)
    )]
    [JsonDerivedType(
        typeof(CollateralAccountIdentificationType2Choice.Proprietary),
        nameof(CollateralAccountIdentificationType2Choice.Proprietary)
    )]
    [IsoId("_Y-Lll4FxEeWtPe6Crjmeug")]
    [DisplayName("Collateral Account Identification Type 2 Choice")]
    public abstract record CollateralAccountIdentificationType2Choice_ { }
}
