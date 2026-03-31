// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code for specifying the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType2FormatChoice.Code))]
    [KnownType(typeof(ChargeType2FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType2FormatChoice.Code), nameof(ChargeType2FormatChoice.Code))]
    [JsonDerivedType(
        typeof(ChargeType2FormatChoice.Proprietary),
        nameof(ChargeType2FormatChoice.Proprietary)
    )]
    [IsoId("_Rl0FRNp-Ed-ak6NoX_4Aeg_-1615660129")]
    [DisplayName("Charge Type 2 Format Choice")]
    public abstract record ChargeType2FormatChoice_ { }
}
