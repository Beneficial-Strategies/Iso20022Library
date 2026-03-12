// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between source of identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(IdentificationSource4Choice.Code))]
    [KnownType(typeof(IdentificationSource4Choice.Proprietary))]
    [JsonDerivedType(typeof(IdentificationSource4Choice.Code),nameof(IdentificationSource4Choice.Code))]
    [JsonDerivedType(typeof(IdentificationSource4Choice.Proprietary),nameof(IdentificationSource4Choice.Proprietary))]
    [IsoId("_uPmNYAgWEeCVlvYcV4HKqQ")]
    [DisplayName("Identification Source 4 Choice")]
    public abstract partial record IdentificationSource4Choice_
    {
    }
}
