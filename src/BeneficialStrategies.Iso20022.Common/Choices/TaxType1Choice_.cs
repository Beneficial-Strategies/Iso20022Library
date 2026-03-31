// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of tax.
    /// </summary>
    [KnownType(typeof(TaxType1Choice.Code))]
    [KnownType(typeof(TaxType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxType1Choice.Code), nameof(TaxType1Choice.Code))]
    [JsonDerivedType(typeof(TaxType1Choice.Proprietary), nameof(TaxType1Choice.Proprietary))]
    [IsoId("_qVh7URuHEeOqSdXzJ0oydA")]
    [DisplayName("Tax Type 1 Choice")]
    public abstract record TaxType1Choice_ { }
}
