// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the return of cash.
    /// </summary>
    [KnownType(typeof(ReturnExcessCash1Choice.Code))]
    [KnownType(typeof(ReturnExcessCash1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReturnExcessCash1Choice.Code), nameof(ReturnExcessCash1Choice.Code))]
    [JsonDerivedType(
        typeof(ReturnExcessCash1Choice.Proprietary),
        nameof(ReturnExcessCash1Choice.Proprietary)
    )]
    [IsoId("_BGt5wALpEeutW5-TpeYJhA")]
    [DisplayName("Return Excess Cash 1 Choice")]
    public abstract record ReturnExcessCash1Choice_ { }
}
