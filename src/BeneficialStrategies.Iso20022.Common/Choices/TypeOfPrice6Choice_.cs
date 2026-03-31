// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice6Choice.Code))]
    [KnownType(typeof(TypeOfPrice6Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice6Choice.Code), nameof(TypeOfPrice6Choice.Code))]
    [JsonDerivedType(
        typeof(TypeOfPrice6Choice.Proprietary),
        nameof(TypeOfPrice6Choice.Proprietary)
    )]
    [IsoId("_Qwdxpdp-Ed-ak6NoX_4Aeg_-1053429608")]
    [DisplayName("Type Of Price 6 Choice")]
    public abstract record TypeOfPrice6Choice_ { }
}
