// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of insurance.
    /// </summary>
    [KnownType(typeof(InsuranceType2Choice.Code))]
    [KnownType(typeof(InsuranceType2Choice.Proprietary))]
    [JsonDerivedType(typeof(InsuranceType2Choice.Code),nameof(InsuranceType2Choice.Code))]
    [JsonDerivedType(typeof(InsuranceType2Choice.Proprietary),nameof(InsuranceType2Choice.Proprietary))]
    [IsoId("_7iIRISGSEeWKAaDJcYGKLw")]
    [DisplayName("Insurance Type 2 Choice")]
    public abstract partial record InsuranceType2Choice_
    {
    }
}
