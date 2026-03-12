// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason1Choice.Code))]
    [KnownType(typeof(FailingReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason1Choice.Code),nameof(FailingReason1Choice.Code))]
    [JsonDerivedType(typeof(FailingReason1Choice.Proprietary),nameof(FailingReason1Choice.Proprietary))]
    [IsoId("_UZqs8Np-Ed-ak6NoX_4Aeg_-144637934")]
    [DisplayName("Failing Reason 1 Choice")]
    public abstract partial record FailingReason1Choice_
    {
    }
}
