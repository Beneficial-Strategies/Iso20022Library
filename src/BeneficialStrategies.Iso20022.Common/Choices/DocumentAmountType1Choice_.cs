// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IDocumentAmountType1Choice"/>
    [KnownType(typeof(DocumentAmountType1Choice.Code))]
    [KnownType(typeof(DocumentAmountType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DocumentAmountType1Choice.Code),
        nameof(DocumentAmountType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DocumentAmountType1Choice.Proprietary),
        nameof(DocumentAmountType1Choice.Proprietary)
    )]
    [IsoId("_9DBuYzH0Ee6BxvG014AZzQ")]
    [DisplayName("Document Amount Type1Choice")]
    public abstract partial record DocumentAmountType1Choice_ { }
}
