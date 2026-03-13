// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
[IsoId("_VVbKktp-Ed-ak6NoX_4Aeg_123428666")]
[DisplayName("Subscription Multiple Execution")]
public partial record SubscriptionMultipleExecution2
{
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VVbKk9p-Ed-ak6NoX_4Aeg_124349998")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public CountryCode? PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VVbKlNp-Ed-ak6NoX_4Aeg_123429129")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VVbKldp-Ed-ak6NoX_4Aeg_123429639")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1? CancellationRight { get; init; } 
    
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_VVbKltp-Ed-ak6NoX_4Aeg_124352824")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_VVbKl9p-Ed-ak6NoX_4Aeg_1956221566")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    
    /// <summary>
    /// Execution of a subscription order.
    /// </summary>
    [IsoId("_VVbKmNp-Ed-ak6NoX_4Aeg_125276199")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<SubscriptionExecution4> IndividualExecutionDetails { get; init; } = [];
    // ID for the above is _VVbKmNp-Ed-ak6NoX_4Aeg_125276199
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VVbKmdp-Ed-ak6NoX_4Aeg_124350731")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction13? BulkCashSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
