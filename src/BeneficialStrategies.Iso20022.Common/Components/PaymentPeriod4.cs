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
/// Specifies the payment terms by means of a code and a period.
/// </summary>
[IsoId("_H54EIRVgEeOrY9qSHVspCA")]
[DisplayName("Payment Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentPeriod4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentPeriod4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentPeriod4( PaymentTime4Code reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code for the payment.
    /// </summary>
    [IsoId("_IRIGgRVgEeOrY9qSHVspCA")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentTime4Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentTime4Code Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTime4Code Code { get; init; } 
    #else
    public PaymentTime4Code Code { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days after which the payment must be effected.
    /// </summary>
    [IsoId("_IRIGgxVgEeOrY9qSHVspCA")]
    [DisplayName("Number Of Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDays")]
    #endif
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDays { get; init; } 
    #else
    public System.UInt64? NumberOfDays { get; set; } 
    #endif
    
    
    #nullable disable
    
}
