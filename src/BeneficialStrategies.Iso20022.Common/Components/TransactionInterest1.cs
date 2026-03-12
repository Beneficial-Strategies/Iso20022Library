// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction specific interest information that applies to the underlying transaction.
/// </summary>
[IsoId("_SReRZdp-Ed-ak6NoX_4Aeg_1981961213")]
[DisplayName("Transaction Interest")]
public partial record TransactionInterest1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the amount of interest included in the entry amount.
    /// </summary>
    [IsoId("_SReRZtp-Ed-ak6NoX_4Aeg_-2140306335")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Identifies whether the interest amount included in the entry amount is positive (CRDT) or negative (DBIT).
    /// </summary>
    [IsoId("_SReRZ9p-Ed-ak6NoX_4Aeg_-2140306317")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_SReRaNp-Ed-ak6NoX_4Aeg_1981961561")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Set of elements qualifying the interest rate.
    /// </summary>
    [IsoId("_SRnbUNp-Ed-ak6NoX_4Aeg_1981961621")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public Rate1? Rate { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date.
    /// </summary>
    [IsoId("_SRnbUdp-Ed-ak6NoX_4Aeg_1981961508")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Underlying reason for the interest, eg, yearly credit interest on a savings account.
    /// </summary>
    [IsoId("_SRnbUtp-Ed-ak6NoX_4Aeg_1981961465")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    
    #nullable disable
    
}
