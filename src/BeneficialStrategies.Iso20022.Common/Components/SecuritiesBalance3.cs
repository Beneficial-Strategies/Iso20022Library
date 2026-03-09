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
/// Quantity of securities assigned as collateral position.
/// </summary>
[IsoId("_Y5UdUStEEeySlt9bF77XfA")]
[DisplayName("Securities Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesBalance3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesBalance3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesBalance3( SecurityIdentification19 reqFinancialInstrumentIdentification,BalanceQuantity13Choice_ reqQuantity )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_ZQ3apStEEeySlt9bF77XfA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument at the time of the preparation of the statement. It is the resulting balance of securities post movements for delta (reporting on flow).
    /// </summary>
    [IsoId("_ZQ3apytEEeySlt9bF77XfA")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceQuantity13Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceQuantity13Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceQuantity13Choice_ Quantity { get; init; } 
    #else
    public BalanceQuantity13Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is delivered/received as collateral or as loaned  securities.
    /// </summary>
    [IsoId("_ZQ3aqStEEeySlt9bF77XfA")]
    [DisplayName("Collateral Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollInd")]
    #endif
    [IsoXmlTag("CollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CollateralIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralIndicator { get; init; } 
    #else
    public System.String? CollateralIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_ZQ3aqytEEeySlt9bF77XfA")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    #else
    public SafeKeepingPlace3? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Account from which the collateral is sourced. 
    /// </summary>
    [IsoId("_ZQ3arStEEeySlt9bF77XfA")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification232? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232? AccountOwner { get; init; } 
    #else
    public PartyIdentification232? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account where financial instruments are maintained. It is the source account.
    /// </summary>
    [IsoId("_ZQ3arytEEeySlt9bF77XfA")]
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
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_MkSaUytEEeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of settlement of an instruction.
    /// </summary>
    [IsoId("_ZQ3asStEEeySlt9bF77XfA")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesSettlementStatus3Code? SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesSettlementStatus3Code? SettlementStatus { get; init; } 
    #else
    public SecuritiesSettlementStatus3Code? SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Currency  in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_ZQ3asytEEeySlt9bF77XfA")]
    [DisplayName("Denomination Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DnmtnCcy")]
    #endif
    [IsoXmlTag("DnmtnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DenominationCurrency { get; init; } 
    #else
    public string? DenominationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Rating and source of the rating of the financial instrument.
    /// </summary>
    [IsoId("_ZQ3atStEEeySlt9bF77XfA")]
    [DisplayName("Rating Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RatgDtls")]
    #endif
    [IsoXmlTag("RatgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rating2? RatingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rating2? RatingDetails { get; init; } 
    #else
    public Rating2? RatingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_ZQ3atytEEeySlt9bF77XfA")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms19? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms19? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms19? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation details for the securities position.
    /// </summary>
    [IsoId("_ZQ3auStEEeySlt9bF77XfA")]
    [DisplayName("Valuation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDtls")]
    #endif
    [IsoXmlTag("ValtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValuationsDetails1? ValuationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationsDetails1? ValuationDetails { get; init; } 
    #else
    public ValuationsDetails1? ValuationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the underlying market value lots based on the term of the underlyning trades. The issuer defines the lot identification.
    /// </summary>
    [IsoId("_ZQ3auytEEeySlt9bF77XfA")]
    [DisplayName("Transaction Lot Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxLotNb")]
    #endif
    [IsoXmlTag("TxLotNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification178? TransactionLotNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification178? TransactionLotNumber { get; init; } 
    #else
    public GenericIdentification178? TransactionLotNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
