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
/// Specifies the reason for cancelling a meeting.
/// </summary>
[IsoId("_RVRH0Np-Ed-ak6NoX_4Aeg_1713659135")]
[DisplayName("Meeting Cancellation Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingCancellationReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingCancellationReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingCancellationReason1( MeetingCancellationReason2Code reqCode,System.String reqExtendedCode )
    {
        Code = reqCode;
        ExtendedCode = reqExtendedCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for cancelling a meeting in coded form.
    /// </summary>
    [IsoId("_RVRH0dp-Ed-ak6NoX_4Aeg_1713659137")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingCancellationReason2Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingCancellationReason2Code Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingCancellationReason2Code Code { get; init; } 
    #else
    public MeetingCancellationReason2Code Code { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for cancelling a meeting in free text form.
    /// </summary>
    [IsoId("_RVRH0tp-Ed-ak6NoX_4Aeg_-1141003800")]
    [DisplayName("Extended Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedCd")]
    #endif
    [IsoXmlTag("XtndedCd")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedCode { get; init; } 
    #else
    public System.String ExtendedCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides more information on the reason for cancelling a meeting in free format form.
    /// </summary>
    [IsoId("_RVRH09p-Ed-ak6NoX_4Aeg_1713659188")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReason { get; init; } 
    #else
    public System.String? CancellationReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
