// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral status of an instruction.
    /// </summary>
    [KnownType(typeof(CollateralStatus3Choice.Pending))]
    [KnownType(typeof(CollateralStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(CollateralStatus3Choice.Pending),nameof(CollateralStatus3Choice.Pending))]
    [JsonDerivedType(typeof(CollateralStatus3Choice.Proprietary),nameof(CollateralStatus3Choice.Proprietary))]
    [IsoId("_K3a_kOCdEei2UYJ62ws-Fw")]
    [DisplayName("Collateral Status 3 Choice")]
    public abstract partial record CollateralStatus3Choice_
    {
    }
}
