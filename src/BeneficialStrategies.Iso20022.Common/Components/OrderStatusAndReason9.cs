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
/// Status report of a bulk or multiple or switch order cancellation instruction that was previously received.
/// </summary>
[IsoId("_5VcU1TbsEead9bDRE_1DAQ")]
[DisplayName("Order Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderStatusAndReason9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OrderStatusAndReason9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrderStatusAndReason9( CancellationStatus22Choice_ reqCancellationStatus )
    {
        CancellationStatus = reqCancellationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_5uS5tTbsEead9bDRE_1DAQ")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Cancellation status of the order cancellation.
    /// </summary>
    [IsoId("_MlLY8EgsEeaD2L_hzZaE0w")]
    [DisplayName("Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlSts")]
    #endif
    [IsoXmlTag("CxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationStatus22Choice_ CancellationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationStatus22Choice_ CancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatus22Choice_ CancellationStatus { get; init; } 
    #else
    public CancellationStatus22Choice_ CancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    [IsoId("_5uS5uzbsEead9bDRE_1DAQ")]
    [DisplayName("Status Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInitr")]
    #endif
    [IsoXmlTag("StsInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification113? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113? StatusInitiator { get; init; } 
    #else
    public PartyIdentification113? StatusInitiator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
