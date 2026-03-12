// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason1Choice.Code))]
    [KnownType(typeof(RejectedReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason1Choice.Code),nameof(RejectedReason1Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason1Choice.Proprietary),nameof(RejectedReason1Choice.Proprietary))]
    [IsoId("_QyZrVtp-Ed-ak6NoX_4Aeg_31870116")]
    [DisplayName("Rejected Reason 1 Choice")]
    public abstract partial record RejectedReason1Choice_
    {
    }
}
