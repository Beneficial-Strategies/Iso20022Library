// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus10Choice.Code))]
    [KnownType(typeof(AffirmationStatus10Choice.Proprietary))]
    [JsonDerivedType(typeof(AffirmationStatus10Choice.Code),nameof(AffirmationStatus10Choice.Code))]
    [JsonDerivedType(typeof(AffirmationStatus10Choice.Proprietary),nameof(AffirmationStatus10Choice.Proprietary))]
    [IsoId("_O8WS8Qd3Ee2fOITqoTnSLQ")]
    [DisplayName("Affirmation Status 10 Choice")]
    public abstract partial record AffirmationStatus10Choice_
    {
    }
}
