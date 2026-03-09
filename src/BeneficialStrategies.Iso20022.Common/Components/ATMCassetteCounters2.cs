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
/// Counters of media inside an ATM cassette.
/// </summary>
[IsoId("_2nkHEYqhEeS4a4abTJTSSw")]
[DisplayName("ATM Cassette Counters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCassetteCounters2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCassetteCounters2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCassetteCounters2( ATMCounterType1Code reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of counters.
    /// </summary>
    [IsoId("_GUVFcIqjEeS4a4abTJTSSw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCounterType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCounterType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCounterType1Code Type { get; init; } 
    #else
    public ATMCounterType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Number of added media during servicing operations.
    /// </summary>
    [IsoId("_ON_wYIqjEeS4a4abTJTSSw")]
    [DisplayName("Added Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddedNb")]
    #endif
    [IsoXmlTag("AddedNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? AddedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? AddedNumber { get; init; } 
    #else
    public System.UInt64? AddedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number of removed media during servicing operations.
    /// </summary>
    [IsoId("_RFb3kIqjEeS4a4abTJTSSw")]
    [DisplayName("Removed Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmvdNb")]
    #endif
    [IsoXmlTag("RmvdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? RemovedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RemovedNumber { get; init; } 
    #else
    public System.UInt64? RemovedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of media out of the cassette.
    /// </summary>
    [IsoId("_UN3BEIqjEeS4a4abTJTSSw")]
    [DisplayName("Dispensed Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DspnsdNb")]
    #endif
    [IsoXmlTag("DspnsdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DispensedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DispensedNumber { get; init; } 
    #else
    public System.UInt64? DispensedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of media deposited in the cassette.
    /// </summary>
    [IsoId("_XPbUoIqjEeS4a4abTJTSSw")]
    [DisplayName("Deposit Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstNb")]
    #endif
    [IsoXmlTag("DpstNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DepositNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DepositNumber { get; init; } 
    #else
    public System.UInt64? DepositNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of recycled media from the cassette.
    /// </summary>
    [IsoId("_aA59wIqjEeS4a4abTJTSSw")]
    [DisplayName("Recycled Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcycldNb")]
    #endif
    [IsoXmlTag("RcycldNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? RecycledNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RecycledNumber { get; init; } 
    #else
    public System.UInt64? RecycledNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of retracted media originating from the cassette.
    /// </summary>
    [IsoId("_dBk5cIqjEeS4a4abTJTSSw")]
    [DisplayName("Retracted Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrctdNb")]
    #endif
    [IsoXmlTag("RtrctdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? RetractedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RetractedNumber { get; init; } 
    #else
    public System.UInt64? RetractedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of media from this cassette which are on the reject bin.
    /// </summary>
    [IsoId("_gIzwIIqjEeS4a4abTJTSSw")]
    [DisplayName("Rejected Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdNb")]
    #endif
    [IsoXmlTag("RjctdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? RejectedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RejectedNumber { get; init; } 
    #else
    public System.UInt64? RejectedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of media presented to the customer.
    /// </summary>
    [IsoId("_jF-r4IqjEeS4a4abTJTSSw")]
    [DisplayName("Presented Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntdNb")]
    #endif
    [IsoXmlTag("PresntdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PresentedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PresentedNumber { get; init; } 
    #else
    public System.UInt64? PresentedNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
