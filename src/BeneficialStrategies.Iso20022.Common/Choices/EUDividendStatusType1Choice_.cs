// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of an EU dividen status type.
    /// </summary>
    [KnownType(typeof(EUDividendStatusType1Choice.EUDividendStatus))]
    [KnownType(typeof(EUDividendStatusType1Choice.Proprietary))]
    [JsonDerivedType(typeof(EUDividendStatusType1Choice.EUDividendStatus),nameof(EUDividendStatusType1Choice.EUDividendStatus))]
    [JsonDerivedType(typeof(EUDividendStatusType1Choice.Proprietary),nameof(EUDividendStatusType1Choice.Proprietary))]
    [IsoId("_RgcdEtp-Ed-ak6NoX_4Aeg_-1297197608")]
    [DisplayName("EU Dividend Status Type 1 Choice")]
    public abstract partial record EUDividendStatusType1Choice_
    {
    }
}
