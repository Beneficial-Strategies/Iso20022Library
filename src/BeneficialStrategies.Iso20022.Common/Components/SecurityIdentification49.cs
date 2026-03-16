// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security Identification49.
/// </summary>
[IsoId("_HB6hseU9Ee-5RJhU69CFvQ")]
[DisplayName("Security Identification49")]
public record SecurityIdentification49
{
    /// <summary>
    /// Alternative Instrument Identification.
    /// </summary>
    [DisplayName("Alternative Instrument Identification")]
    [IsoXmlTag("AltrntvInstrmId")]
    public GenericIdentification175? AlternativeInstrumentIdentification { get; init; }

    /// <summary>
    /// ISIN.
    /// </summary>
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public IsoISINOct2015Identifier? ISIN { get; init; }

    /// <summary>
    /// Product Description.
    /// </summary>
    [DisplayName("Product Description")]
    [IsoXmlTag("PdctDesc")]
    public IsoMax1000Text? ProductDescription { get; init; }

    /// <summary>
    /// Unique Product Identifier.
    /// </summary>
    [DisplayName("Unique Product Identifier")]
    [IsoXmlTag("UnqPdctIdr")]
    public UniqueProductIdentifier2Choice_? UniqueProductIdentifier { get; init; }
}
