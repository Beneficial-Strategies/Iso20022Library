// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a standard identifier and a proprietary code.
    /// </summary>
    [KnownType(typeof(UniqueProductIdentifier1Choice.Identification))]
    [KnownType(typeof(UniqueProductIdentifier1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(UniqueProductIdentifier1Choice.Identification),
        nameof(UniqueProductIdentifier1Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(UniqueProductIdentifier1Choice.Proprietary),
        nameof(UniqueProductIdentifier1Choice.Proprietary)
    )]
    [IsoId("_rTVXISyFEe2xAdY9t5fB3g")]
    [DisplayName("Unique Product Identifier 1 Choice")]
    public abstract record UniqueProductIdentifier1Choice_ { }
}
