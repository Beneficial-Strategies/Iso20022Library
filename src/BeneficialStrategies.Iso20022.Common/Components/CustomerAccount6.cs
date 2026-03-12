// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account owned by a customer.
/// </summary>
[IsoId("_xSODMd_iEeWtWuYVXtphhA")]
[DisplayName("Customer Account")]
public partial record CustomerAccount6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_xdp3Id_iEeWtWuYVXtphhA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public AccountIdentification4Choice_? Identification { get; init; } 
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_xdp3I9_iEeWtWuYVXtphhA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_xdp3Jd_iEeWtWuYVXtphhA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public AccountStatus3Code? Status { get; init; } 
    
    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_xdp3J9_iEeWtWuYVXtphhA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; } 
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_xdp3Kd_iEeWtWuYVXtphhA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    [IsoId("_xdp3K9_iEeWtWuYVXtphhA")]
    [DisplayName("Monthly Payment Value")]
    [IsoXmlTag("MnthlyPmtVal")]
    public ImpliedCurrencyAndAmount? MonthlyPaymentValue { get; init; } 
    
    /// <summary>
    /// Monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_xdp3Ld_iEeWtWuYVXtphhA")]
    [DisplayName("Monthly Received Value")]
    [IsoXmlTag("MnthlyRcvdVal")]
    public ImpliedCurrencyAndAmount? MonthlyReceivedValue { get; init; } 
    
    /// <summary>
    /// Monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_xdp3L9_iEeWtWuYVXtphhA")]
    [DisplayName("Monthly Transaction Number")]
    [IsoXmlTag("MnthlyTxNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? MonthlyTransactionNumber { get; init; } 
    
    /// <summary>
    /// Sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_xdp3Md_iEeWtWuYVXtphhA")]
    [DisplayName("Average Balance")]
    [IsoXmlTag("AvrgBal")]
    public ImpliedCurrencyAndAmount? AverageBalance { get; init; } 
    
    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_xdp3M9_iEeWtWuYVXtphhA")]
    [DisplayName("Account Purpose")]
    [IsoXmlTag("AcctPurp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AccountPurpose { get; init; } 
    
    /// <summary>
    /// Specifies the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_xdp3Nd_iEeWtWuYVXtphhA")]
    [DisplayName("Floor Notification Amount")]
    [IsoXmlTag("FlrNtfctnAmt")]
    public ImpliedCurrencyAndAmount? FloorNotificationAmount { get; init; } 
    
    /// <summary>
    /// Specifies the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_xdp3N9_iEeWtWuYVXtphhA")]
    [DisplayName("Ceiling Notification Amount")]
    [IsoXmlTag("ClngNtfctnAmt")]
    public ImpliedCurrencyAndAmount? CeilingNotificationAmount { get; init; } 
    
    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent, in which format, to which address.
    /// </summary>
    [IsoId("_ivWkwd_kEeWtWuYVXtphhA")]
    [DisplayName("Statement Frequency And Format")]
    [IsoXmlTag("StmtFrqcyAndFrmt")]
    public StatementFrequencyAndForm1? StatementFrequencyAndFormat { get; init; } 
    
    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_xdp3O9_iEeWtWuYVXtphhA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; } 
    
    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    [IsoId("_xdp3Pd_iEeWtWuYVXtphhA")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public Restriction1? Restriction { get; init; } 
    
    /// <summary>
    /// Date when the account was opened.
    /// </summary>
    [IsoId("_xdp3P9_iEeWtWuYVXtphhA")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OpeningDate { get; init; } 
    
    
    #nullable disable
    
}
