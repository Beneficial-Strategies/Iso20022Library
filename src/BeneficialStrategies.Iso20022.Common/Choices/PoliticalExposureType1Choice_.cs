// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of political exposure.
    /// </summary>
    [KnownType(typeof(PoliticalExposureType1Choice.Code))]
    [KnownType(typeof(PoliticalExposureType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PoliticalExposureType1Choice.Code),
        nameof(PoliticalExposureType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PoliticalExposureType1Choice.Proprietary),
        nameof(PoliticalExposureType1Choice.Proprietary)
    )]
    [IsoId("_c6LHoRRvEeOKWo1NF21OVw")]
    [DisplayName("Political Exposure Type 1 Choice")]
    public abstract record PoliticalExposureType1Choice_ { }
}
