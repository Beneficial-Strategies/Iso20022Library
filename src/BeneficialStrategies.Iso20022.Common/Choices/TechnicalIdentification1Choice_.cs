// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Selection between a generic technical address or a BIC identifier when setting up or modifying the technical address for a party.
    /// </summary>
    [KnownType(typeof(TechnicalIdentification1Choice.BICFI))]
    [KnownType(typeof(TechnicalIdentification1Choice.TechnicalAddress))]
    [JsonDerivedType(typeof(TechnicalIdentification1Choice.BICFI),nameof(TechnicalIdentification1Choice.BICFI))]
    [JsonDerivedType(typeof(TechnicalIdentification1Choice.TechnicalAddress),nameof(TechnicalIdentification1Choice.TechnicalAddress))]
    [IsoId("_kpB8s-5NEeCisYr99QEiWA_856915283")]
    [DisplayName("Technical Identification 1 Choice")]
    public abstract partial record TechnicalIdentification1Choice_
    {
    }
}
