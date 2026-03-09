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
/// Specifies the detailed information as provided by a payment tracking system.
/// </summary>
[IsoId("_uu9vLVc8EeunQrLahSRvvA")]
[DisplayName("Tracker Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerData6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerData6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerData6( DateAndDateTime2Choice_ reqConfirmedDate,ActiveCurrencyAndAmount reqConfirmedAmount )
    {
        ConfirmedDate = reqConfirmedDate;
        ConfirmedAmount = reqConfirmedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point in time when an update to the tracking system has been confirmed. 
    /// Usage: 
    /// This date can be the point in time when an agent provides a pending status update to the tracking system or when the creditor has been credited and can use the amount of money (as confirmed to the tracking system by the creditor agent).
    /// </summary>
    [IsoId("_uvkLsVc8EeunQrLahSRvvA")]
    [DisplayName("Confirmed Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdDt")]
    #endif
    [IsoXmlTag("ConfdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ ConfirmedDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ ConfirmedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ ConfirmedDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ ConfirmedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money effectively credited to the creditor and confirmed to the tracking system by the agent.
    /// </summary>
    [IsoId("_uvkLs1c8EeunQrLahSRvvA")]
    [DisplayName("Confirmed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdAmt")]
    #endif
    [IsoXmlTag("ConfdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ConfirmedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ConfirmedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ConfirmedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ConfirmedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money remaining to be confirmed.
    /// </summary>
    [IsoId("_uvkLtVc8EeunQrLahSRvvA")]
    [DisplayName("Remaining To Be Confirmed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngToBeConfdAmt")]
    #endif
    [IsoXmlTag("RmngToBeConfdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RemainingToBeConfirmedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RemainingToBeConfirmedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RemainingToBeConfirmedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money previously credited to the creditor and confirmed to the tracking system by the agent.
    /// </summary>
    [IsoId("_uvkLt1c8EeunQrLahSRvvA")]
    [DisplayName("Previously Confirmed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslyConfdAmt")]
    #endif
    [IsoXmlTag("PrevslyConfdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PreviouslyConfirmedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PreviouslyConfirmedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PreviouslyConfirmedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Point in time when the previous amount was confirmed.
    /// Usage: 
    /// This date provides the point in time when the last previous confirmed amount was provided to the tracker, in case of a partial confirmation.
    /// </summary>
    [IsoId("_uvkLuVc8EeunQrLahSRvvA")]
    [DisplayName("Previously Confirmed Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslyConfdDt")]
    #endif
    [IsoXmlTag("PrevslyConfdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? PreviouslyConfirmedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? PreviouslyConfirmedDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? PreviouslyConfirmedDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
