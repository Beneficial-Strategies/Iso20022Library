// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType15Choice.Code))]
    [KnownType(typeof(RepurchaseType15Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType15Choice.Code), nameof(RepurchaseType15Choice.Code))]
    [JsonDerivedType(
        typeof(RepurchaseType15Choice.Proprietary),
        nameof(RepurchaseType15Choice.Proprietary)
    )]
    [IsoId("_ZzmhwT0BEeWjqIDN7tjEjQ")]
    [DisplayName("Repurchase Type 15 Choice")]
    public abstract record RepurchaseType15Choice_ { }
}
