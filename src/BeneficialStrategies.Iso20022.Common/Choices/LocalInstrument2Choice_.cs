// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="ILocalInstrument2Choice"/>
    [KnownType(typeof(LocalInstrument2Choice.Code))]
    [KnownType(typeof(LocalInstrument2Choice.Proprietary))]
    [JsonDerivedType(typeof(LocalInstrument2Choice.Code), nameof(LocalInstrument2Choice.Code))]
    [JsonDerivedType(
        typeof(LocalInstrument2Choice.Proprietary),
        nameof(LocalInstrument2Choice.Proprietary)
    )]
    [IsoId("_TF7NItp-Ed-ak6NoX_4Aeg_365018897")]
    [DisplayName("Local Instrument 2 Choice")]
    public abstract partial record LocalInstrument2Choice_ { }
}
