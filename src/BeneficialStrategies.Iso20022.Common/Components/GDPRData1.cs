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
/// Information about an individual&apos;s consent to use personal data under the General Protection Regulation (GDPR) 2016/679 regulation.
/// </summary>
[IsoId("_7r9TsJTSEemC09f0MxYkRg")]
[DisplayName("GDPR Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GDPRData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GDPRData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GDPRData1( GDPRDataConsent1Choice_ reqConsentType,System.String reqConsentIndicator,System.DateOnly reqConsentDate )
    {
        ConsentType = reqConsentType;
        ConsentIndicator = reqConsentIndicator;
        ConsentDate = reqConsentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of consent.
    /// </summary>
    [IsoId("_BaPFIJTTEemC09f0MxYkRg")]
    [DisplayName("Consent Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnsntTp")]
    #endif
    [IsoXmlTag("CnsntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GDPRDataConsent1Choice_ ConsentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GDPRDataConsent1Choice_ ConsentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GDPRDataConsent1Choice_ ConsentType { get; init; } 
    #else
    public GDPRDataConsent1Choice_ ConsentType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether consent has been given.
    /// </summary>
    [IsoId("_6seTAJTaEemC09f0MxYkRg")]
    [DisplayName("Consent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnsntInd")]
    #endif
    [IsoXmlTag("CnsntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ConsentIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ConsentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ConsentIndicator { get; init; } 
    #else
    public System.String ConsentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the consent.
    /// </summary>
    [IsoId("_-uSioJTaEemC09f0MxYkRg")]
    [DisplayName("Consent Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnsntDt")]
    #endif
    [IsoXmlTag("CnsntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ConsentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ConsentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ConsentDate { get; init; } 
    #else
    public System.DateOnly ConsentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
