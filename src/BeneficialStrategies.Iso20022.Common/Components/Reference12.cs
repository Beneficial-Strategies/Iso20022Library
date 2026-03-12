// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the list order.
/// </summary>
[IsoId("_Q_9mNdp-Ed-ak6NoX_4Aeg_987338352")]
[DisplayName("Reference")]
public partial record Reference12
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for bid response as assigned by sell-side (broker, exchange, electronic communication network).
    /// </summary>
    [IsoId("_Q_9mNtp-Ed-ak6NoX_4Aeg_-477447686")]
    [DisplayName("Bid Identification")]
    [IsoXmlTag("BidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BidIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for a bid request as assigned by institution.
    /// </summary>
    [IsoId("_Q_9mN9p-Ed-ak6NoX_4Aeg_-436812639")]
    [DisplayName("Client Bid Identification")]
    [IsoXmlTag("ClntBidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientBidIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier of the indication of interest message. Required for previously indicated orders.
    /// </summary>
    [IsoId("_Q_9mONp-Ed-ak6NoX_4Aeg_-410954582")]
    [DisplayName("IOI Identification")]
    [IsoXmlTag("IOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IOIIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for quote. Required for previously quoted orders.
    /// </summary>
    [IsoId("_RAGwINp-Ed-ak6NoX_4Aeg_-396176364")]
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text QuoteIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier of the order being hit or taken.
    /// </summary>
    [IsoId("_RAGwIdp-Ed-ak6NoX_4Aeg_1024198853")]
    [DisplayName("Reference Order Identification")]
    [IsoXmlTag("RefOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReferenceOrderIdentification { get; init; } 
    
    
    #nullable disable
    
}
