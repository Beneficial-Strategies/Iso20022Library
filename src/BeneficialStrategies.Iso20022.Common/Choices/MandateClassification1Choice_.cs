// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IMandateClassification1Choice"/>
    [KnownType(typeof(MandateClassification1Choice.Code))]
    [KnownType(typeof(MandateClassification1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MandateClassification1Choice.Code),
        nameof(MandateClassification1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(MandateClassification1Choice.Proprietary),
        nameof(MandateClassification1Choice.Proprietary)
    )]
    [IsoId("_JThtg2oDEearR-CA7eRZXQ")]
    [DisplayName("Mandate Classification 1 Choice")]
    public abstract partial record MandateClassification1Choice_ { }
}
