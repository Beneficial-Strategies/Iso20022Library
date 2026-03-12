// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the order status.
/// </summary>
[IsoId("_Q_z1Mdp-Ed-ak6NoX_4Aeg_-766441894")]
[DisplayName("Reference")]
public partial record Reference15
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by issuer of Mass Status Request to uniquely identify the request.
    /// </summary>
    [IsoId("_Q_z1Mtp-Ed-ak6NoX_4Aeg_-1656495387")]
    [DisplayName("Order Mass Status Request Identification")]
    [IsoXmlTag("OrdrMassStsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OrderMassStatusRequestIdentification { get; init; } 
    
    /// <summary>
    /// Identification assigned by issuer of Order Status Request to uniquely identify the request.
    /// </summary>
    [IsoId("_Q_z1M9p-Ed-ak6NoX_4Aeg_-1369282249")]
    [DisplayName("Order Status Request Identification")]
    [IsoXmlTag("OrdrStsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OrderStatusRequestIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for Order as assigned by sell-side.
    /// </summary>
    [IsoId("_Q_z1NNp-Ed-ak6NoX_4Aeg_378019497")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OrderIdentification { get; init; } 
    
    /// <summary>
    /// Host assigned entity identification that can be used to reference all components of a cross; sides + strategy + legs. The HostCrossID will be used to link together components of the Cross Order. For example, each individual Notice of Execution associated with the order will carry HostCrossID in order to tie back to the original cross order.
    /// </summary>
    [IsoId("_Q_z1Ndp-Ed-ak6NoX_4Aeg_-1839590348")]
    [DisplayName("Host Cross Identification")]
    [IsoXmlTag("HstCrossId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? HostCrossIdentification { get; init; } 
    
    /// <summary>
    /// Identifier for a cross order. Must be unique during a given trading day.
    /// </summary>
    [IsoId("_Q_z1Ntp-Ed-ak6NoX_4Aeg_-1607785677")]
    [DisplayName("Cross Order Identification")]
    [IsoXmlTag("CrossOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CrossOrderIdentification { get; init; } 
    
    /// <summary>
    /// Cross Identification of the previous cross order (not the initial cross order of the day) as assigned by the institution, used to identify the previous cross order in Cross Order Modification Request and Cross Order Cancellation Request.
    /// </summary>
    [IsoId("_Q_z1N9p-Ed-ak6NoX_4Aeg_-1551450786")]
    [DisplayName("Original Cross Order Identification")]
    [IsoXmlTag("OrgnlCrossOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalCrossOrderIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for Order as assigned by the buy-side.
    /// </summary>
    [IsoId("_Q_z1ONp-Ed-ak6NoX_4Aeg_-1465565690")]
    [DisplayName("Client Order Identification")]
    [IsoXmlTag("ClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientOrderIdentification { get; init; } 
    
    /// <summary>
    /// Identifier assigned by the party which accepts the order.
    /// </summary>
    [IsoId("_Q_9mMNp-Ed-ak6NoX_4Aeg_-331136006")]
    [DisplayName("Secondary Order Identification")]
    [IsoXmlTag("ScndryOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecondaryOrderIdentification { get; init; } 
    
    /// <summary>
    /// Identifier assigned by the party which originates the order.
    /// </summary>
    [IsoId("_Q_9mMdp-Ed-ak6NoX_4Aeg_99226144")]
    [DisplayName("Secondary Client Order Identification")]
    [IsoXmlTag("ScndryClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecondaryClientOrderIdentification { get; init; } 
    
    
    #nullable disable
    
}
