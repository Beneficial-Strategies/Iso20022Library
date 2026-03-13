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
[IsoId("_VddsSdp-Ed-ak6NoX_4Aeg_-438010863")]
[DisplayName("Redemption Multiple Order")]
public partial record RedemptionMultipleOrder2
{
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VddsStp-Ed-ak6NoX_4Aeg_-438010425")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public CountryCode? PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VddsS9p-Ed-ak6NoX_4Aeg_1097157709")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_VddsTNp-Ed-ak6NoX_4Aeg_-2087712576")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExpiryDateTime { get; init; } 
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VddsTdp-Ed-ak6NoX_4Aeg_-438010459")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1? CancellationRight { get; init; } 
    
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_VddsTtp-Ed-ak6NoX_4Aeg_-438009897")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_VddsT9p-Ed-ak6NoX_4Aeg_110663030")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    
    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    [IsoId("_VdndQNp-Ed-ak6NoX_4Aeg_-438009880")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<RedemptionOrder4> IndividualOrderDetails { get; init; } = [];
    // ID for the above is _VdndQNp-Ed-ak6NoX_4Aeg_-438009880
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VdndQdp-Ed-ak6NoX_4Aeg_-438009837")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction15? BulkCashSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
