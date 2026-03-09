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
/// Cash details for amount  assigned as collateral position.
/// </summary>
[IsoId("_rRyqwRIwEeydmIVkS03esw")]
[DisplayName("Cash Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashBalance15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashBalance15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashBalance15( ActiveOrHistoricCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money of the cash balance.
    /// </summary>
    [IsoId("_rn_kMRIwEeydmIVkS03esw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_rn_kMxIwEeydmIVkS03esw")]
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
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_rn_kNRIwEeydmIVkS03esw")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation details for the securities position.
    /// </summary>
    [IsoId("_rn_kNxIwEeydmIVkS03esw")]
    [DisplayName("Valuation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDtls")]
    #endif
    [IsoXmlTag("ValtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValuationsDetails2? ValuationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationsDetails2? ValuationDetails { get; init; } 
    #else
    public ValuationsDetails2? ValuationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the underlying market value lots based on the term of the underlying trades. The issuer defines the lot identification.
    /// </summary>
    [IsoId("_rn_kORIwEeydmIVkS03esw")]
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
