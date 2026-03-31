// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of the document line identification.
    /// </summary>
    [KnownType(typeof(DocumentLineType1Choice.Code))]
    [KnownType(typeof(DocumentLineType1Choice.Proprietary))]
    [JsonDerivedType(typeof(DocumentLineType1Choice.Code), nameof(DocumentLineType1Choice.Code))]
    [JsonDerivedType(
        typeof(DocumentLineType1Choice.Proprietary),
        nameof(DocumentLineType1Choice.Proprietary)
    )]
    [IsoId("__hXr4abkEeKvUvwX_r3tzA")]
    [DisplayName("Document Line Type 1 Choice")]
    public abstract record DocumentLineType1Choice_ { }
}
