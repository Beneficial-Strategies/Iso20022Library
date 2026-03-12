// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
/// </summary>
[IsoId("_cSBe4WNeEeSLD8nyfZcLzQ")]
[DisplayName("Obligation")]
public partial record Obligation3
{
    #nullable enable
    
    /// <summary>
    /// Defines one of the entities associated with the collateral agreement.
    /// </summary>
    [IsoId("_cvoA4WNeEeSLD8nyfZcLzQ")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentification33Choice_ PartyA { get; init; } 
    
    /// <summary>
    /// Specifies the party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_cvoA42NeEeSLD8nyfZcLzQ")]
    [DisplayName("Servicing Party A")]
    [IsoXmlTag("SvcgPtyA")]
    public PartyIdentification33Choice_? ServicingPartyA { get; init; } 
    
    /// <summary>
    /// Defines the other entity associated with the collateral agreement.
    /// </summary>
    [IsoId("_cvoA5WNeEeSLD8nyfZcLzQ")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification33Choice_ PartyB { get; init; } 
    
    /// <summary>
    /// Specifies the party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_cvoA52NeEeSLD8nyfZcLzQ")]
    [DisplayName("Servicing Party B")]
    [IsoXmlTag("SvcgPtyB")]
    public PartyIdentification33Choice_? ServicingPartyB { get; init; } 
    
    /// <summary>
    /// Provides additional information on the Collateral Account of the Party delivering the collateral.
    /// </summary>
    [IsoId("_cvoA6WNeEeSLD8nyfZcLzQ")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount1? CollateralAccountIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_cvoA62NeEeSLD8nyfZcLzQ")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType5Code? ExposureType { get; init; } 
    
    /// <summary>
    /// Indicates the close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_cvoA7WNeEeSLD8nyfZcLzQ")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public required DateAndDateTimeChoice_ ValuationDate { get; init; } 
    
    
    #nullable disable
    
}
