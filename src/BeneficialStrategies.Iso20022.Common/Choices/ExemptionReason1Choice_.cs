// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the exemption reason.
    /// </summary>
    [KnownType(typeof(ExemptionReason1Choice.Code))]
    [KnownType(typeof(ExemptionReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ExemptionReason1Choice.Code),nameof(ExemptionReason1Choice.Code))]
    [JsonDerivedType(typeof(ExemptionReason1Choice.Proprietary),nameof(ExemptionReason1Choice.Proprietary))]
    [IsoId("_Qmk-8RuJEeOqSdXzJ0oydA")]
    [DisplayName("Exemption Reason 1 Choice")]
    public abstract partial record ExemptionReason1Choice_
    {
    }
}
