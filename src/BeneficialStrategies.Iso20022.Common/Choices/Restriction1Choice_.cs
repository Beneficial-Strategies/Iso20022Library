// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities restriction information.
    /// </summary>
    [KnownType(typeof(Restriction1Choice.Code))]
    [KnownType(typeof(Restriction1Choice.Proprietary))]
    [JsonDerivedType(typeof(Restriction1Choice.Code), nameof(Restriction1Choice.Code))]
    [JsonDerivedType(
        typeof(Restriction1Choice.Proprietary),
        nameof(Restriction1Choice.Proprietary)
    )]
    [IsoId("_QvkZx9p-Ed-ak6NoX_4Aeg_2055714392")]
    [DisplayName("Restriction 1 Choice")]
    public abstract record Restriction1Choice_ { }
}
