// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of modification processing status.
    /// </summary>
    [KnownType(typeof(ModificationProcessingStatus9Choice.Code))]
    [KnownType(typeof(ModificationProcessingStatus9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus9Choice.Code),
        nameof(ModificationProcessingStatus9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus9Choice.Proprietary),
        nameof(ModificationProcessingStatus9Choice.Proprietary)
    )]
    [IsoId("_w6pyceF8EeWCAvUNsZ5u6g")]
    [DisplayName("Modification Processing Status 9 Choice")]
    public abstract record ModificationProcessingStatus9Choice_ { }
}
