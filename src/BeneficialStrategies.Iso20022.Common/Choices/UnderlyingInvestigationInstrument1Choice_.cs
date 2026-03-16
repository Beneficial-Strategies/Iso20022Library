// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Underlying Investigation Instrument1Choice.
    /// </summary>
    [KnownType(typeof(UnderlyingInvestigationInstrument1Choice.Code))]
    [KnownType(typeof(UnderlyingInvestigationInstrument1Choice.Proprietary))]
    [JsonDerivedType(typeof(UnderlyingInvestigationInstrument1Choice.Code),nameof(UnderlyingInvestigationInstrument1Choice.Code))]
    [JsonDerivedType(typeof(UnderlyingInvestigationInstrument1Choice.Proprietary),nameof(UnderlyingInvestigationInstrument1Choice.Proprietary))]
    [IsoId("_CXmpW1RtEe23M4WgERMsYw")]
    [DisplayName("Underlying Investigation Instrument1Choice")]
    public abstract partial record UnderlyingInvestigationInstrument1Choice_
    {
    }
}
