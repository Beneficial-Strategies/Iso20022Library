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
/// Specifies the loan data details in case of a securities lending transaction.
/// </summary>
[IsoId("_r0hHsczsEeux2uvSBFU54Q")]
[DisplayName("Loan Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanData141
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoanData141 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoanData141( System.DateOnly reqEventDate )
    {
        EventDate = reqEventDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_r2T3cczsEeux2uvSBFU54Q")]
    [DisplayName("Unique Trade Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqTradIdr")]
    #endif
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UniqueTradeIdentifier { get; init; } 
    #else
    public System.String? UniqueTradeIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_r2T3c8zsEeux2uvSBFU54Q")]
    [DisplayName("Event Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDt")]
    #endif
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate EventDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly EventDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly EventDate { get; init; } 
    #else
    public System.DateOnly EventDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_r2T3dczsEeux2uvSBFU54Q")]
    [DisplayName("Execution Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnDtTm")]
    #endif
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExecutionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExecutionDateTime { get; init; } 
    #else
    public System.DateTime? ExecutionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_r2T3d8zsEeux2uvSBFU54Q")]
    [DisplayName("Clearing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSts")]
    #endif
    [IsoXmlTag("ClrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Cleared16Choice_? ClearingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cleared16Choice_? ClearingStatus { get; init; } 
    #else
    public Cleared16Choice_? ClearingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_r2T3eczsEeux2uvSBFU54Q")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingVenue { get; init; } 
    #else
    public System.String? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_r2T3e8zsEeux2uvSBFU54Q")]
    [DisplayName("Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmt")]
    #endif
    [IsoXmlTag("MstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MasterAgreement7? MasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MasterAgreement7? MasterAgreement { get; init; } 
    #else
    public MasterAgreement7? MasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_r2T3fczsEeux2uvSBFU54Q")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDate { get; init; } 
    #else
    public System.DateOnly? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general collateral arrangement.
    /// </summary>
    [IsoId("_r2T3f8zsEeux2uvSBFU54Q")]
    [DisplayName("General Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlColl")]
    #endif
    [IsoXmlTag("GnlColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    #else
    public SpecialCollateral1Code? GeneralCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// This field specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_r2T3gczsEeux2uvSBFU54Q")]
    [DisplayName("Delivery By Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryByVal")]
    #endif
    [IsoXmlTag("DlvryByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DeliveryByValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryByValue { get; init; } 
    #else
    public System.String? DeliveryByValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    [IsoId("_r2T3g8zsEeux2uvSBFU54Q")]
    [DisplayName("Collateral Delivery Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollDlvryMtd")]
    #endif
    [IsoXmlTag("CollDlvryMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
    #else
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the transaction is open term or, i.e. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    [IsoId("_r2T3hczsEeux2uvSBFU54Q")]
    [DisplayName("Term")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Term")]
    #endif
    [IsoXmlTag("Term")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractTerm7Choice_? Term { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractTerm7Choice_? Term { get; init; } 
    #else
    public ContractTerm7Choice_? Term { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of the type of assets subject of the transaction.
    /// </summary>
    [IsoId("_r2T3h8zsEeux2uvSBFU54Q")]
    [DisplayName("Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstTp")]
    #endif
    [IsoXmlTag("AsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityCommodity9? AssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityCommodity9? AssetType { get; init; } 
    #else
    public SecurityCommodity9? AssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    [IsoId("_r2T3iczsEeux2uvSBFU54Q")]
    [DisplayName("Loan Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnVal")]
    #endif
    [IsoXmlTag("LnVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; set; } 
    #endif
    
    /// <summary>
    /// Rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee.
    /// </summary>
    [IsoId("_r2T3i8zsEeux2uvSBFU54Q")]
    [DisplayName("Rebate Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RbtRate")]
    #endif
    [IsoXmlTag("RbtRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRate27Choice_? RebateRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate27Choice_? RebateRate { get; init; } 
    #else
    public InterestRate27Choice_? RebateRate { get; set; } 
    #endif
    
    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    [IsoId("_r2T3jczsEeux2uvSBFU54Q")]
    [DisplayName("Lending Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LndgFee")]
    #endif
    [IsoXmlTag("LndgFee")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? LendingFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? LendingFee { get; init; } 
    #else
    public System.Decimal? LendingFee { get; set; } 
    #endif
    
    /// <summary>
    /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
    /// </summary>
    [IsoId("_r2T3j8zsEeux2uvSBFU54Q")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TerminationDate { get; init; } 
    #else
    public System.DateOnly? TerminationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
