// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the commission type.
    /// </summary>
    [KnownType(typeof(CommissionType3Choice.Code))]
    [KnownType(typeof(CommissionType3Choice.Proprietary))]
    [JsonDerivedType(typeof(CommissionType3Choice.Code),nameof(CommissionType3Choice.Code))]
    [JsonDerivedType(typeof(CommissionType3Choice.Proprietary),nameof(CommissionType3Choice.Proprietary))]
    [IsoId("_92zmwRuAEeOqSdXzJ0oydA")]
    [DisplayName("Commission Type 3 Choice")]
    public abstract partial record CommissionType3Choice_
    {
    }
}
