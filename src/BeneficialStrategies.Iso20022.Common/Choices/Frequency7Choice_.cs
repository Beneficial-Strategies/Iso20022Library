// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, a payment frequency.
    /// </summary>
    [KnownType(typeof(Frequency7Choice.Code))]
    [KnownType(typeof(Frequency7Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency7Choice.Code),nameof(Frequency7Choice.Code))]
    [JsonDerivedType(typeof(Frequency7Choice.Proprietary),nameof(Frequency7Choice.Proprietary))]
    [IsoId("_AbpPpdokEeC60axPepSq7g_-321304304")]
    [DisplayName("Frequency 7 Choice")]
    public abstract partial record Frequency7Choice_
    {
    }
}
