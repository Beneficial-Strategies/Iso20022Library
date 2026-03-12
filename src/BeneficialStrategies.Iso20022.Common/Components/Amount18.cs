// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_XCtkkayeEeuupt0UCH5uiw")]
[DisplayName("Amount")]
public partial record Amount18
{
    #nullable enable
    
    /// <summary>
    /// Code that describes the type of amount or fee.
    /// </summary>
    [IsoId("_XHhMEayeEeuupt0UCH5uiw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CarRentalServiceType2Code? Type { get; init; } 
    
    /// <summary>
    /// Description of other type of amount or fee.
    /// </summary>
    [IsoId("_XHhME6yeEeuupt0UCH5uiw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_XHhMFayeEeuupt0UCH5uiw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the amount is a credit or debit. 
    /// </summary>
    [IsoId("_XHhMF6yeEeuupt0UCH5uiw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the customer was notified about additional amounts. 
    /// </summary>
    [IsoId("_XHhMGayeEeuupt0UCH5uiw")]
    [DisplayName("Customer Notified Indicator")]
    [IsoXmlTag("CstmrNtfdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerNotifiedIndicator { get; init; } 
    
    
    #nullable disable
    
}
