// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a tax reference type.
    /// </summary>
    [KnownType(typeof(TaxReferenceType1Choice.Code))]
    [KnownType(typeof(TaxReferenceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxReferenceType1Choice.Code), nameof(TaxReferenceType1Choice.Code))]
    [JsonDerivedType(
        typeof(TaxReferenceType1Choice.Proprietary),
        nameof(TaxReferenceType1Choice.Proprietary)
    )]
    [IsoId("_PFD38E4REeiQHa-q1Uephw")]
    [DisplayName("Tax Reference Type 1 Choice")]
    public abstract record TaxReferenceType1Choice_ { }
}
