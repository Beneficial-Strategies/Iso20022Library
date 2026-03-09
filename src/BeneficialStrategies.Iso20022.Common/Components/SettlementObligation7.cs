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
/// Provides details about the settlement obligation.
/// </summary>
[IsoId("_Bu5zUS9aEeS94oXWDaBauA")]
[DisplayName("Settlement Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementObligation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementObligation7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementObligation7( SecurityIdentification14 reqFinancialInstrumentIdentification,FinancialInstrumentQuantity1Choice_ reqQuantity,AmountAndDirection27 reqSettlementAmount )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        Quantity = reqQuantity;
        SettlementAmount = reqSettlementAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Last reference given by the settlement platform (this is the central securities depository) to the transaction (non settled instruction).
    /// </summary>
    [IsoId("_CATsYS9aEeS94oXWDaBauA")]
    [DisplayName("CSD Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSDTxId")]
    #endif
    [IsoXmlTag("CSDTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CSDTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CSDTransactionIdentification { get; init; } 
    #else
    public System.String? CSDTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the transaction (non settled instruction) given by the central counterparty.
    /// </summary>
    [IsoId("_CATsYy9aEeS94oXWDaBauA")]
    [DisplayName("Central Counterparty Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrlCtrPtyTxId")]
    #endif
    [IsoXmlTag("CntrlCtrPtyTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CentralCounterpartyTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CentralCounterpartyTransactionIdentification { get; init; } 
    #else
    public System.String? CentralCounterpartyTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original buy-in identification number in case an event causes a generation of a new buy-in identification.
    /// </summary>
    [IsoId("_opTggC9cEeS94oXWDaBauA")]
    [DisplayName("Previous Buy In Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsBuyInId")]
    #endif
    [IsoXmlTag("PrvsBuyInId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PreviousBuyInIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousBuyInIdentification { get; init; } 
    #else
    public System.String? PreviousBuyInIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// An account opened by the central counterparty in the name of the clearing member within the account structure, for settlement purposes (gives information about the clearing member account at central counterparty).
    /// </summary>
    [IsoId("_CATsZS9aEeS94oXWDaBauA")]
    [DisplayName("Delivery Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryAcct")]
    #endif
    [IsoXmlTag("DlvryAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    #else
    public SecuritiesAccount19? DeliveryAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_GQby4C9cEeS94oXWDaBauA")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing member account at the central securities depository.
    /// </summary>
    [IsoId("_CATsZy9aEeS94oXWDaBauA")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows clearing member firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, clearing member firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_CATsaS9aEeS94oXWDaBauA")]
    [DisplayName("Clearing Segment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSgmt")]
    #endif
    [IsoXmlTag("ClrSgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    #else
    public PartyIdentification35Choice_? ClearingSegment { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification for the non-clearing member and account.
    /// </summary>
    [IsoId("_CATsay9aEeS94oXWDaBauA")]
    [DisplayName("Non Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonClrMmb")]
    #endif
    [IsoXmlTag("NonClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #else
    public PartyIdentificationAndAccount31? NonClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the intended settlement date of the position.
    /// </summary>
    [IsoId("_CATsbS9aEeS94oXWDaBauA")]
    [DisplayName("Intended Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntnddSttlmDt")]
    #endif
    [IsoXmlTag("IntnddSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IntendedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IntendedSettlementDate { get; init; } 
    #else
    public System.DateOnly? IntendedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_CATsby9aEeS94oXWDaBauA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the trade date.
    /// </summary>
    [IsoId("_CATscS9aEeS94oXWDaBauA")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TradeDate { get; init; } 
    #else
    public System.DateOnly? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the price of the trade.
    /// </summary>
    [IsoId("_CATscy9aEeS94oXWDaBauA")]
    [DisplayName("Deal Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealPric")]
    #endif
    [IsoXmlTag("DealPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price4? DealPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4? DealPrice { get; init; } 
    #else
    public Price4? DealPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the quantity of the trade.
    /// </summary>
    [IsoId("_CATsdS9aEeS94oXWDaBauA")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_CATsdy9aEeS94oXWDaBauA")]
    [DisplayName("Depository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dpstry")]
    #endif
    [IsoXmlTag("Dpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification34Choice_? Depository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification34Choice_? Depository { get; init; } 
    #else
    public PartyIdentification34Choice_? Depository { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the remaining quantity to be settled.
    /// </summary>
    [IsoId("_CATseS9aEeS94oXWDaBauA")]
    [DisplayName("Remaining Quantity To Be Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngQtyToBeSttld")]
    #endif
    [IsoXmlTag("RmngQtyToBeSttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? RemainingQuantityToBeSettled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? RemainingQuantityToBeSettled { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? RemainingQuantityToBeSettled { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the amount to be settled.
    /// </summary>
    [IsoId("_CATsey9aEeS94oXWDaBauA")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection27 SettlementAmount { get; init; } 
    #else
    public AmountAndDirection27 SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the remaining amount to be settled.
    /// </summary>
    [IsoId("_CATsfS9aEeS94oXWDaBauA")]
    [DisplayName("Remaining Amount To Be Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngAmtToBeSttld")]
    #endif
    [IsoXmlTag("RmngAmtToBeSttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection27? RemainingAmountToBeSettled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection27? RemainingAmountToBeSettled { get; init; } 
    #else
    public AmountAndDirection27? RemainingAmountToBeSettled { get; set; } 
    #endif
    
    
    #nullable disable
    
}
