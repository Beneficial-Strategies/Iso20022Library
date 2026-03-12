// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType5Choice.Code))]
    [KnownType(typeof(ChargeType5Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType5Choice.Code),nameof(ChargeType5Choice.Code))]
    [JsonDerivedType(typeof(ChargeType5Choice.Proprietary),nameof(ChargeType5Choice.Proprietary))]
    [IsoId("_KJb5gDh5EeaH-93K5JKmzw")]
    [DisplayName("Charge Type 5 Choice")]
    public abstract partial record ChargeType5Choice_
    {
    }
}
