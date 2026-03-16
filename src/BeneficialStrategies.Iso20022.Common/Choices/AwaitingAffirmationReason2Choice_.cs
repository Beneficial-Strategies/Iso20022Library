// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the Awaiting Affirmation reason.
    /// </summary>
    [KnownType(typeof(AwaitingAffirmationReason2Choice.Code))]
    [KnownType(typeof(AwaitingAffirmationReason2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AwaitingAffirmationReason2Choice.Code),
        nameof(AwaitingAffirmationReason2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AwaitingAffirmationReason2Choice.Proprietary),
        nameof(AwaitingAffirmationReason2Choice.Proprietary)
    )]
    [IsoId("_mpdBZQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Awaiting Affirmation Reason 2 Choice")]
    public abstract record AwaitingAffirmationReason2Choice_ { }
}
