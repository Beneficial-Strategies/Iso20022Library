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
[IsoId("_QUWg0cz4EeufhKfUxzsnrQ")]
[DisplayName("Loan Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanData145
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoanData145 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoanData145( System.String reqDeliveryByValue,SecurityCommodity9 reqAssetType,ActiveOrHistoricCurrencyAndAmount reqLoanValue,System.String reqUniqueTradeIdentifier,System.DateOnly reqEventDate,Cleared16Choice_ reqClearingStatus,System.String reqTradingVenue,System.DateTime reqExecutionDateTime,System.DateOnly reqValueDate )
    {
        DeliveryByValue = reqDeliveryByValue;
        AssetType = reqAssetType;
        LoanValue = reqLoanValue;
        UniqueTradeIdentifier = reqUniqueTradeIdentifier;
        EventDate = reqEventDate;
        ClearingStatus = reqClearingStatus;
        TradingVenue = reqTradingVenue;
        ExecutionDateTime = reqExecutionDateTime;
        ValueDate = reqValueDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_QWDxAcz4EeufhKfUxzsnrQ")]
    [DisplayName("Delivery By Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryByVal")]
    #endif
    [IsoXmlTag("DlvryByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator DeliveryByValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DeliveryByValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DeliveryByValue { get; init; } 
    #else
    public System.String DeliveryByValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    [IsoId("_QWDxA8z4EeufhKfUxzsnrQ")]
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
    [IsoId("_QWDxBcz4EeufhKfUxzsnrQ")]
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
    [IsoId("_QWDxB8z4EeufhKfUxzsnrQ")]
    [DisplayName("Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstTp")]
    #endif
    [IsoXmlTag("AsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityCommodity9 AssetType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityCommodity9 AssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityCommodity9 AssetType { get; init; } 
    #else
    public SecurityCommodity9 AssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate (rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee) paid by the lender of the security or commodity to the borrower (positive rebate rate) or by the borrower to the lender (negative rebate rate) on the balance of the provided cash collateral.
    /// </summary>
    [IsoId("_QWDxCcz4EeufhKfUxzsnrQ")]
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
    /// Specifies the loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    [IsoId("_QWDxC8z4EeufhKfUxzsnrQ")]
    [DisplayName("Loan Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnVal")]
    #endif
    [IsoXmlTag("LnVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount LoanValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount LoanValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount LoanValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount LoanValue { get; set; } 
    #endif
    
    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    [IsoId("_QWDxDcz4EeufhKfUxzsnrQ")]
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
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_QWDxD8z4EeufhKfUxzsnrQ")]
    [DisplayName("Unique Trade Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqTradIdr")]
    #endif
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UniqueTradeIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UniqueTradeIdentifier { get; init; } 
    #else
    public System.String UniqueTradeIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    [IsoId("_QWDxEcz4EeufhKfUxzsnrQ")]
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
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_QWDxE8z4EeufhKfUxzsnrQ")]
    [DisplayName("Clearing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSts")]
    #endif
    [IsoXmlTag("ClrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Cleared16Choice_ ClearingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Cleared16Choice_ ClearingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cleared16Choice_ ClearingStatus { get; init; } 
    #else
    public Cleared16Choice_ ClearingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Venue of execution shall be identified by a unique code for this venue.
    /// </summary>
    [IsoId("_QWDxFcz4EeufhKfUxzsnrQ")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMICIdentifier TradingVenue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradingVenue { get; init; } 
    #else
    public System.String TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_QWDxF8z4EeufhKfUxzsnrQ")]
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
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_QWDxGcz4EeufhKfUxzsnrQ")]
    [DisplayName("Execution Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnDtTm")]
    #endif
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ExecutionDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ExecutionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ExecutionDateTime { get; init; } 
    #else
    public System.DateTime ExecutionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_QWDxG8z4EeufhKfUxzsnrQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValueDate { get; init; } 
    #else
    public System.DateOnly ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Termination date in the case of a full early termination of the reported transaction.
    /// </summary>
    [IsoId("_QWDxHcz4EeufhKfUxzsnrQ")]
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
    
    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
    /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
    /// </summary>
    [IsoId("_QWDxH8z4EeufhKfUxzsnrQ")]
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
    
    
    #nullable disable
    
}
