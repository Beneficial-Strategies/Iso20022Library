// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration1Choice.Code))]
    [KnownType(typeof(Registration1Choice.Proprietary))]
    [JsonDerivedType(typeof(Registration1Choice.Code), nameof(Registration1Choice.Code))]
    [JsonDerivedType(
        typeof(Registration1Choice.Proprietary),
        nameof(Registration1Choice.Proprietary)
    )]
    [IsoId("_QwBFtNp-Ed-ak6NoX_4Aeg_1955517270")]
    [DisplayName("Registration 1 Choice")]
    public abstract record Registration1Choice_ { }
}
