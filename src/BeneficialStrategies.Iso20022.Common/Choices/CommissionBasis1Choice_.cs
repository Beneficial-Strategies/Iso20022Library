// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the commission basis.
    /// </summary>
    [KnownType(typeof(CommissionBasis1Choice.Code))]
    [KnownType(typeof(CommissionBasis1Choice.Proprietary))]
    [JsonDerivedType(typeof(CommissionBasis1Choice.Code),nameof(CommissionBasis1Choice.Code))]
    [JsonDerivedType(typeof(CommissionBasis1Choice.Proprietary),nameof(CommissionBasis1Choice.Proprietary))]
    [IsoId("_LgZzgRuCEeOqSdXzJ0oydA")]
    [DisplayName("Commission Basis 1 Choice")]
    public abstract partial record CommissionBasis1Choice_
    {
    }
}
