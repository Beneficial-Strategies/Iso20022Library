// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option style.
    /// </summary>
    [KnownType(typeof(OptionStyle4Choice.Code))]
    [KnownType(typeof(OptionStyle4Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionStyle4Choice.Code),nameof(OptionStyle4Choice.Code))]
    [JsonDerivedType(typeof(OptionStyle4Choice.Proprietary),nameof(OptionStyle4Choice.Proprietary))]
    [IsoId("_Q4NYYtp-Ed-ak6NoX_4Aeg_1303508122")]
    [DisplayName("Option Style 4 Choice")]
    public abstract partial record OptionStyle4Choice_
    {
    }
}
