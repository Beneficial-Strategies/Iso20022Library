// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the netting eligibility information.
    /// </summary>
    [KnownType(typeof(NettingEligibility1Choice.Indicator))]
    [KnownType(typeof(NettingEligibility1Choice.Proprietary))]
    [JsonDerivedType(typeof(NettingEligibility1Choice.Indicator),nameof(NettingEligibility1Choice.Indicator))]
    [JsonDerivedType(typeof(NettingEligibility1Choice.Proprietary),nameof(NettingEligibility1Choice.Proprietary))]
    [IsoId("_QvkZwdp-Ed-ak6NoX_4Aeg_-841042953")]
    [DisplayName("Netting Eligibility 1 Choice")]
    public abstract partial record NettingEligibility1Choice_
    {
    }
}
