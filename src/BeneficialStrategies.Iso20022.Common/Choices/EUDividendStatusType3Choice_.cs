// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, refund or redemption of shares and units.
    /// </summary>
    [KnownType(typeof(EUDividendStatusType3Choice.Code))]
    [KnownType(typeof(EUDividendStatusType3Choice.Proprietary))]
    [JsonDerivedType(typeof(EUDividendStatusType3Choice.Code), nameof(EUDividendStatusType3Choice.Code))]
    [JsonDerivedType(typeof(EUDividendStatusType3Choice.Proprietary), nameof(EUDividendStatusType3Choice.Proprietary))]
    [IsoId("d342294d-3920-49b3-a4d7-53550e73e181")]
    [DisplayName("EU Dividend Status Type 3 Choice")]
    public abstract record EUDividendStatusType3Choice_ { }
}
