// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason1Choice.Code))]
    [KnownType(typeof(AcceptedReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason1Choice.Code),nameof(AcceptedReason1Choice.Code))]
    [JsonDerivedType(typeof(AcceptedReason1Choice.Proprietary),nameof(AcceptedReason1Choice.Proprietary))]
    [IsoId("_QyjcV9p-Ed-ak6NoX_4Aeg_831638355")]
    [DisplayName("Accepted Reason 1 Choice")]
    public abstract partial record AcceptedReason1Choice_
    {
    }
}
