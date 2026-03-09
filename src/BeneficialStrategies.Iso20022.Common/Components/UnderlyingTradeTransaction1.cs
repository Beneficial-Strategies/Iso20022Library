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
/// Information about a transaction.
/// </summary>
[IsoId("_96PRVnltEeG7BsjMvd1mEw_-533314240")]
[DisplayName("Underlying Trade Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingTradeTransaction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnderlyingTradeTransaction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnderlyingTradeTransaction1( UnderlyingTradeTransactionType1Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of underlying transaction such as a tender, order, contract.
    /// </summary>
    [IsoId("_96PRV3ltEeG7BsjMvd1mEw_145675419")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingTradeTransactionType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingTradeTransactionType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingTradeTransactionType1Choice_ Type { get; init; } 
    #else
    public UnderlyingTradeTransactionType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the underlying transaction.
    /// </summary>
    [IsoId("_96PRWHltEeG7BsjMvd1mEw_-1698193570")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date the underlying transaction was issued or awarded.
    /// </summary>
    [IsoId("_96PRWXltEeG7BsjMvd1mEw_-1244106301")]
    [DisplayName("Transaction Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDt")]
    #endif
    [IsoXmlTag("TxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TransactionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TransactionDate { get; init; } 
    #else
    public System.DateOnly? TransactionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date the tender closes.
    /// </summary>
    [IsoId("_96PRWnltEeG7BsjMvd1mEw_211943685")]
    [DisplayName("Tender Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TndrClsgDt")]
    #endif
    [IsoXmlTag("TndrClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TenderClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TenderClosingDate { get; init; } 
    #else
    public System.DateOnly? TenderClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the underlying transaction.
    /// </summary>
    [IsoId("_96YbQHltEeG7BsjMvd1mEw_-1461796889")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the underlying contract covered by the undertaking.
    /// </summary>
    [IsoId("_96YbQXltEeG7BsjMvd1mEw_-304059961")]
    [DisplayName("Contract Amount Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctAmtPctg")]
    #endif
    [IsoXmlTag("CtrctAmtPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ContractAmountPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ContractAmountPercentage { get; init; } 
    #else
    public System.Decimal? ContractAmountPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the underlying transaction.
    /// </summary>
    [IsoId("_96YbQnltEeG7BsjMvd1mEw_-826765043")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
