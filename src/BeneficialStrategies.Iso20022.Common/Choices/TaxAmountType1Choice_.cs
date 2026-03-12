// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the amount type.
    /// </summary>
    [KnownType(typeof(TaxAmountType1Choice.Code))]
    [KnownType(typeof(TaxAmountType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxAmountType1Choice.Code),nameof(TaxAmountType1Choice.Code))]
    [JsonDerivedType(typeof(TaxAmountType1Choice.Proprietary),nameof(TaxAmountType1Choice.Proprietary))]
    [IsoId("_tsra0lkyEeGeoaLUQk__nA_-1905418813")]
    [DisplayName("Tax Amount Type 1 Choice")]
    public abstract partial record TaxAmountType1Choice_
    {
    }
}
