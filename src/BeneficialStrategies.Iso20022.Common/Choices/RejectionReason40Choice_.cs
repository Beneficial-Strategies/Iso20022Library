// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [KnownType(typeof(RejectionReason40Choice.Code))]
    [KnownType(typeof(RejectionReason40Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason40Choice.Code), nameof(RejectionReason40Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason40Choice.Proprietary),
        nameof(RejectionReason40Choice.Proprietary)
    )]
    [IsoId("_Uq4INRIwEeydmIVkS03esw")]
    [DisplayName("Rejection Reason 40 Choice")]
    public abstract record RejectionReason40Choice_ { }
}
