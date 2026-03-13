// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
[IsoId("_VWdsY9p-Ed-ak6NoX_4Aeg_676422996")]
[DisplayName("Redemption Bulk Execution")]
public partial record RedemptionBulkExecution2
{
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VWdsZNp-Ed-ak6NoX_4Aeg_676424234")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public CountryCode? PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VWndYNp-Ed-ak6NoX_4Aeg_676423909")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VWndYdp-Ed-ak6NoX_4Aeg_676423968")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1? CancellationRight { get; init; } 
    
    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    [IsoId("_VWndYtp-Ed-ak6NoX_4Aeg_676424270")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Execution of a redemption order.
    /// </summary>
    [IsoId("_VWndY9p-Ed-ak6NoX_4Aeg_676424313")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<RedemptionExecution3> IndividualExecutionDetails { get; init; } = [];
    // ID for the above is _VWndY9p-Ed-ak6NoX_4Aeg_676424313
    
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VWndZNp-Ed-ak6NoX_4Aeg_676423926")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public CurrencyCode? RequestedSettlementCurrency { get; init; } 
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VWndZdp-Ed-ak6NoX_4Aeg_676423951")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; } 
    
    /// <summary>
    /// Payment transaction related to the execution of an investment fund transaction.
    /// </summary>
    [IsoId("_VWndZtp-Ed-ak6NoX_4Aeg_676424355")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction18? BulkCashSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
