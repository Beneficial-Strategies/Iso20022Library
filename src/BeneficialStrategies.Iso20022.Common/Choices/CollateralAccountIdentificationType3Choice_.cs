// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the identification of the collateral account.
    /// </summary>
    [KnownType(typeof(CollateralAccountIdentificationType3Choice.Type))]
    [KnownType(typeof(CollateralAccountIdentificationType3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CollateralAccountIdentificationType3Choice.Type),
        nameof(CollateralAccountIdentificationType3Choice.Type)
    )]
    [JsonDerivedType(
        typeof(CollateralAccountIdentificationType3Choice.Proprietary),
        nameof(CollateralAccountIdentificationType3Choice.Proprietary)
    )]
    [IsoId("_03MJ4a_XEeaiqo1qOdNaWg")]
    [DisplayName("Collateral Account Identification Type 3 Choice")]
    public abstract record CollateralAccountIdentificationType3Choice_ { }
}
