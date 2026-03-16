// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejection Reason6Format1Choice.
    /// </summary>
    [KnownType(typeof(RejectionReason6Format1Choice.Code))]
    [KnownType(typeof(RejectionReason6Format1Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason6Format1Choice.Code),nameof(RejectionReason6Format1Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason6Format1Choice.Proprietary),nameof(RejectionReason6Format1Choice.Proprietary))]
    [IsoId("_m9QA5VuzEe6gDOpEK7Q4ig")]
    [DisplayName("Rejection Reason6Format1Choice")]
    public abstract partial record RejectionReason6Format1Choice_
    {
    }
}
