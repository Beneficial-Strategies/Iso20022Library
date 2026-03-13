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
[IsoId("_SIhwxdp-Ed-ak6NoX_4Aeg_-1290017335")]
[DisplayName("Subscription Multiple Order")]
public partial record SubscriptionMultipleOrder4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_SIhwxtp-Ed-ak6NoX_4Aeg_-1290017317")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_SIhwx9p-Ed-ak6NoX_4Aeg_-1290017300")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Date the investor places the order.
    /// </summary>
    [IsoId("_SIhwyNp-Ed-ak6NoX_4Aeg_-1290017283")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_SIhwydp-Ed-ak6NoX_4Aeg_-1290017265")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; } 
    
    /// <summary>
    /// Future date at which the investor requests the order to be executed. The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_SIhwytp-Ed-ak6NoX_4Aeg_-805382533")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_SIhwy9p-Ed-ak6NoX_4Aeg_-1290017023")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Code? CancellationRight { get; init; } 
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_SIhwzNp-Ed-ak6NoX_4Aeg_-1290017006")]
    [DisplayName("Extended Cancellation Right")]
    [IsoXmlTag("XtndedCxlRght")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCancellationRight { get; init; } 
    
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_SIrhwNp-Ed-ak6NoX_4Aeg_838215532")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount21 InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Additional information about the beneficial owner.
    /// </summary>
    [IsoId("_SIrhwdp-Ed-ak6NoX_4Aeg_774845720")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson9? BeneficiaryDetails { get; init; } 
    
    /// <summary>
    /// Order to invest the investor&apos;s principal in an investment fund.
    /// </summary>
    [IsoId("_SIrhwtp-Ed-ak6NoX_4Aeg_-1290016884")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<SubscriptionOrder8> IndividualOrderDetails { get; init; } = [];
    // ID for the above is _SIrhwtp-Ed-ak6NoX_4Aeg_-1290016884
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_SIrhw9p-Ed-ak6NoX_4Aeg_-499609787")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; } 
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SIrhxNp-Ed-ak6NoX_4Aeg_-499609692")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; } 
    
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_SIrhxdp-Ed-ak6NoX_4Aeg_-1290016866")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction23? BulkCashSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
