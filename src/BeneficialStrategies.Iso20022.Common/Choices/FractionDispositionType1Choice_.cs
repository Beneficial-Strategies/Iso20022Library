// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType1Choice.Code))]
    [KnownType(typeof(FractionDispositionType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FractionDispositionType1Choice.Code),
        nameof(FractionDispositionType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FractionDispositionType1Choice.Proprietary),
        nameof(FractionDispositionType1Choice.Proprietary)
    )]
    [IsoId("_Q1FL4dp-Ed-ak6NoX_4Aeg_1073540424")]
    [DisplayName("Fraction Disposition Type 1 Choice")]
    public abstract record FractionDispositionType1Choice_ { }
}
