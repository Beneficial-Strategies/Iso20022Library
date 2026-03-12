// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of reference.
    /// </summary>
    [KnownType(typeof(ReferenceType1Choice.Code))]
    [KnownType(typeof(ReferenceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReferenceType1Choice.Code),nameof(ReferenceType1Choice.Code))]
    [JsonDerivedType(typeof(ReferenceType1Choice.Proprietary),nameof(ReferenceType1Choice.Proprietary))]
    [IsoId("_Qjr00MeUEeysUoBKYz1Ytw")]
    [DisplayName("Reference Type 1 Choice")]
    public abstract partial record ReferenceType1Choice_
    {
    }
}
