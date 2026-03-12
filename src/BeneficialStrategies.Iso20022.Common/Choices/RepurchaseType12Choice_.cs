// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType12Choice.Code))]
    [KnownType(typeof(RepurchaseType12Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType12Choice.Code),nameof(RepurchaseType12Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType12Choice.Proprietary),nameof(RepurchaseType12Choice.Proprietary))]
    [IsoId("_X7Xj4TqHEeWVrPy0StzzSg")]
    [DisplayName("Repurchase Type 12 Choice")]
    public abstract partial record RepurchaseType12Choice_
    {
    }
}
