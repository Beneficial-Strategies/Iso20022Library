// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus30Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus30Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus30Choice.NoSpecifiedReason),nameof(RejectionStatus30Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus30Choice.Reason),nameof(RejectionStatus30Choice.Reason))]
    [IsoId("_tJ7YsekIEemm4qhb2yFPOw")]
    [DisplayName("Rejection Status 30 Choice")]
    public abstract partial record RejectionStatus30Choice_
    {
    }
}
