// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the forex cancellation information.
    /// </summary>
    [KnownType(typeof(FXCancellation3Choice.Indicator))]
    [KnownType(typeof(FXCancellation3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FXCancellation3Choice.Indicator),
        nameof(FXCancellation3Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(FXCancellation3Choice.Proprietary),
        nameof(FXCancellation3Choice.Proprietary)
    )]
    [IsoId("_IHRikT0EEeWjqIDN7tjEjQ")]
    [DisplayName("FX Cancellation 3 Choice")]
    public abstract record FXCancellation3Choice_ { }
}
