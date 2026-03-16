// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the change type of a corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat1Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionChangeTypeFormat1Choice.Code),
        nameof(CorporateActionChangeTypeFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionChangeTypeFormat1Choice.Proprietary),
        nameof(CorporateActionChangeTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3Unldp-Ed-ak6NoX_4Aeg_524839573")]
    [DisplayName("Corporate Action Change Type Format 1 Choice")]
    public abstract record CorporateActionChangeTypeFormat1Choice_ { }
}
