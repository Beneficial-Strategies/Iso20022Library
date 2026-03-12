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
[IsoId("_aZH-NvS6Eeife6veM7daYw")]
[DisplayName("Amount")]
public partial record Amount9
{
    #nullable enable
    
    /// <summary>
    /// Code that describes the type of amount or fee.
    /// </summary>
    [IsoId("_aZH-OfS6Eeife6veM7daYw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CarRentalServiceType2Code? Type { get; init; } 
    
    /// <summary>
    /// Description of other type of amount or fee.
    /// </summary>
    [IsoId("_aZH-O_S6Eeife6veM7daYw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_aZH-OPS6Eeife6veM7daYw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the amount is a credit or debit. 
    /// </summary>
    [IsoId("_aZH-OvS6Eeife6veM7daYw")]
    [DisplayName("Credit Indicator")]
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the customer was notified about additional amounts. 
    /// </summary>
    [IsoId("_aZH-N_S6Eeife6veM7daYw")]
    [DisplayName("Customer Notified Indicator")]
    [IsoXmlTag("CstmrNtfdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerNotifiedIndicator { get; init; } 
    
    
    #nullable disable
    
}
