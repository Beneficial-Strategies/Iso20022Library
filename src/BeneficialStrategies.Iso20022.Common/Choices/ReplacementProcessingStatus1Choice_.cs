// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the replacement processing status.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus1Choice.Code))]
    [KnownType(typeof(ReplacementProcessingStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus1Choice.Code),nameof(ReplacementProcessingStatus1Choice.Code))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus1Choice.Proprietary),nameof(ReplacementProcessingStatus1Choice.Proprietary))]
    [IsoId("_UXSHUNp-Ed-ak6NoX_4Aeg_-220686671")]
    [DisplayName("Replacement Processing Status 1 Choice")]
    public abstract partial record ReplacementProcessingStatus1Choice_
    {
    }
}
