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
/// Limit of deposited media for the customer.
/// </summary>
[IsoId("_OVrpka-XEeWJvLRJ8PsD_w")]
[DisplayName("ATM Transaction Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransactionAmounts9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransactionAmounts9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransactionAmounts9( ATMMediaType2Code reqMediaType )
    {
        MediaType = reqMediaType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of media.
    /// </summary>
    [IsoId("_Og2-0a-XEeWJvLRJ8PsD_w")]
    [DisplayName("Media Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdiaTp")]
    #endif
    [IsoXmlTag("MdiaTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMMediaType2Code MediaType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMMediaType2Code MediaType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaType2Code MediaType { get; init; } 
    #else
    public ATMMediaType2Code MediaType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the media.
    /// </summary>
    [IsoId("_Og2-1a-XEeWJvLRJ8PsD_w")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum number of media.
    /// </summary>
    [IsoId("_Og2-16-XEeWJvLRJ8PsD_w")]
    [DisplayName("Minimum Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinNb")]
    #endif
    [IsoXmlTag("MinNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MinimumNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumNumber { get; init; } 
    #else
    public System.UInt64? MinimumNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of media.
    /// </summary>
    [IsoId("_Og2-2a-XEeWJvLRJ8PsD_w")]
    [DisplayName("Maximum Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxNb")]
    #endif
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumNumber { get; init; } 
    #else
    public System.UInt64? MaximumNumber { get; set; } 
    #endif
    
    /// <summary>
    /// True if limits may be displayed to the customer on the ATM.
    /// </summary>
    [IsoId("_h9Ss4K-YEeWJvLRJ8PsD_w")]
    [DisplayName("Display Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispFlg")]
    #endif
    [IsoXmlTag("DispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DisplayFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisplayFlag { get; init; } 
    #else
    public System.String? DisplayFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
