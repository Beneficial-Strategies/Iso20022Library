// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of insurance.
    /// </summary>
    [KnownType(typeof(InsuranceType1Choice.Code))]
    [KnownType(typeof(InsuranceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(InsuranceType1Choice.Code),nameof(InsuranceType1Choice.Code))]
    [JsonDerivedType(typeof(InsuranceType1Choice.Proprietary),nameof(InsuranceType1Choice.Proprietary))]
    [IsoId("_ckqDQBQZEeKebsB9eKJSkA")]
    [DisplayName("Insurance Type 1 Choice")]
    public abstract partial record InsuranceType1Choice_
    {
    }
}
