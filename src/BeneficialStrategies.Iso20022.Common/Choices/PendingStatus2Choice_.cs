// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action event processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus2Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus2Choice.NoSpecifiedReason),nameof(PendingStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus2Choice.Reason),nameof(PendingStatus2Choice.Reason))]
    [IsoId("_QxzOZNp-Ed-ak6NoX_4Aeg_-512158763")]
    [DisplayName("Pending Status 2 Choice")]
    public abstract partial record PendingStatus2Choice_
    {
    }
}
