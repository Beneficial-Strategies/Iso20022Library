// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the request or status of a mandate.
    /// </summary>
    [KnownType(typeof(MandateReason1Choice.Code))]
    [KnownType(typeof(MandateReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(MandateReason1Choice.Code),nameof(MandateReason1Choice.Code))]
    [JsonDerivedType(typeof(MandateReason1Choice.Proprietary),nameof(MandateReason1Choice.Proprietary))]
    [IsoId("_TOt8xdp-Ed-ak6NoX_4Aeg_-162041513")]
    [DisplayName("Mandate Reason 1 Choice")]
    public abstract partial record MandateReason1Choice_
    {
    }
}
