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
/// Contains verification information.
/// </summary>
[IsoId("_SSs6A9ImEeirx-13kKhDlQ")]
[DisplayName("Verification Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VerificationInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the verification or authentication.
    /// ISO 8583:2003 bit 34
    /// </summary>
    [IsoId("_SSthENImEeirx-13kKhDlQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the data to be verified or authenticated.
    /// </summary>
    [IsoId("_SSthEdImEeirx-13kKhDlQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VerificationValue1Choice_? Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VerificationValue1Choice_? Value { get; init; } 
    #else
    public VerificationValue1Choice_? Value { get; set; } 
    #endif
    
    /// <summary>
    /// Reason to perform the verification.
    /// </summary>
    [IsoId("_DDFDQdIoEeirx-13kKhDlQ")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when the verification was performed.
    /// </summary>
    [IsoId("__IV3sGzVEemD24gVaMSpeA")]
    [DisplayName("Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtTm")]
    #endif
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DateTime { get; init; } 
    #else
    public System.DateTime? DateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Contains end date of the verification that has been performed. 
    /// </summary>
    [IsoId("_akg48GzWEemD24gVaMSpeA")]
    [DisplayName("Validity End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyEndDt")]
    #endif
    [IsoXmlTag("VldtyEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidityEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidityEndDate { get; init; } 
    #else
    public System.DateOnly? ValidityEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Contains end time of the verification that has been performed. 
    /// </summary>
    [IsoId("_OOdrgHC2EemD24gVaMSpeA")]
    [DisplayName("Validity End Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyEndTm")]
    #endif
    [IsoXmlTag("VldtyEndTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? ValidityEndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? ValidityEndTime { get; init; } 
    #else
    public System.TimeOnly? ValidityEndTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
