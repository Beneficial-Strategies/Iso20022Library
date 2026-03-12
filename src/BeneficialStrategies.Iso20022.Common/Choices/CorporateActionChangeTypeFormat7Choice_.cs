// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify a type of change.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat7Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat7Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat7Choice.Code),nameof(CorporateActionChangeTypeFormat7Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat7Choice.Proprietary),nameof(CorporateActionChangeTypeFormat7Choice.Proprietary))]
    [IsoId("_cheMk5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Change Type Format 7 Choice")]
    public abstract partial record CorporateActionChangeTypeFormat7Choice_
    {
    }
}
