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
/// Identification of the original transaction.
/// </summary>
[IsoId("_w2FEAVE5EeyApZmLzm74zA")]
[DisplayName("Card Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransaction123
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransaction123 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransaction123( TransactionIdentifier1 reqTransactionIdentification,GenericIdentification32 reqPOIIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
        POIIdentification = reqPOIIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_w8RLkVE5EeyApZmLzm74zA")]
    [DisplayName("Sale Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRefId")]
    #endif
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReferenceIdentification { get; init; } 
    #else
    public System.String? SaleReferenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_w8RLk1E5EeyApZmLzm74zA")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_w8RLlVE5EeyApZmLzm74zA")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification32 POIIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification32 POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32 POIIdentification { get; init; } 
    #else
    public GenericIdentification32 POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Link to a previous currency conversion.
    /// </summary>
    [IsoId("_w8RLl1E5EeyApZmLzm74zA")]
    [DisplayName("Currency Conversion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvs")]
    #endif
    [IsoXmlTag("CcyConvs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion25? CurrencyConversion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion25? CurrencyConversion { get; init; } 
    #else
    public CurrencyConversion25? CurrencyConversion { get; set; } 
    #endif
    
    
    #nullable disable
    
}
