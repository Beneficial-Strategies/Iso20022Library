// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the change type of a corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat5Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat5Choice.Code),nameof(CorporateActionChangeTypeFormat5Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat5Choice.Proprietary),nameof(CorporateActionChangeTypeFormat5Choice.Proprietary))]
    [IsoId("_HLlnMUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Corporate Action Change Type Format 5 Choice")]
    public abstract partial record CorporateActionChangeTypeFormat5Choice_
    {
    }
}
