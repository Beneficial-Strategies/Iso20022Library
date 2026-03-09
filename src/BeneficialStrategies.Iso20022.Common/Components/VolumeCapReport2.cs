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
/// Double volume cap report.
/// </summary>
[IsoId("_7YvFaeJBEeWWKb0jFHxViQ")]
[DisplayName("Volume Cap Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VolumeCapReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VolumeCapReport2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VolumeCapReport2( System.String reqIdentification,string reqCurrency,ImpliedCurrencyAndAmount reqTotalTradingVolume,ImpliedCurrencyAndAmount reqTotalReferencePriceTradingVolume,ImpliedCurrencyAndAmount reqTotalNegotiatedTransactionsTradingVolume )
    {
        Identification = reqIdentification;
        Currency = reqCurrency;
        TotalTradingVolume = reqTotalTradingVolume;
        TotalReferencePriceTradingVolume = reqTotalReferencePriceTradingVolume;
        TotalNegotiatedTransactionsTradingVolume = reqTotalNegotiatedTransactionsTradingVolume;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and feedback messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_7YvsdOJBEeWWKb0jFHxViQ")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_7YvsduJBEeWWKb0jFHxViQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the transaction.
    /// </summary>
    [IsoId("_7YvsdeJBEeWWKb0jFHxViQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Total traded volume of the instrument in this specific reporting period.
    /// </summary>
    [IsoId("_7YvscuJBEeWWKb0jFHxViQ")]
    [DisplayName("Total Trading Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTradgVol")]
    #endif
    [IsoXmlTag("TtlTradgVol")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount TotalTradingVolume { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount TotalTradingVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount TotalTradingVolume { get; init; } 
    #else
    public ImpliedCurrencyAndAmount TotalTradingVolume { get; set; } 
    #endif
    
    /// <summary>
    /// Total volume of trading under reference price waiver as defined under the local regulation.
    /// </summary>
    [IsoId("_7Yvsd-JBEeWWKb0jFHxViQ")]
    [DisplayName("Total Reference Price Trading Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRefPricTradgVol")]
    #endif
    [IsoXmlTag("TtlRefPricTradgVol")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount TotalReferencePriceTradingVolume { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount TotalReferencePriceTradingVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount TotalReferencePriceTradingVolume { get; init; } 
    #else
    public ImpliedCurrencyAndAmount TotalReferencePriceTradingVolume { get; set; } 
    #endif
    
    /// <summary>
    /// Total volume of trading under negotiated transactions waiver as defined under the local regulation.
    /// </summary>
    [IsoId("_7YvsceJBEeWWKb0jFHxViQ")]
    [DisplayName("Total Negotiated Transactions Trading Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNgtdTxsTradgVol")]
    #endif
    [IsoXmlTag("TtlNgtdTxsTradgVol")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount TotalNegotiatedTransactionsTradingVolume { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount TotalNegotiatedTransactionsTradingVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount TotalNegotiatedTransactionsTradingVolume { get; init; } 
    #else
    public ImpliedCurrencyAndAmount TotalNegotiatedTransactionsTradingVolume { get; set; } 
    #endif
    
    
    #nullable disable
    
}
