// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor&apos;s principal in an investment fund.
/// </summary>
[IsoId("_VT7Vztp-Ed-ak6NoX_4Aeg_-1053593438")]
[DisplayName("Subscription Multiple Order")]
public partial record SubscriptionMultipleOrder2
{
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VT7Vz9p-Ed-ak6NoX_4Aeg_-1053593360")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public CountryCode? PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Date the investor places the order.
    /// </summary>
    [IsoId("_VUFGwNp-Ed-ak6NoX_4Aeg_-282388970")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_VUFGwdp-Ed-ak6NoX_4Aeg_1575569284")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExpiryDateTime { get; init; } 
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VUFGwtp-Ed-ak6NoX_4Aeg_-1053593403")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1? CancellationRight { get; init; } 
    
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_VUFGw9p-Ed-ak6NoX_4Aeg_-1053593342")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Additional information about the beneficial owner.
    /// </summary>
    [IsoId("_VUFGxNp-Ed-ak6NoX_4Aeg_127162138")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    
    /// <summary>
    /// Order to invest the investor&apos;s principal in an investment fund.
    /// </summary>
    [IsoId("_VUFGxdp-Ed-ak6NoX_4Aeg_-1053593051")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<SubscriptionOrder4> IndividualOrderDetails { get; init; } = new ValueList<SubscriptionOrder4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VUFGxdp-Ed-ak6NoX_4Aeg_-1053593051
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VUFGxtp-Ed-ak6NoX_4Aeg_-1053593003")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction19? BulkCashSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
