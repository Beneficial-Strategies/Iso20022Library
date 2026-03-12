// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the tax exemption reason.
    /// </summary>
    [KnownType(typeof(TaxExemptionReason2Choice.Code))]
    [KnownType(typeof(TaxExemptionReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxExemptionReason2Choice.Code),nameof(TaxExemptionReason2Choice.Code))]
    [JsonDerivedType(typeof(TaxExemptionReason2Choice.Proprietary),nameof(TaxExemptionReason2Choice.Proprietary))]
    [IsoId("_OpVJYSDAEeWPMvNwVtiMsA")]
    [DisplayName("Tax Exemption Reason 2 Choice")]
    public abstract partial record TaxExemptionReason2Choice_
    {
    }
}
