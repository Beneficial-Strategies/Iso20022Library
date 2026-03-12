// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus8Choice.Code))]
    [KnownType(typeof(AffirmationStatus8Choice.Proprietary))]
    [JsonDerivedType(typeof(AffirmationStatus8Choice.Code),nameof(AffirmationStatus8Choice.Code))]
    [JsonDerivedType(typeof(AffirmationStatus8Choice.Proprietary),nameof(AffirmationStatus8Choice.Proprietary))]
    [IsoId("_8H8LUTqpEeWyoP0PbocV1Q")]
    [DisplayName("Affirmation Status 8 Choice")]
    public abstract partial record AffirmationStatus8Choice_
    {
    }
}
