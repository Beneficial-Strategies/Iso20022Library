// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the detailed parameters a service to be billed.
/// </summary>
[IsoId("_6PgXxJqlEeGSON8vddiWzQ_126693803")]
[DisplayName("Billing Service Parameters")]
public partial record BillingServiceParameters2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the details to fully identify the bank service.
    /// </summary>
    [IsoId("_6PgXxZqlEeGSON8vddiWzQ_-1989872304")]
    [DisplayName("Bank Service")]
    [IsoXmlTag("BkSvc")]
    public required BillingServiceIdentification2 BankService { get; init; } 
    
    /// <summary>
    /// Count or number of items (volume) involved in the charge.
    /// </summary>
    [IsoId("_6PgXxpqlEeGSON8vddiWzQ_-424116921")]
    [DisplayName("Volume")]
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Volume { get; init; } 
    
    /// <summary>
    /// Price per item or unit used to calculate the charge expressed in the pricing currency.
    /// </summary>
    [IsoId("_6PgXx5qlEeGSON8vddiWzQ_-1110935494")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public AmountAndDirection34? UnitPrice { get; init; } 
    
    /// <summary>
    /// Amount of the calculated charge expressed in the pricing currency, exclusive of any tax.
    /// </summary>
    [IsoId("_6PphsJqlEeGSON8vddiWzQ_534331941")]
    [DisplayName("Service Charge Amount")]
    [IsoXmlTag("SvcChrgAmt")]
    public required AmountAndDirection34 ServiceChargeAmount { get; init; } 
    
    
    #nullable disable
    
}
