// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides identifications related to the order processing.
/// </summary>
[IsoId("_S4XSQ9p-Ed-ak6NoX_4Aeg_1055247135")]
[DisplayName("Order Identification")]
public partial record OrderIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    [IsoId("_S4XSRNp-Ed-ak6NoX_4Aeg_-1038002624")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OrderIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for the order as assigned by the buyside. Uniqueness must be guaranteed within a single trading day. Firms, particularly those that electronically submit multi-day orders, trade globally or throughout market close periods, should ensure uniqueness across days, for example by embedding a date within the ClientOrderIdentification element.
    /// </summary>
    [IsoId("_S4XSRdp-Ed-ak6NoX_4Aeg_1102346319")]
    [DisplayName("Client Order Identification")]
    [IsoXmlTag("ClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ClientOrderIdentification { get; init; } 
    
    /// <summary>
    /// Assigned by the party that originates the order. Can be used to provide the ClientOrderIdentification used by an exchange or executing system.
    /// </summary>
    [IsoId("_S4XSRtp-Ed-ak6NoX_4Aeg_1102346301")]
    [DisplayName("Secondary Client Order Identification")]
    [IsoXmlTag("ScndryClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecondaryClientOrderIdentification { get; init; } 
    
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_S4XSR9p-Ed-ak6NoX_4Aeg_-246196560")]
    [DisplayName("Side")]
    [IsoXmlTag("Sd")]
    public Side1Code? Side { get; init; } 
    
    /// <summary>
    /// Permits order originators to tie together groups of orders in which trades resulting from orders are associated for a specific purpose, for example the calculation of average execution price for a customer or to associate lists submitted to a broker as waves of a larger program trade.
    /// </summary>
    [IsoId("_S4XSSNp-Ed-ak6NoX_4Aeg_293714089")]
    [DisplayName("Client Order Link Identification")]
    [IsoXmlTag("ClntOrdrLkId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientOrderLinkIdentification { get; init; } 
    
    
    #nullable disable
    
}
