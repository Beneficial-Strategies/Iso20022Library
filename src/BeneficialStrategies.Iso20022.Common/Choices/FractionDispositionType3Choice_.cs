// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType3Choice.Code))]
    [KnownType(typeof(FractionDispositionType3Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType3Choice.Code),nameof(FractionDispositionType3Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType3Choice.Proprietary),nameof(FractionDispositionType3Choice.Proprietary))]
    [IsoId("_QzJSMNp-Ed-ak6NoX_4Aeg_1234427512")]
    [DisplayName("Fraction Disposition Type 3 Choice")]
    public abstract partial record FractionDispositionType3Choice_
    {
    }
}
