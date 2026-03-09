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
[IsoId("_nz76AWRPEeqImsG9JNoSQw")]
[DisplayName("Tracker Status And Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerStatusAndTransaction7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerStatusAndTransaction7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerStatusAndTransaction7( TrackerAlertNotificationStatus1 reqAlertStatus )
    {
        AlertStatus = reqAlertStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    [IsoId("_n7bpIWRPEeqImsG9JNoSQw")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerStatus2? TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerStatus2? TransactionStatus { get; init; } 
    #else
    public TrackerStatus2? TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the alert notification in the tracker.
    /// </summary>
    [IsoId("_n7bpI2RPEeqImsG9JNoSQw")]
    [DisplayName("Alert Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlrtSts")]
    #endif
    [IsoXmlTag("AlrtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerAlertNotificationStatus1 AlertStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerAlertNotificationStatus1 AlertStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerAlertNotificationStatus1 AlertStatus { get; init; } 
    #else
    public TrackerAlertNotificationStatus1 AlertStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_n7bpJWRPEeqImsG9JNoSQw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    public ValueList<TrackerPaymentTransaction7> Transaction { get; init; } = new ValueList<TrackerPaymentTransaction7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _n7bpJWRPEeqImsG9JNoSQw
    
    
    #nullable disable
    
}
