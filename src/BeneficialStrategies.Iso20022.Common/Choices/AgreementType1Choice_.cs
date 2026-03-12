// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Classification of a master agreement.
    /// </summary>
    [KnownType(typeof(AgreementType1Choice.Type))]
    [KnownType(typeof(AgreementType1Choice.Proprietary))]
    [JsonDerivedType(typeof(AgreementType1Choice.Type),nameof(AgreementType1Choice.Type))]
    [JsonDerivedType(typeof(AgreementType1Choice.Proprietary),nameof(AgreementType1Choice.Proprietary))]
    [IsoId("_T1znoMkeEeeiAIB1i4AlQw")]
    [DisplayName("Agreement Type 1 Choice")]
    public abstract partial record AgreementType1Choice_
    {
    }
}
