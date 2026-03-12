// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information concerning the negotiation process leading to a treasury trade.
/// </summary>
[IsoId("_y1bu0R9rEeKR8ap75esygQ")]
[DisplayName("General Information")]
public partial record GeneralInformation4
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the trade is a block or single trade.
    /// </summary>
    [IsoId("_zBRycR9rEeKR8ap75esygQ")]
    [DisplayName("Block Indicator")]
    [IsoXmlTag("BlckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BlockIndicator { get; init; } 
    
    /// <summary>
    /// Reference to a preceding transaction, for example, an option or swap.
    /// </summary>
    [IsoId("_zBRydR9rEeKR8ap75esygQ")]
    [DisplayName("Related Trade Reference")]
    [IsoXmlTag("RltdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedTradeReference { get; init; } 
    
    /// <summary>
    /// Method used by the trading parties to negotiate and/or execute a deal.
    /// </summary>
    [IsoId("_zBRyeR9rEeKR8ap75esygQ")]
    [DisplayName("Dealing Method")]
    [IsoXmlTag("DealgMtd")]
    public Trading1MethodCode? DealingMethod { get; init; } 
    
    /// <summary>
    /// Specifies the broker which arranged the deal between the trading side and the counterparty side or, when two money brokers are involved, between the trading side and the other money broker.
    /// </summary>
    [IsoId("_zBRyfR9rEeKR8ap75esygQ")]
    [DisplayName("Broker Identification")]
    [IsoXmlTag("BrkrId")]
    public PartyIdentification73Choice_? BrokerIdentification { get; init; } 
    
    /// <summary>
    /// Counterparty&apos;s reference for the trade.
    /// </summary>
    [IsoId("_zBRygR9rEeKR8ap75esygQ")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Brokerage fee for a broker confirmation.
    /// </summary>
    [IsoId("_zBRyhR9rEeKR8ap75esygQ")]
    [DisplayName("Brokers Commission")]
    [IsoXmlTag("BrkrsComssn")]
    public ActiveCurrencyAndAmount? BrokersCommission { get; init; } 
    
    /// <summary>
    /// Specifies additional information for the receiver and applies to the whole message.
    /// </summary>
    [IsoId("_zBRyiR9rEeKR8ap75esygQ")]
    [DisplayName("Sender To Receiver Information")]
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? SenderToReceiverInformation { get; init; } 
    
    /// <summary>
    /// Specifies the branch at the trading side with which the deal was done.
    /// </summary>
    [IsoId("_zBSZgx9rEeKR8ap75esygQ")]
    [DisplayName("Dealing Branch Trading Side")]
    [IsoXmlTag("DealgBrnchTradgSd")]
    public PartyIdentification73Choice_? DealingBranchTradingSide { get; init; } 
    
    /// <summary>
    /// Specifies the branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_zBSZhx9rEeKR8ap75esygQ")]
    [DisplayName("Dealing Branch Counterparty Side")]
    [IsoXmlTag("DealgBrnchCtrPtySd")]
    public PartyIdentification73Choice_? DealingBranchCounterpartySide { get; init; } 
    
    /// <summary>
    /// Specifies the name and/or electronic address of the receiver of the message who may be contacted for any queries concerning this trade.
    /// </summary>
    [IsoId("_zBSZix9rEeKR8ap75esygQ")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactInformation1? ContactInformation { get; init; } 
    
    
    #nullable disable
    
}
