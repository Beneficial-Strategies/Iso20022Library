// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a buy-in.
/// </summary>
[IsoId("_fGNv0ZwREeqtp-LOti013g")]
[DisplayName("Buy In Advice Details")]
public partial record BuyInAdviceDetails1
{
    #nullable enable
    
    /// <summary>
    /// References of the failing transaction.
    /// </summary>
    [IsoId("_fMwct5wREeqtp-LOti013g")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References23 Reference { get; init; } 
    
    /// <summary>
    /// Status of the buy-in transaction.
    /// </summary>
    [IsoId("_2kO5cJwREeqtp-LOti013g")]
    [DisplayName("Buy In State")]
    [IsoXmlTag("BuyInStat")]
    public required BuyInState1Code BuyInState { get; init; } 
    
    /// <summary>
    /// Specifies if the buy-in transaction was deferred or not.
    /// </summary>
    [IsoId("_8gDXoJwREeqtp-LOti013g")]
    [DisplayName("Buy In Deferral")]
    [IsoXmlTag("BuyInDfrrl")]
    public required BuyInDeferral1Code BuyInDeferral { get; init; } 
    
    /// <summary>
    /// Identification of the financial instrument of the buy-in instruction.
    /// </summary>
    [IsoId("_H0I7ApwSEeqtp-LOti013g")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument concerned by the buy-in transaction.
    /// </summary>
    [IsoId("_JEf6MpwTEeqtp-LOti013g")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    
    /// <summary>
    /// Price of the traded financial instrument in the buy-in transaction.
    /// </summary>
    [IsoId("_aU_xoZwTEeqtp-LOti013g")]
    [DisplayName("Buy In Price")]
    [IsoXmlTag("BuyInPric")]
    public RateAndAmountFormat39Choice_? BuyInPrice { get; init; } 
    
    /// <summary>
    /// Amount of money that has to be paid by the failing trading party in case of an unsuccessful or partially successful buy-in transaction.
    /// </summary>
    [IsoId("_kcLdAJwTEeqtp-LOti013g")]
    [DisplayName("Cash Compensation Amount")]
    [IsoXmlTag("CshCompstnAmt")]
    public AmountAndDirection102? CashCompensationAmount { get; init; } 
    
    /// <summary>
    /// Settlement date of the buy-in. 
    /// </summary>
    [IsoId("_vGqpwpwTEeqtp-LOti013g")]
    [DisplayName("Buy In Settlement Date")]
    [IsoXmlTag("BuyInSttlmDt")]
    public DateAndDateTime2Choice_? BuyInSettlementDate { get; init; } 
    
    
    #nullable disable
    
}
