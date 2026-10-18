// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IMandateSuspensionReason1Choice"/>
    [KnownType(typeof(MandateSuspensionReason1Choice.Code))]
    [KnownType(typeof(MandateSuspensionReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MandateSuspensionReason1Choice.Code),
        nameof(MandateSuspensionReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(MandateSuspensionReason1Choice.Proprietary),
        nameof(MandateSuspensionReason1Choice.Proprietary)
    )]
    [IsoId("_gW_7w4PDEeahmOIR_zFG6A")]
    [DisplayName("Mandate Suspension Reason 1 Choice")]
    public abstract partial record MandateSuspensionReason1Choice_ { }
}
