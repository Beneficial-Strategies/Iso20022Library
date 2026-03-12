// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType26Choice.Code))]
    [KnownType(typeof(RepurchaseType26Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType26Choice.Code),nameof(RepurchaseType26Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType26Choice.Proprietary),nameof(RepurchaseType26Choice.Proprietary))]
    [IsoId("_R52IBZwyEeazcsnODTksnQ")]
    [DisplayName("Repurchase Type 26 Choice")]
    public abstract partial record RepurchaseType26Choice_
    {
    }
}
