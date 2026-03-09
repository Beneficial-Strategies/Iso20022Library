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
[IsoId("_AeLmRNokEeC60axPepSq7g_-324873963")]
[DisplayName("Confirmation Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ConfirmationParties4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_AeLmRdokEeC60axPepSq7g_-1648850605")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount79? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount79? Investor { get; init; } 
    #else
    public PartyIdentificationAndAccount79? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AeLmRtokEeC60axPepSq7g_-146755291")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails2? Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails2? Buyer { get; init; } 
    #else
    public ConfirmationPartyDetails2? Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [IsoId("_AeLmR9okEeC60axPepSq7g_-1755117827")]
    [DisplayName("Borrower")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brrwr")]
    #endif
    [IsoXmlTag("Brrwr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails2? Borrower { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails2? Borrower { get; init; } 
    #else
    public ConfirmationPartyDetails2? Borrower { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AeUwMNokEeC60axPepSq7g_-1321946316")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails2? Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails2? Seller { get; init; } 
    #else
    public ConfirmationPartyDetails2? Seller { get; set; } 
    #endif
    
    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [IsoId("_AeUwMdokEeC60axPepSq7g_-109850392")]
    [DisplayName("Lender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lndr")]
    #endif
    [IsoXmlTag("Lndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails2? Lender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails2? Lender { get; init; } 
    #else
    public ConfirmationPartyDetails2? Lender { get; set; } 
    #endif
    
    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    [IsoId("_AeUwMtokEeC60axPepSq7g_323321119")]
    [DisplayName("Broker Of Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkrOfCdt")]
    #endif
    [IsoXmlTag("BrkrOfCdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails3? BrokerOfCredit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails3? BrokerOfCredit { get; init; } 
    #else
    public ConfirmationPartyDetails3? BrokerOfCredit { get; set; } 
    #endif
    
    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    [IsoId("_AeUwM9okEeC60axPepSq7g_1862109561")]
    [DisplayName("Introducing Firm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrdcgFirm")]
    #endif
    [IsoXmlTag("IntrdcgFirm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails3? IntroducingFirm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails3? IntroducingFirm { get; init; } 
    #else
    public ConfirmationPartyDetails3? IntroducingFirm { get; set; } 
    #endif
    
    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    [IsoId("_AeUwNNokEeC60axPepSq7g_1156994946")]
    [DisplayName("Step In Firm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StepInFirm")]
    #endif
    [IsoXmlTag("StepInFirm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails1? StepInFirm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails1? StepInFirm { get; init; } 
    #else
    public ConfirmationPartyDetails1? StepInFirm { get; set; } 
    #endif
    
    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    [IsoId("_AeUwNdokEeC60axPepSq7g_-1830875646")]
    [DisplayName("Step Out Firm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StepOutFirm")]
    #endif
    [IsoXmlTag("StepOutFirm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails1? StepOutFirm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails1? StepOutFirm { get; init; } 
    #else
    public ConfirmationPartyDetails1? StepOutFirm { get; set; } 
    #endif
    
    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    [IsoId("_AeUwNtokEeC60axPepSq7g_-18196079")]
    [DisplayName("Clearing Firm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrFirm")]
    #endif
    [IsoXmlTag("ClrFirm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails6? ClearingFirm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails6? ClearingFirm { get; init; } 
    #else
    public ConfirmationPartyDetails6? ClearingFirm { get; set; } 
    #endif
    
    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    [IsoId("_AeehMNokEeC60axPepSq7g_1627071356")]
    [DisplayName("Executing Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgBrkr")]
    #endif
    [IsoXmlTag("ExctgBrkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails6? ExecutingBroker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails6? ExecutingBroker { get; init; } 
    #else
    public ConfirmationPartyDetails6? ExecutingBroker { get; set; } 
    #endif
    
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [IsoId("_AeehMdokEeC60axPepSq7g_-249312182")]
    [DisplayName("Affirming Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AffrmgPty")]
    #endif
    [IsoXmlTag("AffrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails3? AffirmingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails3? AffirmingParty { get; init; } 
    #else
    public ConfirmationPartyDetails3? AffirmingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party involved in a legal proceeding, agreement, or other transaction.
    /// </summary>
    [IsoId("_AeehMtokEeC60axPepSq7g_996963158")]
    [DisplayName("Trade Beneficiary Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradBnfcryPty")]
    #endif
    [IsoXmlTag("TradBnfcryPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; init; } 
    #else
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
