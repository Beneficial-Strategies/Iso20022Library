// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the document type.
    /// </summary>
    [KnownType(typeof(DocumentType1Choice.Code))]
    [KnownType(typeof(DocumentType1Choice.Proprietary))]
    [JsonDerivedType(typeof(DocumentType1Choice.Code), nameof(DocumentType1Choice.Code))]
    [JsonDerivedType(
        typeof(DocumentType1Choice.Proprietary),
        nameof(DocumentType1Choice.Proprietary)
    )]
    [IsoId("_iYHUw3iJEeidzqjNEfehPg")]
    [DisplayName("Document Type 1 Choice")]
    public abstract record DocumentType1Choice_ { }
}
