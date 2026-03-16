// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the document type.
    /// </summary>
    [KnownType(typeof(UndertakingDocumentType1Choice.Code))]
    [KnownType(typeof(UndertakingDocumentType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(UndertakingDocumentType1Choice.Code),
        nameof(UndertakingDocumentType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(UndertakingDocumentType1Choice.Proprietary),
        nameof(UndertakingDocumentType1Choice.Proprietary)
    )]
    [IsoId("_93jwwHltEeG7BsjMvd1mEw_-1256188382")]
    [DisplayName("Undertaking Document Type 1 Choice")]
    public abstract record UndertakingDocumentType1Choice_ { }
}
