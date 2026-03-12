// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of beneficiary.
    /// </summary>
    [KnownType(typeof(BeneficiaryType1Choice.Code))]
    [KnownType(typeof(BeneficiaryType1Choice.Proprietary))]
    [JsonDerivedType(typeof(BeneficiaryType1Choice.Code),nameof(BeneficiaryType1Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryType1Choice.Proprietary),nameof(BeneficiaryType1Choice.Proprietary))]
    [IsoId("_xDPgIFNgEeijdq8ilaxyOA")]
    [DisplayName("Beneficiary Type 1 Choice")]
    public abstract partial record BeneficiaryType1Choice_
    {
    }
}
