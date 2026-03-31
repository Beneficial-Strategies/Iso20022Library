// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the clearing system identification.
    /// </summary>
    [KnownType(typeof(ClearingSystemIdentification3Choice.Code))]
    [KnownType(typeof(ClearingSystemIdentification3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ClearingSystemIdentification3Choice.Code),
        nameof(ClearingSystemIdentification3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemIdentification3Choice.Proprietary),
        nameof(ClearingSystemIdentification3Choice.Proprietary)
    )]
    [IsoId("_TMVXJdp-Ed-ak6NoX_4Aeg_948374898")]
    [DisplayName("Clearing System Identification 3 Choice")]
    public abstract record ClearingSystemIdentification3Choice_ { }
}
