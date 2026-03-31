// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for a type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType6Choice.Code))]
    [KnownType(typeof(ChargeType6Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType6Choice.Code), nameof(ChargeType6Choice.Code))]
    [JsonDerivedType(typeof(ChargeType6Choice.Proprietary), nameof(ChargeType6Choice.Proprietary))]
    [IsoId("_h-65cYjKEeeqaMoyJI1HbA")]
    [DisplayName("Charge Type 6 Choice")]
    public abstract record ChargeType6Choice_ { }
}
