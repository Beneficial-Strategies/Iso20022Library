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
/// Information to support the Know Your Customer processes.
/// </summary>
[IsoId("_TUhp1dp-Ed-ak6NoX_4Aeg_-300374569")]
[DisplayName("Party Profile Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyProfileInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyProfileInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyProfileInformation1( System.String reqCertificationIndicator,CertificateType1Code reqCertificateType,System.String reqExtendedCertificateType )
    {
        CertificationIndicator = reqCertificationIndicator;
        CertificateType = reqCertificateType;
        ExtendedCertificateType = reqExtendedCertificateType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the certificate type has been obtained and verified.
    /// </summary>
    [IsoId("_TUhp1tp-Ed-ak6NoX_4Aeg_903696093")]
    [DisplayName("Certification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnInd")]
    #endif
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CertificationIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CertificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CertificationIndicator { get; init; } 
    #else
    public System.String CertificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person who validated the document.
    /// </summary>
    [IsoId("_TUhp19p-Ed-ak6NoX_4Aeg_497583653")]
    [DisplayName("Validating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtngPty")]
    #endif
    [IsoXmlTag("VldtngPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ValidatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValidatingParty { get; init; } 
    #else
    public System.String? ValidatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person who checked the document.
    /// </summary>
    [IsoId("_TUhp2Np-Ed-ak6NoX_4Aeg_-461332733")]
    [DisplayName("Checking Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckngPty")]
    #endif
    [IsoXmlTag("ChckngPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CheckingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CheckingParty { get; init; } 
    #else
    public System.String? CheckingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person who is responsible for the document.
    /// </summary>
    [IsoId("_TUhp2dp-Ed-ak6NoX_4Aeg_368913503")]
    [DisplayName("Responsible Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPty")]
    #endif
    [IsoXmlTag("RspnsblPty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ResponsibleParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponsibleParty { get; init; } 
    #else
    public System.String? ResponsibleParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of certificate.
    /// </summary>
    [IsoId("_TUhp2tp-Ed-ak6NoX_4Aeg_301560457")]
    [DisplayName("Certificate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertTp")]
    #endif
    [IsoXmlTag("CertTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CertificateType1Code CertificateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CertificateType1Code CertificateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateType1Code CertificateType { get; init; } 
    #else
    public CertificateType1Code CertificateType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of certificate.
    /// </summary>
    [IsoId("_TUra0Np-Ed-ak6NoX_4Aeg_536135706")]
    [DisplayName("Extended Certificate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedCertTp")]
    #endif
    [IsoXmlTag("XtndedCertTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedCertificateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedCertificateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedCertificateType { get; init; } 
    #else
    public System.String ExtendedCertificateType { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the certification check has been performed.
    /// </summary>
    [IsoId("_TUra0dp-Ed-ak6NoX_4Aeg_-459485436")]
    [DisplayName("Checking Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckngDt")]
    #endif
    [IsoXmlTag("ChckngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CheckingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CheckingDate { get; init; } 
    #else
    public System.DateOnly? CheckingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how frequently the check is performed.
    /// </summary>
    [IsoId("_TUra0tp-Ed-ak6NoX_4Aeg_-458560305")]
    [DisplayName("Checking Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckngFrqcy")]
    #endif
    [IsoXmlTag("ChckngFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventFrequency1Code? CheckingFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency1Code? CheckingFrequency { get; init; } 
    #else
    public EventFrequency1Code? CheckingFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date at which the next certification check will be performed.
    /// </summary>
    [IsoId("_TUra09p-Ed-ak6NoX_4Aeg_-456714285")]
    [DisplayName("Next Revision Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtRvsnDt")]
    #endif
    [IsoXmlTag("NxtRvsnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NextRevisionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NextRevisionDate { get; init; } 
    #else
    public System.DateOnly? NextRevisionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Limits between which a person&apos;s salary is estimated.
    /// </summary>
    [IsoId("_TUra1Np-Ed-ak6NoX_4Aeg_-444706221")]
    [DisplayName("Salary Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlryRg")]
    #endif
    [IsoXmlTag("SlryRg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SalaryRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SalaryRange { get; init; } 
    #else
    public System.String? SalaryRange { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the main source of revenue.
    /// </summary>
    [IsoId("_TUra1dp-Ed-ak6NoX_4Aeg_-206438748")]
    [DisplayName("Source Of Wealth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcOfWlth")]
    #endif
    [IsoXmlTag("SrcOfWlth")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SourceOfWealth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SourceOfWealth { get; init; } 
    #else
    public System.String? SourceOfWealth { get; set; } 
    #endif
    
    
    #nullable disable
    
}
