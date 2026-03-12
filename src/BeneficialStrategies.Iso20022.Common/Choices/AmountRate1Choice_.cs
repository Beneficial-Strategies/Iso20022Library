// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [KnownType(typeof(AmountRate1Choice.Amount))]
    [KnownType(typeof(AmountRate1Choice.Rate))]
    [JsonDerivedType(typeof(AmountRate1Choice.Amount),nameof(AmountRate1Choice.Amount))]
    [JsonDerivedType(typeof(AmountRate1Choice.Rate),nameof(AmountRate1Choice.Rate))]
    [IsoId("_RiFb0Np-Ed-ak6NoX_4Aeg_-1508717107")]
    [DisplayName("Amount Rate 1 Choice")]
    public abstract partial record AmountRate1Choice_
    {
    }
}
