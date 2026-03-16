// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a financial instrument or of a non-equity sub-class
    /// </summary>
    [KnownType(typeof(InstrumentOrSubClassIdentification2Choice.ISINAndSubClass))]
    [KnownType(typeof(InstrumentOrSubClassIdentification2Choice.AssetClassAndSubClass))]
    [JsonDerivedType(
        typeof(InstrumentOrSubClassIdentification2Choice.ISINAndSubClass),
        nameof(InstrumentOrSubClassIdentification2Choice.ISINAndSubClass)
    )]
    [JsonDerivedType(
        typeof(InstrumentOrSubClassIdentification2Choice.AssetClassAndSubClass),
        nameof(InstrumentOrSubClassIdentification2Choice.AssetClassAndSubClass)
    )]
    [IsoId("_BRbDkaaUEeqZmriXpMtonA")]
    [DisplayName("Instrument Or Sub Class Identification 2 Choice")]
    public abstract record InstrumentOrSubClassIdentification2Choice_ { }
}
