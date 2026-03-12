// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of an exemption reason type.
    /// </summary>
    [KnownType(typeof(ExemptionReasonType1Choice.ExemptionReason))]
    [KnownType(typeof(ExemptionReasonType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ExemptionReasonType1Choice.ExemptionReason),nameof(ExemptionReasonType1Choice.ExemptionReason))]
    [JsonDerivedType(typeof(ExemptionReasonType1Choice.Proprietary),nameof(ExemptionReasonType1Choice.Proprietary))]
    [IsoId("_RgSsGNp-Ed-ak6NoX_4Aeg_340862287")]
    [DisplayName("Exemption Reason Type 1 Choice")]
    public abstract partial record ExemptionReasonType1Choice_
    {
    }
}
