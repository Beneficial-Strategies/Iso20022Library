// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate status.
    /// </summary>
    [KnownType(typeof(RateStatus1Choice.Code))]
    [KnownType(typeof(RateStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(RateStatus1Choice.Code),nameof(RateStatus1Choice.Code))]
    [JsonDerivedType(typeof(RateStatus1Choice.Proprietary),nameof(RateStatus1Choice.Proprietary))]
    [IsoId("_Q2kZpdp-Ed-ak6NoX_4Aeg_2138194978")]
    [DisplayName("Rate Status 1 Choice")]
    public abstract partial record RateStatus1Choice_
    {
    }
}
