// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the collateral type.
    /// </summary>
    [KnownType(typeof(CollateralType1Choice.Code))]
    [KnownType(typeof(CollateralType1Choice.Proprietary))]
    [JsonDerivedType(typeof(CollateralType1Choice.Code), nameof(CollateralType1Choice.Code))]
    [JsonDerivedType(
        typeof(CollateralType1Choice.Proprietary),
        nameof(CollateralType1Choice.Proprietary)
    )]
    [IsoId("_AYhDItokEeC60axPepSq7g_4649686")]
    [DisplayName("Collateral Type 1 Choice")]
    public abstract record CollateralType1Choice_ { }
}
