// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IPurpose2Choice"/>
    [KnownType(typeof(Purpose2Choice.Code))]
    [KnownType(typeof(Purpose2Choice.Proprietary))]
    [JsonDerivedType(typeof(Purpose2Choice.Code), nameof(Purpose2Choice.Code))]
    [JsonDerivedType(typeof(Purpose2Choice.Proprietary), nameof(Purpose2Choice.Proprietary))]
    [IsoId("_P6qyHtp-Ed-ak6NoX_4Aeg_-1283223379")]
    [DisplayName("Purpose 2 Choice")]
    public abstract partial record Purpose2Choice_ { }
}
