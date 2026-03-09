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
/// Information about an undertaking.
/// </summary>
[IsoId("_-FthiHltEeG7BsjMvd1mEw_-1983093565")]
[DisplayName("Undertaking")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Undertaking8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Undertaking8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Undertaking8( System.String reqIdentification,PartyIdentification43 reqIssuer )
    {
        Identification = reqIdentification;
        Issuer = reqIssuer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the issuer to the undertaking, for example the guarantee or standby number.
    /// </summary>
    [IsoId("_-F3SgHltEeG7BsjMvd1mEw_-9844509")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the undertaking.
    /// </summary>
    [IsoId("_-F3SgXltEeG7BsjMvd1mEw_444242760")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 Issuer { get; init; } 
    #else
    public PartyIdentification43 Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_-F3SgnltEeG7BsjMvd1mEw_1980172388")]
    [DisplayName("Applicant Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplcntRefNb")]
    #endif
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicantReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicantReferenceNumber { get; init; } 
    #else
    public System.String? ApplicantReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the beneficiary to the undertaking.
    /// </summary>
    [IsoId("_-F3Sg3ltEeG7BsjMvd1mEw_1024554528")]
    [DisplayName("Beneficiary Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryRefNb")]
    #endif
    [IsoXmlTag("BnfcryRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BeneficiaryReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BeneficiaryReferenceNumber { get; init; } 
    #else
    public System.String? BeneficiaryReferenceNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
