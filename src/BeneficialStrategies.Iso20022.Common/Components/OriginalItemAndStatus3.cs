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
/// Identifies the original notification item and to provide the status.
/// </summary>
[IsoId("_tBBOtFkyEeGeoaLUQk__nA_1755686524")]
[DisplayName("Original Item And Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalItemAndStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalItemAndStatus3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalItemAndStatus3( System.String reqOriginalItemIdentification,ActiveOrHistoricCurrencyAndAmount reqAmount,NotificationStatus3Code reqItemStatus )
    {
        OriginalItemIdentification = reqOriginalItemIdentification;
        Amount = reqAmount;
        ItemStatus = reqItemStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the original notification item.
    /// </summary>
    [IsoId("_tBKYoFkyEeGeoaLUQk__nA_1917816055")]
    [DisplayName("Original Item Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlItmId")]
    #endif
    [IsoXmlTag("OrgnlItmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalItemIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalItemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalItemIdentification { get; init; } 
    #else
    public System.String OriginalItemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification as assigned by the debtor to unambiguously identify the original underlying transaction to the creditor.
    /// </summary>
    [IsoId("_tBKYoVkyEeGeoaLUQk__nA_1906717278")]
    [DisplayName("Original End To End Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlEndToEndId")]
    #endif
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalEndToEndIdentification { get; init; } 
    #else
    public System.String? OriginalEndToEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money expected to be credited to the account, as per the original notification to receive.
    /// </summary>
    [IsoId("_tBKYolkyEeGeoaLUQk__nA_-1337116946")]
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
    /// Value date on which the account was expected to be credited.
    /// </summary>
    [IsoId("_tBKYo1kyEeGeoaLUQk__nA_1450197645")]
    [DisplayName("Expected Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdValDt")]
    #endif
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpectedValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpectedValueDate { get; init; } 
    #else
    public System.DateOnly? ExpectedValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the notification item.
    /// </summary>
    [IsoId("_tBUJoFkyEeGeoaLUQk__nA_1823103368")]
    [DisplayName("Item Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmSts")]
    #endif
    [IsoXmlTag("ItmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationStatus3Code ItemStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationStatus3Code ItemStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationStatus3Code ItemStatus { get; init; } 
    #else
    public NotificationStatus3Code ItemStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the item status.
    /// </summary>
    [IsoId("_tFyZ8FkyEeGeoaLUQk__nA_-2089239349")]
    [DisplayName("Additional Status Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlStsInf")]
    #endif
    [IsoXmlTag("AddtlStsInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalStatusInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalStatusInformation { get; init; } 
    #else
    public System.String? AdditionalStatusInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further information in order to identify a previous payment notification.
    /// </summary>
    [IsoId("_tF7j4FkyEeGeoaLUQk__nA_-1150355524")]
    [DisplayName("Original Item Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlItmRef")]
    #endif
    [IsoXmlTag("OrgnlItmRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalItemReference2? OriginalItemReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalItemReference2? OriginalItemReference { get; init; } 
    #else
    public OriginalItemReference2? OriginalItemReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
