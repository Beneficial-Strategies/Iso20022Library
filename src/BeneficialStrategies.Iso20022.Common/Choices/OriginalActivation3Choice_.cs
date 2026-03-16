// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Original Activation3Choice.
    /// </summary>
    [KnownType(typeof(OriginalActivation3Choice.OriginalActivationData))]
    [KnownType(typeof(OriginalActivation3Choice.OriginalDebtorIdentification))]
    [JsonDerivedType(typeof(OriginalActivation3Choice.OriginalActivationData),nameof(OriginalActivation3Choice.OriginalActivationData))]
    [JsonDerivedType(typeof(OriginalActivation3Choice.OriginalDebtorIdentification),nameof(OriginalActivation3Choice.OriginalDebtorIdentification))]
    [IsoId("_wdEBmzEyEe6g-ffJsqGiSA")]
    [DisplayName("Original Activation3Choice")]
    public abstract partial record OriginalActivation3Choice_
    {
    }
}
