// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
[IsoId("_Vc32aNp-Ed-ak6NoX_4Aeg_-1089349595")]
[DisplayName("Redemption Bulk Order")]
public partial record RedemptionBulkOrder2
{
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_Vc32adp-Ed-ak6NoX_4Aeg_-1089347778")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public CountryCode? PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_Vc32atp-Ed-ak6NoX_4Aeg_1997589258")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_Vc32a9p-Ed-ak6NoX_4Aeg_-1187278681")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExpiryDateTime { get; init; } 
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_Vc32bNp-Ed-ak6NoX_4Aeg_-1089349593")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1? CancellationRight { get; init; } 
    
    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_VdBAUNp-Ed-ak6NoX_4Aeg_-1089347759")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    [IsoId("_VdBAUdp-Ed-ak6NoX_4Aeg_-1089347717")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<RedemptionOrder3> IndividualOrderDetails { get; init; } = [];
    // ID for the above is _VdBAUdp-Ed-ak6NoX_4Aeg_-1089347717
    
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VdBAUtp-Ed-ak6NoX_4Aeg_-1089349578")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public CurrencyCode? RequestedSettlementCurrency { get; init; } 
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VdBAU9p-Ed-ak6NoX_4Aeg_-1089347820")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; } 
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VdBAVNp-Ed-ak6NoX_4Aeg_-1089347639")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction18? BulkCashSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
