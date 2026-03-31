// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the charge or commission basis.
    /// </summary>
    [KnownType(typeof(ChargeBasis2Choice.Code))]
    [KnownType(typeof(ChargeBasis2Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeBasis2Choice.Code), nameof(ChargeBasis2Choice.Code))]
    [JsonDerivedType(
        typeof(ChargeBasis2Choice.Proprietary),
        nameof(ChargeBasis2Choice.Proprietary)
    )]
    [IsoId("_1qZNADh5EeaH-93K5JKmzw")]
    [DisplayName("Charge Basis 2 Choice")]
    public abstract record ChargeBasis2Choice_ { }
}
