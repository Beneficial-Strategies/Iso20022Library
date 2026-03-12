// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification36Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification36Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentification36Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentification36Choice.Basket))]
    [KnownType(typeof(SecurityIdentification36Choice.Index))]
    [KnownType(typeof(SecurityIdentification36Choice.IdentificationNotAvailable))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.ISIN),nameof(SecurityIdentification36Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.AlternativeInstrumentIdentification),nameof(SecurityIdentification36Choice.AlternativeInstrumentIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.UniqueProductIdentifier),nameof(SecurityIdentification36Choice.UniqueProductIdentifier))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.Basket),nameof(SecurityIdentification36Choice.Basket))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.Index),nameof(SecurityIdentification36Choice.Index))]
    [JsonDerivedType(typeof(SecurityIdentification36Choice.IdentificationNotAvailable),nameof(SecurityIdentification36Choice.IdentificationNotAvailable))]
    [IsoId("_PNQi0YrpEeq91phomTRDDA")]
    [DisplayName("Security Identification 36 Choice")]
    public abstract partial record SecurityIdentification36Choice_
    {
    }
}
