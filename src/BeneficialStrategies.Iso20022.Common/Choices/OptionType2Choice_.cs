// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option type.
    /// </summary>
    [KnownType(typeof(OptionType2Choice.Code))]
    [KnownType(typeof(OptionType2Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionType2Choice.Code), nameof(OptionType2Choice.Code))]
    [JsonDerivedType(typeof(OptionType2Choice.Proprietary), nameof(OptionType2Choice.Proprietary))]
    [IsoId("_Qu-j4Np-Ed-ak6NoX_4Aeg_-1994386821")]
    [DisplayName("Option Type 2 Choice")]
    public abstract record OptionType2Choice_ { }
}
