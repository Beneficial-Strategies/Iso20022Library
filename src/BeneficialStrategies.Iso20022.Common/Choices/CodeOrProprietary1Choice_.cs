// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between an ISO 20022 code and a proprietary code.
    /// </summary>
    [KnownType(typeof(CodeOrProprietary1Choice.Code))]
    [KnownType(typeof(CodeOrProprietary1Choice.Proprietary))]
    [JsonDerivedType(typeof(CodeOrProprietary1Choice.Code), nameof(CodeOrProprietary1Choice.Code))]
    [JsonDerivedType(
        typeof(CodeOrProprietary1Choice.Proprietary),
        nameof(CodeOrProprietary1Choice.Proprietary)
    )]
    [IsoId("_Qotj1tp-Ed-ak6NoX_4Aeg_-1810617673")]
    [DisplayName("Code Or Proprietary 1 Choice")]
    public abstract record CodeOrProprietary1Choice_ { }
}
