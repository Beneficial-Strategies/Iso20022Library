// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the change type of a corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat8Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat8Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat8Choice.Code),nameof(CorporateActionChangeTypeFormat8Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat8Choice.Proprietary),nameof(CorporateActionChangeTypeFormat8Choice.Proprietary))]
    [IsoId("_c5V6a5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Change Type Format 8 Choice")]
    public abstract partial record CorporateActionChangeTypeFormat8Choice_
    {
    }
}
