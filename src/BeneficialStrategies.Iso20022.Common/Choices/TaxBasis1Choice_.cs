// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the tax basis.
    /// </summary>
    [KnownType(typeof(TaxBasis1Choice.Code))]
    [KnownType(typeof(TaxBasis1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxBasis1Choice.Code),nameof(TaxBasis1Choice.Code))]
    [JsonDerivedType(typeof(TaxBasis1Choice.Proprietary),nameof(TaxBasis1Choice.Proprietary))]
    [IsoId("_S9_-wRuIEeOqSdXzJ0oydA")]
    [DisplayName("Tax Basis 1 Choice")]
    public abstract partial record TaxBasis1Choice_
    {
    }
}
