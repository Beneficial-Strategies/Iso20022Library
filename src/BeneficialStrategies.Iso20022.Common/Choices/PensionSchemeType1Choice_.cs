// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of pension scheme.
    /// </summary>
    [KnownType(typeof(PensionSchemeType1Choice.Code))]
    [KnownType(typeof(PensionSchemeType1Choice.Proprietary))]
    [JsonDerivedType(typeof(PensionSchemeType1Choice.Code), nameof(PensionSchemeType1Choice.Code))]
    [JsonDerivedType(
        typeof(PensionSchemeType1Choice.Proprietary),
        nameof(PensionSchemeType1Choice.Proprietary)
    )]
    [IsoId("_G5FcYE4OEeiQHa-q1Uephw")]
    [DisplayName("Pension Scheme Type 1 Choice")]
    public abstract record PensionSchemeType1Choice_ { }
}
