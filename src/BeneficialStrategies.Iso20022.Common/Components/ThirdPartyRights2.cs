// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about third party rights.
/// </summary>
[IsoId("_PI3P75S8EemqYPWMBuVawg")]
[DisplayName("Third Party Rights")]
public record ThirdPartyRights2
{
    /// <summary>
    /// Type of third party right.
    /// </summary>
    [IsoId("_PbwWkZS8EemqYPWMBuVawg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Timestamp for the third party right.
    /// </summary>
    [IsoId("_PbwWk5S8EemqYPWMBuVawg")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateTime { get; init; }

    /// <summary>
    /// Party that holds the third party right.
    /// </summary>
    [IsoId("_PbwWlZS8EemqYPWMBuVawg")]
    [DisplayName("Holder")]
    [IsoXmlTag("Hldr")]
    public PartyIdentification125Choice_? Holder { get; init; }

    /// <summary>
    /// Identification of the holder with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_PbwWl5S8EemqYPWMBuVawg")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }

    /// <summary>
    /// Amount of the third party right.
    /// </summary>
    [IsoId("_PbwWmZS8EemqYPWMBuVawg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Description of the third party right.
    /// </summary>
    [IsoId("_PbwWm5S8EemqYPWMBuVawg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; }
}
