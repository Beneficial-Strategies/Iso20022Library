// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify a type of change.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat2Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat2Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat2Choice.Code),nameof(CorporateActionChangeTypeFormat2Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionChangeTypeFormat2Choice.Proprietary),nameof(CorporateActionChangeTypeFormat2Choice.Proprietary))]
    [IsoId("_Qzl-Itp-Ed-ak6NoX_4Aeg_-953922271")]
    [DisplayName("Corporate Action Change Type Format 2 Choice")]
    public abstract partial record CorporateActionChangeTypeFormat2Choice_
    {
    }
}
