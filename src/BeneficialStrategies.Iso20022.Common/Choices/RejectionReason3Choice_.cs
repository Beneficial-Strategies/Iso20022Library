// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides a reason for rejection identified using a code or a data source scheme.
    /// </summary>
    [KnownType(typeof(RejectionReason3Choice.Code))]
    [KnownType(typeof(RejectionReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason3Choice.Code),nameof(RejectionReason3Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason3Choice.Proprietary),nameof(RejectionReason3Choice.Proprietary))]
    [IsoId("_Q9lAk9p-Ed-ak6NoX_4Aeg_433100645")]
    [DisplayName("Rejection Reason 3 Choice")]
    public abstract partial record RejectionReason3Choice_
    {
    }
}
