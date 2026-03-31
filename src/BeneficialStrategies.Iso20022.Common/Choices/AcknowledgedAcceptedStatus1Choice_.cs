// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus1Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus1Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus1Choice.Reason),
        nameof(AcknowledgedAcceptedStatus1Choice.Reason)
    )]
    [IsoId("_UUvwttp-Ed-ak6NoX_4Aeg_-1170810063")]
    [DisplayName("Acknowledged Accepted Status 1 Choice")]
    public abstract record AcknowledgedAcceptedStatus1Choice_ { }
}
