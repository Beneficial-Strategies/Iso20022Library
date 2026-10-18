// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="ILocalInstrument1Choice"/>
    [KnownType(typeof(LocalInstrument1Choice.Code))]
    [KnownType(typeof(LocalInstrument1Choice.Proprietary))]
    [JsonDerivedType(typeof(LocalInstrument1Choice.Code), nameof(LocalInstrument1Choice.Code))]
    [JsonDerivedType(
        typeof(LocalInstrument1Choice.Proprietary),
        nameof(LocalInstrument1Choice.Proprietary)
    )]
    [IsoId("_TGhDB9p-Ed-ak6NoX_4Aeg_-2017969290")]
    [DisplayName("Local Instrument 1 Choice")]
    public abstract partial record LocalInstrument1Choice_ { }
}
