// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a CFI code and an other type of identification for the classification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityClassificationType3Choice.CFI))]
    [KnownType(typeof(SecurityClassificationType3Choice.AlternateClassification))]
    [JsonDerivedType(typeof(SecurityClassificationType3Choice.CFI),nameof(SecurityClassificationType3Choice.CFI))]
    [JsonDerivedType(typeof(SecurityClassificationType3Choice.AlternateClassification),nameof(SecurityClassificationType3Choice.AlternateClassification))]
    [IsoId("_R_yWIf35EeimOuZbLgw0bg")]
    [DisplayName("Security Classification Type 3 Choice")]
    public abstract partial record SecurityClassificationType3Choice_
    {
    }
}
