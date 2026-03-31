// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType1Choice.Code))]
    [KnownType(typeof(ExposureType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ExposureType1Choice.Code), nameof(ExposureType1Choice.Code))]
    [JsonDerivedType(
        typeof(ExposureType1Choice.Proprietary),
        nameof(ExposureType1Choice.Proprietary)
    )]
    [IsoId("_QuOV8Np-Ed-ak6NoX_4Aeg_547934852")]
    [DisplayName("Exposure Type 1 Choice")]
    public abstract record ExposureType1Choice_ { }
}
