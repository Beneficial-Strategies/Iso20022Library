// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between source of identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(IdentificationSource5Choice.DomesticIdentificationSource))]
    [KnownType(typeof(IdentificationSource5Choice.ProprietaryIdentificationSource))]
    [JsonDerivedType(typeof(IdentificationSource5Choice.DomesticIdentificationSource),nameof(IdentificationSource5Choice.DomesticIdentificationSource))]
    [JsonDerivedType(typeof(IdentificationSource5Choice.ProprietaryIdentificationSource),nameof(IdentificationSource5Choice.ProprietaryIdentificationSource))]
    [IsoId("_nfUx0V9NEeS7xuKaq75oiQ")]
    [DisplayName("Identification Source 5 Choice")]
    public abstract partial record IdentificationSource5Choice_
    {
    }
}
