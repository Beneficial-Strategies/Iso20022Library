// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType2Choice.Code))]
    [KnownType(typeof(FractionDispositionType2Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType2Choice.Code),nameof(FractionDispositionType2Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType2Choice.Proprietary),nameof(FractionDispositionType2Choice.Proprietary))]
    [IsoId("_Qzl-Jdp-Ed-ak6NoX_4Aeg_33258360")]
    [DisplayName("Fraction Disposition Type 2 Choice")]
    public abstract partial record FractionDispositionType2Choice_
    {
    }
}
