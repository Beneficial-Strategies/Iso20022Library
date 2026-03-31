// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
/// </summary>
[IsoId("_wtu2IYFvEeWtPe6Crjmeug")]
[DisplayName("Obligation")]
public record Obligation4
{
    /// <summary>
    /// Defines one of the entities associated with the collateral agreement.
    /// </summary>
    [IsoId("_xDwJUYFvEeWtPe6Crjmeug")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentification100Choice_ PartyA { get; init; }

    /// <summary>
    /// Specifies the party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_xDwJU4FvEeWtPe6Crjmeug")]
    [DisplayName("Servicing Party A")]
    [IsoXmlTag("SvcgPtyA")]
    public PartyIdentification100Choice_? ServicingPartyA { get; init; }

    /// <summary>
    /// Defines the other entity associated with the collateral agreement.
    /// </summary>
    [IsoId("_xDwJVYFvEeWtPe6Crjmeug")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification100Choice_ PartyB { get; init; }

    /// <summary>
    /// Specifies the party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_xDwJV4FvEeWtPe6Crjmeug")]
    [DisplayName("Servicing Party B")]
    [IsoXmlTag("SvcgPtyB")]
    public PartyIdentification100Choice_? ServicingPartyB { get; init; }

    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_xDwJWYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount2? CollateralAccountIdentification { get; init; }

    /// <summary>
    /// Specifies the underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_xDwJW4FvEeWtPe6Crjmeug")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType5Code? ExposureType { get; init; }

    /// <summary>
    /// Indicates the close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_xDwJXYFvEeWtPe6Crjmeug")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public required DateAndDateTimeChoice_ ValuationDate { get; init; }
}
