// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Selection between a generic technical address or a BIC identifier when setting up or modifying the technical address for a party.
    /// </summary>
    [KnownType(typeof(TechnicalIdentification2Choice.BICFI))]
    [KnownType(typeof(TechnicalIdentification2Choice.TechnicalAddress))]
    [JsonDerivedType(
        typeof(TechnicalIdentification2Choice.BICFI),
        nameof(TechnicalIdentification2Choice.BICFI)
    )]
    [JsonDerivedType(
        typeof(TechnicalIdentification2Choice.TechnicalAddress),
        nameof(TechnicalIdentification2Choice.TechnicalAddress)
    )]
    [IsoId("_X5McYb11Eeiut6mmSKzDFQ")]
    [DisplayName("Technical Identification 2 Choice")]
    public abstract record TechnicalIdentification2Choice_ { }
}
