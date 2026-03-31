// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason5Choice.Code))]
    [KnownType(typeof(RejectionReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason5Choice.Code), nameof(RejectionReason5Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason5Choice.Proprietary),
        nameof(RejectionReason5Choice.Proprietary)
    )]
    [IsoId("_UYLfM9p-Ed-ak6NoX_4Aeg_743710403")]
    [DisplayName("Rejection Reason 5 Choice")]
    public abstract record RejectionReason5Choice_ { }
}
