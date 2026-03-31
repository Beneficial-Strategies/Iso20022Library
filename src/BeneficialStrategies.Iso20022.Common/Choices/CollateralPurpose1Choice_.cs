// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a proprietary code for collateral purpose.
    /// </summary>
    [KnownType(typeof(CollateralPurpose1Choice.Code))]
    [KnownType(typeof(CollateralPurpose1Choice.Proprietary))]
    [JsonDerivedType(typeof(CollateralPurpose1Choice.Code), nameof(CollateralPurpose1Choice.Code))]
    [JsonDerivedType(
        typeof(CollateralPurpose1Choice.Proprietary),
        nameof(CollateralPurpose1Choice.Proprietary)
    )]
    [IsoId("_Qkr_c9p-Ed-ak6NoX_4Aeg_1939659282")]
    [DisplayName("Collateral Purpose 1 Choice")]
    public abstract record CollateralPurpose1Choice_ { }
}
