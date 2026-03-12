// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice4Choice.Code))]
    [KnownType(typeof(TypeOfPrice4Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice4Choice.Code),nameof(TypeOfPrice4Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice4Choice.Proprietary),nameof(TypeOfPrice4Choice.Proprietary))]
    [IsoId("_Qwm7kNp-Ed-ak6NoX_4Aeg_1261308735")]
    [DisplayName("Type Of Price 4 Choice")]
    public abstract partial record TypeOfPrice4Choice_
    {
    }
}
