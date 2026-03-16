// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the FX cancellation information.
    /// </summary>
    [KnownType(typeof(FXCancellation1Choice.Indicator))]
    [KnownType(typeof(FXCancellation1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FXCancellation1Choice.Indicator),
        nameof(FXCancellation1Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(FXCancellation1Choice.Proprietary),
        nameof(FXCancellation1Choice.Proprietary)
    )]
    [IsoId("_QtVlIdp-Ed-ak6NoX_4Aeg_615585032")]
    [DisplayName("FX Cancellation 1 Choice")]
    public abstract record FXCancellation1Choice_ { }
}
