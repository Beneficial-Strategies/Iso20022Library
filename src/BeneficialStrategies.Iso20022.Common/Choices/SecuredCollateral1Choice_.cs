// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral details for the secured markets.
    /// </summary>
    [KnownType(typeof(SecuredCollateral1Choice.SingleCollateral))]
    [KnownType(typeof(SecuredCollateral1Choice.MultipleCollateral))]
    [KnownType(typeof(SecuredCollateral1Choice.PoolCollateral))]
    [KnownType(typeof(SecuredCollateral1Choice.OtherCollateral))]
    [JsonDerivedType(typeof(SecuredCollateral1Choice.SingleCollateral),nameof(SecuredCollateral1Choice.SingleCollateral))]
    [JsonDerivedType(typeof(SecuredCollateral1Choice.MultipleCollateral),nameof(SecuredCollateral1Choice.MultipleCollateral))]
    [JsonDerivedType(typeof(SecuredCollateral1Choice.PoolCollateral),nameof(SecuredCollateral1Choice.PoolCollateral))]
    [JsonDerivedType(typeof(SecuredCollateral1Choice.OtherCollateral),nameof(SecuredCollateral1Choice.OtherCollateral))]
    [IsoId("_wmCdQJf5EeSfnc-VXAEapg")]
    [DisplayName("Secured Collateral 1 Choice")]
    public abstract partial record SecuredCollateral1Choice_
    {
    }
}
