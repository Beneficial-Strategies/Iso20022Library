// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the presentation medium.
    /// </summary>
    [KnownType(typeof(PresentationMedium1Choice.Code))]
    [KnownType(typeof(PresentationMedium1Choice.Proprietary))]
    [JsonDerivedType(typeof(PresentationMedium1Choice.Code),nameof(PresentationMedium1Choice.Code))]
    [JsonDerivedType(typeof(PresentationMedium1Choice.Proprietary),nameof(PresentationMedium1Choice.Proprietary))]
    [IsoId("_93_1o3ltEeG7BsjMvd1mEw_-1462896243")]
    [DisplayName("Presentation Medium 1 Choice")]
    public abstract partial record PresentationMedium1Choice_
    {
    }
}
