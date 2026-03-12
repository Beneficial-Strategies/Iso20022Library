// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the completion advice.
/// </summary>
[IsoId("_jK0vcTJBEeOkpIB9tKITlw")]
[DisplayName("Card Payment Transaction Details")]
public partial record CardPaymentTransactionDetails14
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_jamQ0TJBEeOkpIB9tKITlw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_jamQ0zJBEeOkpIB9tKITlw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; } 
    
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_jamQ1TJBEeOkpIB9tKITlw")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_jamQ1zJBEeOkpIB9tKITlw")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount5? DetailedAmount { get; init; } 
    
    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_yqQR4DJBEeOkpIB9tKITlw")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; } 
    
    /// <summary>
    /// Amount authorised for the payment transaction.
    /// </summary>
    [IsoId("_757GcDJBEeOkpIB9tKITlw")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; } 
    
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_jamQ2TJBEeOkpIB9tKITlw")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; } 
    
    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_jamQ2zJBEeOkpIB9tKITlw")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_jamQ3TJBEeOkpIB9tKITlw")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType1Code? AccountType { get; init; } 
    
    /// <summary>
    /// Indicates if a currency conversion has been accepted by the cardholder.
    /// </summary>
    [IsoId("_J8ELgDJCEeOkpIB9tKITlw")]
    [DisplayName("Conversion Accepted")]
    [IsoXmlTag("ConvsAccptd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ConversionAccepted { get; init; } 
    
    /// <summary>
    /// Currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_q5SvoDJEEeOkpIB9tKITlw")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion1? CurrencyConversion { get; init; } 
    
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_-nVnkDJEEeOkpIB9tKITlw")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction2? Instalment { get; init; } 
    
    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_jamQ4TJBEeOkpIB9tKITlw")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public Product1? Product { get; init; } 
    
    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    [IsoId("_N7wz4DJFEeOkpIB9tKITlw")]
    [DisplayName("Card Payment Invoice")]
    [IsoXmlTag("CardPmtInvc")]
    public CardPaymentInvoice1? CardPaymentInvoice { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_jamQ4zJBEeOkpIB9tKITlw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    
    #nullable disable
    
}
