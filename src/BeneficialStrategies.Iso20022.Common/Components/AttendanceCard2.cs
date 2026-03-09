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
/// Specifies details related to the attendance card.
/// </summary>
[IsoId("_TiranNp-Ed-ak6NoX_4Aeg_-1547572395")]
[DisplayName("Attendance Card")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AttendanceCard2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AttendanceCard2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AttendanceCard2( DeliveryPlace1Code reqDeliveryMethod )
    {
        DeliveryMethod = reqDeliveryMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information to be indicated on the attendance card.
    /// </summary>
    [IsoId("_Tirandp-Ed-ak6NoX_4Aeg_-1547572386")]
    [DisplayName("Attendance Card Labelling")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncCardLbllg")]
    #endif
    [IsoXmlTag("AttndncCardLbllg")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AttendanceCardLabelling { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AttendanceCardLabelling { get; init; } 
    #else
    public System.String? AttendanceCardLabelling { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies where the attendance card must be delivered.
    /// </summary>
    [IsoId("_Tirantp-Ed-ak6NoX_4Aeg_-1547572365")]
    [DisplayName("Delivery Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryMtd")]
    #endif
    [IsoXmlTag("DlvryMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeliveryPlace1Code DeliveryMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DeliveryPlace1Code DeliveryMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryPlace1Code DeliveryMethod { get; init; } 
    #else
    public DeliveryPlace1Code DeliveryMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Name and address of a party.
    /// </summary>
    [IsoId("_Ti1LkNp-Ed-ak6NoX_4Aeg_-1547572073")]
    [DisplayName("Other Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAdr")]
    #endif
    [IsoXmlTag("OthrAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress9? OtherAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress9? OtherAddress { get; init; } 
    #else
    public NameAndAddress9? OtherAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
