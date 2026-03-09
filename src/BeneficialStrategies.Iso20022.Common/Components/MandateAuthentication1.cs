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
/// Specifies the transport authentication details related to the mandate.
/// </summary>
[IsoId("_HSGqsGVVEeacpJ-gG9kyUQ")]
[DisplayName("Mandate Authentication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateAuthentication1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies a piece of information used to authenticate a message, that is to confirm that the message came from the stated sender (its authenticity) and has not been changed in transit (its integrity).
    /// </summary>
    [IsoId("_Tw5GoGVVEeacpJ-gG9kyUQ")]
    [DisplayName("Message Authentication Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgAuthntcnCd")]
    #endif
    [IsoXmlTag("MsgAuthntcnCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? MessageAuthenticationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageAuthenticationCode { get; init; } 
    #else
    public System.String? MessageAuthenticationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the authentication was conducted.
    /// </summary>
    [IsoId("_Z4U-8GVVEeacpJ-gG9kyUQ")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Channel used to transmit the authentication information.
    /// </summary>
    [IsoId("_zsoqgGVVEeacpJ-gG9kyUQ")]
    [DisplayName("Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chanl")]
    #endif
    [IsoXmlTag("Chanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationChannel1Choice_? Channel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationChannel1Choice_? Channel { get; init; } 
    #else
    public AuthenticationChannel1Choice_? Channel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
