// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the beneficial ownership.
    /// </summary>
    [KnownType(typeof(BeneficialOwnership1Choice.Indicator))]
    [KnownType(typeof(BeneficialOwnership1Choice.Proprietary))]
    [JsonDerivedType(typeof(BeneficialOwnership1Choice.Indicator),nameof(BeneficialOwnership1Choice.Indicator))]
    [JsonDerivedType(typeof(BeneficialOwnership1Choice.Proprietary),nameof(BeneficialOwnership1Choice.Proprietary))]
    [IsoId("_QwBFsdp-Ed-ak6NoX_4Aeg_92509892")]
    [DisplayName("Beneficial Ownership 1 Choice")]
    public abstract partial record BeneficialOwnership1Choice_
    {
    }
}
