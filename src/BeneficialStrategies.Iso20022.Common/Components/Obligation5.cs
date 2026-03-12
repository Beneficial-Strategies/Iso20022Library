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
[IsoId("_oZfTEa_XEeaiqo1qOdNaWg")]
[DisplayName("Obligation")]
public partial record Obligation5
{
    #nullable enable
    
    /// <summary>
    /// Defines one of the entities associated with the collateral agreement.
    /// </summary>
    [IsoId("_o2MdMa_XEeaiqo1qOdNaWg")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentification100Choice_ PartyA { get; init; } 
    
    /// <summary>
    /// Specifies the party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_o2MdM6_XEeaiqo1qOdNaWg")]
    [DisplayName("Servicing Party A")]
    [IsoXmlTag("SvcgPtyA")]
    public PartyIdentification100Choice_? ServicingPartyA { get; init; } 
    
    /// <summary>
    /// Defines the other entity associated with the collateral agreement.
    /// </summary>
    [IsoId("_o2MdNa_XEeaiqo1qOdNaWg")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification100Choice_ PartyB { get; init; } 
    
    /// <summary>
    /// Specifies the party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_o2MdN6_XEeaiqo1qOdNaWg")]
    [DisplayName("Servicing Party B")]
    [IsoXmlTag("SvcgPtyB")]
    public PartyIdentification100Choice_? ServicingPartyB { get; init; } 
    
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_o2MdOa_XEeaiqo1qOdNaWg")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_o2MdO6_XEeaiqo1qOdNaWg")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType5Code? ExposureType { get; init; } 
    
    /// <summary>
    /// Indicates the close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_o2MdPa_XEeaiqo1qOdNaWg")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public required DateAndDateTimeChoice_ ValuationDate { get; init; } 
    
    
    #nullable disable
    
}
