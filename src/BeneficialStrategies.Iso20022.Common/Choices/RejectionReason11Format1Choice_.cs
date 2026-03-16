// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejection Reason11Format1Choice.
    /// </summary>
    [KnownType(typeof(RejectionReason11Format1Choice.Code))]
    [KnownType(typeof(RejectionReason11Format1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionReason11Format1Choice.Code),
        nameof(RejectionReason11Format1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionReason11Format1Choice.Proprietary),
        nameof(RejectionReason11Format1Choice.Proprietary)
    )]
    [IsoId("_FCkl9VvFEe6gDOpEK7Q4ig")]
    [DisplayName("Rejection Reason11Format1Choice")]
    public abstract record RejectionReason11Format1Choice_ { }
}
