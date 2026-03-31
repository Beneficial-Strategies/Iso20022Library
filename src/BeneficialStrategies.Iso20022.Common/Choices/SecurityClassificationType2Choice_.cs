// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a CFI code and an other type of identification for the classification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityClassificationType2Choice.CFI))]
    [KnownType(typeof(SecurityClassificationType2Choice.AlternateClassification))]
    [JsonDerivedType(
        typeof(SecurityClassificationType2Choice.CFI),
        nameof(SecurityClassificationType2Choice.CFI)
    )]
    [JsonDerivedType(
        typeof(SecurityClassificationType2Choice.AlternateClassification),
        nameof(SecurityClassificationType2Choice.AlternateClassification)
    )]
    [IsoId("_TrbgMW1MEeiqaPNRWUnGNA")]
    [DisplayName("Security Classification Type 2 Choice")]
    public abstract record SecurityClassificationType2Choice_ { }
}
