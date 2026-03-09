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
/// Information about funds that have been arrested.
/// </summary>
[IsoId("_Qpd4YBt3Eeaiht5D4a9WSA")]
[DisplayName("Arrested Funds")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ArrestedFunds1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ArrestedFunds1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ArrestedFunds1( ActiveCurrencyAndAmount reqRemainingUnpaidAmount )
    {
        RemainingUnpaidAmount = reqRemainingUnpaidAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the arrest order assigned by the account servicer.
    /// </summary>
    [IsoId("_W_XnACG4EeaZx5-Tw7BKeQ")]
    [DisplayName("Arrest Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ArrstId")]
    #endif
    [IsoXmlTag("ArrstId")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? ArrestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ArrestIdentification { get; init; } 
    #else
    public System.String? ArrestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount owed subject to arrest.
    /// </summary>
    [IsoId("_fvCwYBt3Eeaiht5D4a9WSA")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining unpaid amount out of total amount owed subject to arrest.
    /// </summary>
    [IsoId("_yfPgABt3Eeaiht5D4a9WSA")]
    [DisplayName("Remaining Unpaid Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngUnpdAmt")]
    #endif
    [IsoXmlTag("RmngUnpdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount RemainingUnpaidAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount RemainingUnpaidAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount RemainingUnpaidAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount RemainingUnpaidAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Funds blocked for settlement of the arrest order.
    /// </summary>
    [IsoId("_qz16kBt3Eeaiht5D4a9WSA")]
    [DisplayName("Arrested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ArrstdAmt")]
    #endif
    [IsoXmlTag("ArrstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ArrestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ArrestedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ArrestedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
