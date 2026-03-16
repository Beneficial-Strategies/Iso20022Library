// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of document format.
    /// </summary>
    [KnownType(typeof(PresentationDocumentFormat1Choice.Code))]
    [KnownType(typeof(PresentationDocumentFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PresentationDocumentFormat1Choice.Code),
        nameof(PresentationDocumentFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PresentationDocumentFormat1Choice.Proprietary),
        nameof(PresentationDocumentFormat1Choice.Proprietary)
    )]
    [IsoId("_94JmoHltEeG7BsjMvd1mEw_1618190567")]
    [DisplayName("Presentation Document Format 1 Choice")]
    public abstract record PresentationDocumentFormat1Choice_ { }
}
