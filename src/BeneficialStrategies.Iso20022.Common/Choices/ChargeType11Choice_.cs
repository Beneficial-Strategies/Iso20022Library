// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [KnownType(typeof(ChargeType11Choice.Code))]
    [KnownType(typeof(ChargeType11Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType11Choice.Code), nameof(ChargeType11Choice.Code))]
    [JsonDerivedType(typeof(ChargeType11Choice.Proprietary), nameof(ChargeType11Choice.Proprietary))]
    [IsoId("5be61446-0952-4f87-ab7f-d2e9bfdfe947")]
    [DisplayName("Charge Type 11 Choice")]
    public abstract record ChargeType11Choice_ { }
}
