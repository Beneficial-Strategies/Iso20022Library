// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification41Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification41Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentification41Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentification41Choice.Basket))]
    [KnownType(typeof(SecurityIdentification41Choice.Index))]
    [KnownType(typeof(SecurityIdentification41Choice.Other))]
    [KnownType(typeof(SecurityIdentification41Choice.IdentificationNotAvailable))]
    [JsonDerivedType(
        typeof(SecurityIdentification41Choice.ISIN),
        nameof(SecurityIdentification41Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification41Choice.AlternativeInstrumentIdentification),
        nameof(SecurityIdentification41Choice.AlternativeInstrumentIdentification)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification41Choice.UniqueProductIdentifier),
        nameof(SecurityIdentification41Choice.UniqueProductIdentifier)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification41Choice.Basket),
        nameof(SecurityIdentification41Choice.Basket)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification41Choice.Index),
        nameof(SecurityIdentification41Choice.Index)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification41Choice.Other),
        nameof(SecurityIdentification41Choice.Other)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification41Choice.IdentificationNotAvailable),
        nameof(SecurityIdentification41Choice.IdentificationNotAvailable)
    )]
    [IsoId("_ibqGsVo2Ee23K4GXSpBSeg")]
    [DisplayName("Security Identification 41 Choice")]
    public abstract record SecurityIdentification41Choice_ { }
}
