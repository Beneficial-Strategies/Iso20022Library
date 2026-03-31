// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of political exposure.
    /// </summary>
    [KnownType(typeof(PoliticalExposureType2Choice.Code))]
    [KnownType(typeof(PoliticalExposureType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PoliticalExposureType2Choice.Code),
        nameof(PoliticalExposureType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PoliticalExposureType2Choice.Proprietary),
        nameof(PoliticalExposureType2Choice.Proprietary)
    )]
    [IsoId("_wSAccZUgEemC09f0MxYkRg")]
    [DisplayName("Political Exposure Type 2 Choice")]
    public abstract record PoliticalExposureType2Choice_ { }
}
