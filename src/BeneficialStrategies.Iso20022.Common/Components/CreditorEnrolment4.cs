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
/// Specifies the attributes of the creditor used for a creditor enrolment.
/// </summary>
[IsoId("_UdRMV-H7Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditorEnrolment4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditorEnrolment4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditorEnrolment4( RTPPartyIdentification1 reqCreditor )
    {
        Creditor = reqCreditor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed activation data related to the creditor enrolment. 
    /// </summary>
    [IsoId("_UedfIeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Enrolment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Enrlmnt")]
    #endif
    [IsoXmlTag("Enrlmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorServiceEnrolment1? Enrolment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorServiceEnrolment1? Enrolment { get; init; } 
    #else
    public CreditorServiceEnrolment1? Enrolment { get; set; } 
    #endif
    
    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another, such as the brand name.
    /// </summary>
    [IsoId("_UedfI-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor Trading Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrTradgNm")]
    #endif
    [IsoXmlTag("CdtrTradgNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CreditorTradingName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorTradingName { get; init; } 
    #else
    public System.String? CreditorTradingName { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_UedfJeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RTPPartyIdentification1 Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RTPPartyIdentification1 Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RTPPartyIdentification1 Creditor { get; init; } 
    #else
    public RTPPartyIdentification1 Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_UedfJ-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RTPPartyIdentification1? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RTPPartyIdentification1? UltimateCreditor { get; init; } 
    #else
    public RTPPartyIdentification1? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of a business by the types of goods or services it provides.
    /// </summary>
    [IsoId("_UedfKeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.MerchantCategoryCodeIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMerchantCategoryCodeIdentifier? MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantCategoryCode { get; init; } 
    #else
    public System.String? MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Commercial logo of the creditor.
    /// </summary>
    [IsoId("_UedfK-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor Logo")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrLogo")]
    #endif
    [IsoXmlTag("CdtrLogo")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? CreditorLogo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? CreditorLogo { get; init; } 
    #else
    public System.Byte[]? CreditorLogo { get; set; } 
    #endif
    
    
    #nullable disable
    
}
