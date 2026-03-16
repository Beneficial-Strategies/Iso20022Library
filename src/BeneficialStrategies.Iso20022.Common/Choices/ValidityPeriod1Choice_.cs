// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Validity Period1Choice.
    /// </summary>
    [KnownType(typeof(ValidityPeriod1Choice.Proprietary))]
    [KnownType(typeof(ValidityPeriod1Choice.ValidityPeriodCode))]
    [JsonDerivedType(typeof(ValidityPeriod1Choice.Proprietary),nameof(ValidityPeriod1Choice.Proprietary))]
    [JsonDerivedType(typeof(ValidityPeriod1Choice.ValidityPeriodCode),nameof(ValidityPeriod1Choice.ValidityPeriodCode))]
    [IsoId("_SDXf4GscEe25qph5Y8_eYQ")]
    [DisplayName("Validity Period1Choice")]
    public abstract partial record ValidityPeriod1Choice_
    {
    }
}
