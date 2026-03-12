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
[IsoId("_BjP6AQN1Ee2-vqzwMUAewg")]
[DisplayName("General Information")]
public partial record GeneralInformation8
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the trade is a block or single trade.
    /// </summary>
    [IsoId("_BowsIQN1Ee2-vqzwMUAewg")]
    [DisplayName("Block Indicator")]
    [IsoXmlTag("BlckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BlockIndicator { get; init; } 
    
    /// <summary>
    /// Reference to a preceding transaction, for example, an option or swap.
    /// </summary>
    [IsoId("_BowsIwN1Ee2-vqzwMUAewg")]
    [DisplayName("Related Trade Reference")]
    [IsoXmlTag("RltdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedTradeReference { get; init; } 
    
    /// <summary>
    /// Method used by the trading parties to negotiate and/or execute a deal.
    /// </summary>
    [IsoId("_BowsJQN1Ee2-vqzwMUAewg")]
    [DisplayName("Dealing Method")]
    [IsoXmlTag("DealgMtd")]
    public Trading1MethodCode? DealingMethod { get; init; } 
    
    /// <summary>
    /// Specifies the broker which arranged the deal between the trading side and the counterparty side or, when two money brokers are involved, between the trading side and the other money broker.
    /// </summary>
    [IsoId("_BowsJwN1Ee2-vqzwMUAewg")]
    [DisplayName("Broker Identification")]
    [IsoXmlTag("BrkrId")]
    public PartyIdentification242Choice_? BrokerIdentification { get; init; } 
    
    /// <summary>
    /// Counterparty&apos;s reference for the trade.
    /// </summary>
    [IsoId("_BowsKQN1Ee2-vqzwMUAewg")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Brokerage fee for a broker confirmation.
    /// </summary>
    [IsoId("_BowsKwN1Ee2-vqzwMUAewg")]
    [DisplayName("Brokers Commission")]
    [IsoXmlTag("BrkrsComssn")]
    public ActiveCurrencyAndAmount? BrokersCommission { get; init; } 
    
    /// <summary>
    /// Specifies additional information for the receiver and applies to the whole message.
    /// </summary>
    [IsoId("_BowsLQN1Ee2-vqzwMUAewg")]
    [DisplayName("Sender To Receiver Information")]
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? SenderToReceiverInformation { get; init; } 
    
    /// <summary>
    /// Specifies the branch at the trading side with which the deal was done.
    /// </summary>
    [IsoId("_BowsLwN1Ee2-vqzwMUAewg")]
    [DisplayName("Dealing Branch Trading Side")]
    [IsoXmlTag("DealgBrnchTradgSd")]
    public PartyIdentification242Choice_? DealingBranchTradingSide { get; init; } 
    
    /// <summary>
    /// Specifies the branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_BowsMQN1Ee2-vqzwMUAewg")]
    [DisplayName("Dealing Branch Counterparty Side")]
    [IsoXmlTag("DealgBrnchCtrPtySd")]
    public PartyIdentification242Choice_? DealingBranchCounterpartySide { get; init; } 
    
    /// <summary>
    /// Specifies the name and/or electronic address of the receiver of the message who may be contacted for any queries concerning this trade.
    /// </summary>
    [IsoId("_BowsMwN1Ee2-vqzwMUAewg")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactInformation1? ContactInformation { get; init; } 
    
    /// <summary>
    /// Specifies the type, date and version of the agreement used in a trade.
    /// </summary>
    [IsoId("_BowsNQN1Ee2-vqzwMUAewg")]
    [DisplayName("Agreement Details")]
    [IsoXmlTag("AgrmtDtls")]
    public AgreementConditions1? AgreementDetails { get; init; } 
    
    /// <summary>
    /// Specifies the year of definitions of the agreement.
    /// </summary>
    [IsoId("_BowsNwN1Ee2-vqzwMUAewg")]
    [DisplayName("Definitions Year")]
    [IsoXmlTag("DefsYr")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    public IsoISOYear? DefinitionsYear { get; init; } 
    
    /// <summary>
    /// Specifies a reference applied to the trade instruction by a broker.
    /// </summary>
    [IsoId("_BowsOQN1Ee2-vqzwMUAewg")]
    [DisplayName("Brokers Reference")]
    [IsoXmlTag("BrkrsRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BrokersReference { get; init; } 
    
    
    #nullable disable
    
}
