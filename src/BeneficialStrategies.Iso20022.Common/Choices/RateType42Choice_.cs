// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType42Choice.Code))]
    [KnownType(typeof(RateType42Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType42Choice.Code),nameof(RateType42Choice.Code))]
    [JsonDerivedType(typeof(RateType42Choice.Proprietary),nameof(RateType42Choice.Proprietary))]
    [IsoId("__c_cdUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 42 Choice")]
    public abstract partial record RateType42Choice_
    {
    }
}
