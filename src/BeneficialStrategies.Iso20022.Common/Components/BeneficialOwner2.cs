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
/// Provides information about the beneficial owner of the securities.
/// </summary>
[IsoId("_vfLMYbv-EeOgOuxYpBEzKg")]
[DisplayName("Beneficial Owner")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BeneficialOwner2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BeneficialOwner2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BeneficialOwner2( PartyIdentification100 reqBeneficialOwnerIdentification )
    {
        BeneficialOwnerIdentification = reqBeneficialOwnerIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party that is the beneficial owner of the specified financial instrument.
    /// </summary>
    [IsoId("_vq8-kbv-EeOgOuxYpBEzKg")]
    [DisplayName("Beneficial Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrId")]
    #endif
    [IsoXmlTag("BnfclOwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification100 BeneficialOwnerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification100 BeneficialOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100 BeneficialOwnerIdentification { get; init; } 
    #else
    public PartyIdentification100 BeneficialOwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional identification of the party that is the beneficial owner of the specified financial instrument.
    /// </summary>
    [IsoId("_vq8-k7v-EeOgOuxYpBEzKg")]
    [DisplayName("Additional Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlId")]
    #endif
    [IsoXmlTag("AddtlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternateIdentification4? AdditionalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternateIdentification4? AdditionalIdentification { get; init; } 
    #else
    public AlternateIdentification4? AdditionalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Nationality of the beneficial owner.
    /// </summary>
    [IsoId("_vq8-lbv-EeOgOuxYpBEzKg")]
    [DisplayName("Nationality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntlty")]
    #endif
    [IsoXmlTag("Ntlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Nationality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Nationality { get; init; } 
    #else
    public string? Nationality { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the person is permanently domiciled (the place of a person&apos;s permanent home).
    /// </summary>
    [IsoId("_vq8-l7v-EeOgOuxYpBEzKg")]
    [DisplayName("Domicile Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmclCtry")]
    #endif
    [IsoXmlTag("DmclCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? DomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DomicileCountry { get; init; } 
    #else
    public string? DomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country for which the holder of the financial instrument must specify that it is not domiciled. (The holder must certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.).
    /// </summary>
    [IsoId("_vq8-mbv-EeOgOuxYpBEzKg")]
    [DisplayName("Non Domicile Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonDmclCtry")]
    #endif
    [IsoXmlTag("NonDmclCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? NonDomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NonDomicileCountry { get; init; } 
    #else
    public string? NonDomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether certification is required from the account owner. (Yes means that certification is required. No means certification is not required.).
    /// </summary>
    [IsoId("_vq8-m7v-EeOgOuxYpBEzKg")]
    [DisplayName("Certification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnInd")]
    #endif
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationIndicator { get; init; } 
    #else
    public System.String? CertificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of beneficial owner certification that is required.
    /// </summary>
    [IsoId("_vq8-nbv-EeOgOuxYpBEzKg")]
    [DisplayName("Certification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnTp")]
    #endif
    [IsoXmlTag("CertfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType9Choice_? CertificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType9Choice_? CertificationType { get; init; } 
    #else
    public BeneficiaryCertificationType9Choice_? CertificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Declaration details related to the financial instrument, for example, beneficial ownership.
    /// </summary>
    [IsoId("_vq8-n7v-EeOgOuxYpBEzKg")]
    [DisplayName("Declaration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrtnDtls")]
    #endif
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? DeclarationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclarationDetails { get; init; } 
    #else
    public System.String? DeclarationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
