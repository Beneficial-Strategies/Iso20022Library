// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the EU dividend status type.
    /// </summary>
    [KnownType(typeof(EUDividendStatusType2Choice.Code))]
    [KnownType(typeof(EUDividendStatusType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(EUDividendStatusType2Choice.Code),
        nameof(EUDividendStatusType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(EUDividendStatusType2Choice.Proprietary),
        nameof(EUDividendStatusType2Choice.Proprietary)
    )]
    [IsoId("_PfdboTh8EeaH-93K5JKmzw")]
    [DisplayName("EU Dividend Status Type 2 Choice")]
    public abstract record EUDividendStatusType2Choice_ { }
}
