// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason1Choice.Code))]
    [KnownType(typeof(CancelledReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason1Choice.Code),nameof(CancelledReason1Choice.Code))]
    [JsonDerivedType(typeof(CancelledReason1Choice.Proprietary),nameof(CancelledReason1Choice.Proprietary))]
    [IsoId("_QysmSNp-Ed-ak6NoX_4Aeg_503789636")]
    [DisplayName("Cancelled Reason 1 Choice")]
    public abstract partial record CancelledReason1Choice_
    {
    }
}
