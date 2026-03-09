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
/// Provides detailed information on the transaction and it&apos;s status as updated in the tracker.
/// </summary>
[IsoId("_k0GOJ_Y0Eemf4dJxCjghNw")]
[DisplayName("Tracker Status And Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerStatusAndTransaction4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerStatusAndTransaction4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerStatusAndTransaction4( TrackerAlertNotificationStatus2 reqAlertStatus,TrackerPaymentTransaction4 reqTransaction )
    {
        AlertStatus = reqAlertStatus;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the alert notification in the tracker.
    /// </summary>
    [IsoId("_k0GOK_Y0Eemf4dJxCjghNw")]
    [DisplayName("Alert Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlrtSts")]
    #endif
    [IsoXmlTag("AlrtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerAlertNotificationStatus2 AlertStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerAlertNotificationStatus2 AlertStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerAlertNotificationStatus2 AlertStatus { get; init; } 
    #else
    public TrackerAlertNotificationStatus2 AlertStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_k0GOLfY0Eemf4dJxCjghNw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerPaymentTransaction4 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerPaymentTransaction4 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPaymentTransaction4 Transaction { get; init; } 
    #else
    public TrackerPaymentTransaction4 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
