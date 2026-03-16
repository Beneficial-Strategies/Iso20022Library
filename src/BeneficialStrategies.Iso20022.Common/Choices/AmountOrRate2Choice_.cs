// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(AmountOrRate2Choice.Amount))]
    [KnownType(typeof(AmountOrRate2Choice.Rate))]
    [JsonDerivedType(typeof(AmountOrRate2Choice.Amount), nameof(AmountOrRate2Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrRate2Choice.Rate), nameof(AmountOrRate2Choice.Rate))]
    [IsoId("_Ac_TddokEeC60axPepSq7g_1944068516")]
    [DisplayName("Amount Or Rate 2 Choice")]
    public abstract record AmountOrRate2Choice_ { }
}
