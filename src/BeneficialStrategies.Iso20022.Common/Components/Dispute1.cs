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
/// Provides the dispute details.
/// </summary>
[IsoId("_Ulb4Ftp-Ed-ak6NoX_4Aeg_1250324083")]
[DisplayName("Dispute")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Dispute1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Dispute1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Dispute1( System.String reqMarginCallRequestIdentification,ActiveCurrencyAndAmount reqDisputedAmount,System.DateOnly reqDisputeDate )
    {
        MarginCallRequestIdentification = reqMarginCallRequestIdentification;
        DisputedAmount = reqDisputedAmount;
        DisputeDate = reqDisputeDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the margin call request.
    /// </summary>
    [IsoId("_Ulb4F9p-Ed-ak6NoX_4Aeg_-1356799575")]
    [DisplayName("Margin Call Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnCallReqId")]
    #endif
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MarginCallRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MarginCallRequestIdentification { get; init; } 
    #else
    public System.String MarginCallRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Disputed amount.
    /// </summary>
    [IsoId("_Ulb4GNp-Ed-ak6NoX_4Aeg_-1519744300")]
    [DisplayName("Disputed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptdAmt")]
    #endif
    [IsoXmlTag("DsptdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount DisputedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount DisputedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount DisputedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount DisputedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date of dispute.
    /// </summary>
    [IsoId("_UllpENp-Ed-ak6NoX_4Aeg_686253594")]
    [DisplayName("Dispute Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptDt")]
    #endif
    [IsoXmlTag("DsptDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate DisputeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly DisputeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly DisputeDate { get; init; } 
    #else
    public System.DateOnly DisputeDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
