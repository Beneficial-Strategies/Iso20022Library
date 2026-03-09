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
/// Indicates the form of the financial Instrument.
/// </summary>
[IsoId("_dPETJeLxEeWOD7aAy2fAcA")]
[DisplayName("Financial Instrument Form")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentForm2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the booking appearance of the financial Instrument.
    /// </summary>
    [IsoId("_dYSgkeLxEeWOD7aAy2fAcA")]
    [DisplayName("Booking Appearance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookgApprnc")]
    #endif
    [IsoXmlTag("BookgApprnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Appearance3Choice_? BookingAppearance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Appearance3Choice_? BookingAppearance { get; init; } 
    #else
    public Appearance3Choice_? BookingAppearance { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form, ie, ownership, of the security.
    /// </summary>
    [IsoId("_dYSgk-LxEeWOD7aAy2fAcA")]
    [DisplayName("Legal Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglForm")]
    #endif
    [IsoXmlTag("LglForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity8Choice_? LegalForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity8Choice_? LegalForm { get; init; } 
    #else
    public FormOfSecurity8Choice_? LegalForm { get; set; } 
    #endif
    
    
    #nullable disable
    
}
