// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_hv4QUY-iEeaEa8S_GI1QNA")]
[DisplayName("Confirmation Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ConfirmationParties6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_h-wZ0Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails7? Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails7? Buyer { get; init; } 
    #else
    public ConfirmationPartyDetails7? Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [IsoId("_h-wZ04-iEeaEa8S_GI1QNA")]
    [DisplayName("Borrower")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brrwr")]
    #endif
    [IsoXmlTag("Brrwr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails7? Borrower { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails7? Borrower { get; init; } 
    #else
    public ConfirmationPartyDetails7? Borrower { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_h-wZ1Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails7? Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails7? Seller { get; init; } 
    #else
    public ConfirmationPartyDetails7? Seller { get; set; } 
    #endif
    
    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [IsoId("_h-wZ14-iEeaEa8S_GI1QNA")]
    [DisplayName("Lender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lndr")]
    #endif
    [IsoXmlTag("Lndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails7? Lender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails7? Lender { get; init; } 
    #else
    public ConfirmationPartyDetails7? Lender { get; set; } 
    #endif
    
    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    [IsoId("_h-wZ2Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Broker Of Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkrOfCdt")]
    #endif
    [IsoXmlTag("BrkrOfCdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails8? BrokerOfCredit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails8? BrokerOfCredit { get; init; } 
    #else
    public ConfirmationPartyDetails8? BrokerOfCredit { get; set; } 
    #endif
    
    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    [IsoId("_h-wZ24-iEeaEa8S_GI1QNA")]
    [DisplayName("Introducing Firm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrdcgFirm")]
    #endif
    [IsoXmlTag("IntrdcgFirm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails8? IntroducingFirm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails8? IntroducingFirm { get; init; } 
    #else
    public ConfirmationPartyDetails8? IntroducingFirm { get; set; } 
    #endif
    
    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    [IsoId("_h-wZ3Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Step In Firm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StepInFirm")]
    #endif
    [IsoXmlTag("StepInFirm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails8? StepInFirm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails8? StepInFirm { get; init; } 
    #else
    public ConfirmationPartyDetails8? StepInFirm { get; set; } 
    #endif
    
    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    [IsoId("_h-wZ34-iEeaEa8S_GI1QNA")]
    [DisplayName("Step Out Firm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StepOutFirm")]
    #endif
    [IsoXmlTag("StepOutFirm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails8? StepOutFirm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails8? StepOutFirm { get; init; } 
    #else
    public ConfirmationPartyDetails8? StepOutFirm { get; set; } 
    #endif
    
    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    [IsoId("_h-wZ4Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Clearing Firm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrFirm")]
    #endif
    [IsoXmlTag("ClrFirm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails9? ClearingFirm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails9? ClearingFirm { get; init; } 
    #else
    public ConfirmationPartyDetails9? ClearingFirm { get; set; } 
    #endif
    
    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    [IsoId("_h-wZ44-iEeaEa8S_GI1QNA")]
    [DisplayName("Executing Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgBrkr")]
    #endif
    [IsoXmlTag("ExctgBrkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails9? ExecutingBroker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails9? ExecutingBroker { get; init; } 
    #else
    public ConfirmationPartyDetails9? ExecutingBroker { get; set; } 
    #endif
    
    /// <summary>
    /// Party sending the message to the CMU (Central Matching Utility) to identify the actual business unit as known to the CMU (Central Matching Utility).
    /// </summary>
    [IsoId("_h-wZ5Y-iEeaEa8S_GI1QNA")]
    [DisplayName("CMU Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CMUPty")]
    #endif
    [IsoXmlTag("CMUPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails8? CMUParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails8? CMUParty { get; init; } 
    #else
    public ConfirmationPartyDetails8? CMUParty { get; set; } 
    #endif
    
    /// <summary>
    /// Actual business unit of the counterparty to the sender of the message to the CMU (Central Matching Utility) as known to the CMU (Central Matching Utility).
    /// </summary>
    [IsoId("_h-wZ54-iEeaEa8S_GI1QNA")]
    [DisplayName("CMU Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CMUCtrPty")]
    #endif
    [IsoXmlTag("CMUCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails8? CMUCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails8? CMUCounterparty { get; init; } 
    #else
    public ConfirmationPartyDetails8? CMUCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [IsoId("_h-wZ6Y-iEeaEa8S_GI1QNA")]
    [DisplayName("Affirming Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AffrmgPty")]
    #endif
    [IsoXmlTag("AffrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails8? AffirmingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails8? AffirmingParty { get; init; } 
    #else
    public ConfirmationPartyDetails8? AffirmingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party involved in a legal proceeding, agreement or other transaction.
    /// </summary>
    [IsoId("_h-wZ64-iEeaEa8S_GI1QNA")]
    [DisplayName("Trade Beneficiary Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradBnfcryPty")]
    #endif
    [IsoXmlTag("TradBnfcryPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails10? TradeBeneficiaryParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails10? TradeBeneficiaryParty { get; init; } 
    #else
    public ConfirmationPartyDetails10? TradeBeneficiaryParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
