// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus3Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus3Choice.NoSpecifiedReason),nameof(PendingStatus3Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus3Choice.Reason),nameof(PendingStatus3Choice.Reason))]
    [IsoId("_UZ0d9tp-Ed-ak6NoX_4Aeg_1153241914")]
    [DisplayName("Pending Status 3 Choice")]
    public abstract partial record PendingStatus3Choice_
    {
    }
}
