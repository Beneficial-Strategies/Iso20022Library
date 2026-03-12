// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the classification.
    /// </summary>
    [KnownType(typeof(ClassificationType2Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType2Choice.AlternateClassification))]
    [JsonDerivedType(typeof(ClassificationType2Choice.ClassificationFinancialInstrument),nameof(ClassificationType2Choice.ClassificationFinancialInstrument))]
    [JsonDerivedType(typeof(ClassificationType2Choice.AlternateClassification),nameof(ClassificationType2Choice.AlternateClassification))]
    [IsoId("_Q4NYZdp-Ed-ak6NoX_4Aeg_1716841988")]
    [DisplayName("Classification Type 2 Choice")]
    public abstract partial record ClassificationType2Choice_
    {
    }
}
