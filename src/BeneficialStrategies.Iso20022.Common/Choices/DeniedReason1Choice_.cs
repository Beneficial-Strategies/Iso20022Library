// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason1Choice.Code))]
    [KnownType(typeof(DeniedReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason1Choice.Code),nameof(DeniedReason1Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason1Choice.Proprietary),nameof(DeniedReason1Choice.Proprietary))]
    [IsoId("_UX39Ndp-Ed-ak6NoX_4Aeg_1867774122")]
    [DisplayName("Denied Reason 1 Choice")]
    public abstract partial record DeniedReason1Choice_
    {
    }
}
