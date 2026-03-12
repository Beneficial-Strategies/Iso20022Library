// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of election movement.
    /// </summary>
    [KnownType(typeof(ElectionTypeFormat1Choice.Code))]
    [KnownType(typeof(ElectionTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(ElectionTypeFormat1Choice.Code),nameof(ElectionTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(ElectionTypeFormat1Choice.Proprietary),nameof(ElectionTypeFormat1Choice.Proprietary))]
    [IsoId("_Q3K2ktp-Ed-ak6NoX_4Aeg_1718215958")]
    [DisplayName("Election Type Format 1 Choice")]
    public abstract partial record ElectionTypeFormat1Choice_
    {
    }
}
