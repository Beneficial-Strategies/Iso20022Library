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
[IsoId("_kOqpAIW2EeiDBOVr6AJAFA")]
[DisplayName("Tracker Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerData1( DateAndDateTime2Choice_ reqConfirmedDate,ActiveCurrencyAndAmount reqConfirmedAmount )
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
    [IsoId("_n9zF0IW5EeiDBOVr6AJAFA")]
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
    /// Amount of money confirmed to the tracking system by the agent.
    /// </summary>
    [IsoId("_se8VwIW5EeiDBOVr6AJAFA")]
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
    /// Provides tracker transaction information for a specific agent involved in the transaction chain. 
    /// </summary>
    [IsoId("_x5xmwIW5EeiDBOVr6AJAFA")]
    [DisplayName("Tracker Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrRcrd")]
    #endif
    [IsoXmlTag("TrckrRcrd")]
    public ValueList<TrackerRecord1> TrackerRecord { get; init; } = new ValueList<TrackerRecord1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _x5xmwIW5EeiDBOVr6AJAFA
    
    
    #nullable disable
    
}
