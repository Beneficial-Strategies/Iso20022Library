// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus36Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus36Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus36Choice.NoSpecifiedReason),
        nameof(PendingStatus36Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus36Choice.Reason), nameof(PendingStatus36Choice.Reason))]
    [IsoId("_kKulETp5EeWVrPy0StzzSg")]
    [DisplayName("Pending Status 36 Choice")]
    public abstract record PendingStatus36Choice_ { }
}
