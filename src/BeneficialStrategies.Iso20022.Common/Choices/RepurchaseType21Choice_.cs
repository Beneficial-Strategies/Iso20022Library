// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType21Choice.Code))]
    [KnownType(typeof(RepurchaseType21Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType21Choice.Code),nameof(RepurchaseType21Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType21Choice.Proprietary),nameof(RepurchaseType21Choice.Proprietary))]
    [IsoId("_RLA_kY-REeaVK-2bgpxeYw")]
    [DisplayName("Repurchase Type 21 Choice")]
    public abstract partial record RepurchaseType21Choice_
    {
    }
}
