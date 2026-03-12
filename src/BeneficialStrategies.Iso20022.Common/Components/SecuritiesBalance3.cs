// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity of securities assigned as collateral position.
/// </summary>
[IsoId("_Y5UdUStEEeySlt9bF77XfA")]
[DisplayName("Securities Balance")]
public partial record SecuritiesBalance3
{
    #nullable enable
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_ZQ3apStEEeySlt9bF77XfA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument at the time of the preparation of the statement. It is the resulting balance of securities post movements for delta (reporting on flow).
    /// </summary>
    [IsoId("_ZQ3apytEEeySlt9bF77XfA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required BalanceQuantity13Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument is delivered/received as collateral or as loaned  securities.
    /// </summary>
    [IsoId("_ZQ3aqStEEeySlt9bF77XfA")]
    [DisplayName("Collateral Indicator")]
    [IsoXmlTag("CollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CollateralIndicator { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_ZQ3aqytEEeySlt9bF77XfA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace3? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Account from which the collateral is sourced. 
    /// </summary>
    [IsoId("_ZQ3arStEEeySlt9bF77XfA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification232? AccountOwner { get; init; } 
    
    /// <summary>
    /// Account where financial instruments are maintained. It is the source account.
    /// </summary>
    [IsoId("_ZQ3arytEEeySlt9bF77XfA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_MkSaUytEEeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Provides the status of settlement of an instruction.
    /// </summary>
    [IsoId("_ZQ3asStEEeySlt9bF77XfA")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SecuritiesSettlementStatus3Code? SettlementStatus { get; init; } 
    
    /// <summary>
    /// Currency  in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_ZQ3asytEEeySlt9bF77XfA")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    
    /// <summary>
    /// Rating and source of the rating of the financial instrument.
    /// </summary>
    [IsoId("_ZQ3atStEEeySlt9bF77XfA")]
    [DisplayName("Rating Details")]
    [IsoXmlTag("RatgDtls")]
    public Rating2? RatingDetails { get; init; } 
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_ZQ3atytEEeySlt9bF77XfA")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms19? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Valuation details for the securities position.
    /// </summary>
    [IsoId("_ZQ3auStEEeySlt9bF77XfA")]
    [DisplayName("Valuation Details")]
    [IsoXmlTag("ValtnDtls")]
    public ValuationsDetails1? ValuationDetails { get; init; } 
    
    /// <summary>
    /// Identification of the underlying market value lots based on the term of the underlyning trades. The issuer defines the lot identification.
    /// </summary>
    [IsoId("_ZQ3auytEEeySlt9bF77XfA")]
    [DisplayName("Transaction Lot Number")]
    [IsoXmlTag("TxLotNb")]
    public GenericIdentification178? TransactionLotNumber { get; init; } 
    
    
    #nullable disable
    
}
