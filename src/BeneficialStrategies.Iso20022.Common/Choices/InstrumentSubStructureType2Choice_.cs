// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a instrument sub-structure type.
    /// </summary>
    [KnownType(typeof(InstrumentSubStructureType2Choice.Code))]
    [KnownType(typeof(InstrumentSubStructureType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InstrumentSubStructureType2Choice.Code),
        nameof(InstrumentSubStructureType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InstrumentSubStructureType2Choice.Proprietary),
        nameof(InstrumentSubStructureType2Choice.Proprietary)
    )]
    [IsoId("_QYb2YeLaEeWFtOV72FbX9w")]
    [DisplayName("Instrument Sub Structure Type 2 Choice")]
    public abstract record InstrumentSubStructureType2Choice_ { }
}
