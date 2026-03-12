// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType7Choice.Code))]
    [KnownType(typeof(RepurchaseType7Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType7Choice.Code),nameof(RepurchaseType7Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType7Choice.Proprietary),nameof(RepurchaseType7Choice.Proprietary))]
    [IsoId("_WNdtgduJEd-RF5yaMAVhAw")]
    [DisplayName("Repurchase Type 7 Choice")]
    public abstract partial record RepurchaseType7Choice_
    {
    }
}
