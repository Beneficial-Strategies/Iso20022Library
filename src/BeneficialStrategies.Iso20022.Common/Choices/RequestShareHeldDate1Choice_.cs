// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different ways of specifying the method to determine as from when shares have been held by an investor.
    /// </summary>
    [KnownType(typeof(RequestShareHeldDate1Choice.DateCalculationMethod))]
    [KnownType(typeof(RequestShareHeldDate1Choice.DateCalculationDescription))]
    [JsonDerivedType(
        typeof(RequestShareHeldDate1Choice.DateCalculationMethod),
        nameof(RequestShareHeldDate1Choice.DateCalculationMethod)
    )]
    [JsonDerivedType(
        typeof(RequestShareHeldDate1Choice.DateCalculationDescription),
        nameof(RequestShareHeldDate1Choice.DateCalculationDescription)
    )]
    [IsoId("_iOMVYFSTEempisJfoIfvvQ")]
    [DisplayName("Request Share Held Date 1 Choice")]
    public abstract record RequestShareHeldDate1Choice_ { }
}
