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
/// Details of breakdown of a market value.
/// </summary>
[IsoId("_kK-5sRIoEeyZaPkaPAzTvQ")]
[DisplayName("Collateral Transaction Amount Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralTransactionAmountBreakdown2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralTransactionAmountBreakdown2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralTransactionAmountBreakdown2( GenericIdentification178 reqLotNumber )
    {
        LotNumber = reqLotNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the underlying transaction (exposure split).
    /// </summary>
    [IsoId("_kiYGARIoEeyZaPkaPAzTvQ")]
    [DisplayName("Lot Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotNb")]
    #endif
    [IsoXmlTag("LotNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification178 LotNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification178 LotNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification178 LotNumber { get; init; } 
    #else
    public GenericIdentification178 LotNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Split amount of the aggregate transaction amount (exposure).
    /// </summary>
    [IsoId("_kiYGCRIoEeyZaPkaPAzTvQ")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Period that applies to the aggregate transation amount (exposure).
    /// </summary>
    [IsoId("_kiYGCxIoEeyZaPkaPAzTvQ")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4Choice_? Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_? Period { get; init; } 
    #else
    public Period4Choice_? Period { get; set; } 
    #endif
    
    
    #nullable disable
    
}
