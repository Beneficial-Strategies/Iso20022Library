// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType13Choice.Code))]
    [KnownType(typeof(RepurchaseType13Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType13Choice.Code),nameof(RepurchaseType13Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType13Choice.Proprietary),nameof(RepurchaseType13Choice.Proprietary))]
    [IsoId("_mUqXITqnEeWyoP0PbocV1Q")]
    [DisplayName("Repurchase Type 13 Choice")]
    public abstract partial record RepurchaseType13Choice_
    {
    }
}
