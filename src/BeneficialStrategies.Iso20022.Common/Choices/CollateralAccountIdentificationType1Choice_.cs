// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the identification of the collateral account.
    /// </summary>
    [KnownType(typeof(CollateralAccountIdentificationType1Choice.Type))]
    [KnownType(typeof(CollateralAccountIdentificationType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CollateralAccountIdentificationType1Choice.Type),
        nameof(CollateralAccountIdentificationType1Choice.Type)
    )]
    [JsonDerivedType(
        typeof(CollateralAccountIdentificationType1Choice.Proprietary),
        nameof(CollateralAccountIdentificationType1Choice.Proprietary)
    )]
    [IsoId("_vW0gN6MOEeCojJW5vEuTEQ_2023002417")]
    [DisplayName("Collateral Account Identification Type 1 Choice")]
    public abstract record CollateralAccountIdentificationType1Choice_ { }
}
