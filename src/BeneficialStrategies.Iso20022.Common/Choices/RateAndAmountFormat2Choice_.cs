// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between rate and amount.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat2Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat2Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat2Choice.Rate),nameof(RateAndAmountFormat2Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat2Choice.Amount),nameof(RateAndAmountFormat2Choice.Amount))]
    [IsoId("_UPYvldp-Ed-ak6NoX_4Aeg_-1644730391")]
    [DisplayName("Rate And Amount Format 2 Choice")]
    public abstract partial record RateAndAmountFormat2Choice_
    {
    }
}
