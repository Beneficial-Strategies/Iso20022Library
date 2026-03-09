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
/// Tax identification information.
/// </summary>
[IsoId("_ZEtY8QhGEeSUPbC7DbLJpQ")]
[DisplayName("Tax Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxIdentification2( System.String reqIdentification,TaxIdentificationType1Choice_ reqTaxIdentificationType,string reqIssuerCountry )
    {
        Identification = reqIdentification;
        TaxIdentificationType = reqTaxIdentificationType;
        IssuerCountry = reqIssuerCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Tax identification number or identifier.
    /// </summary>
    [IsoId("_hD6rMQhGEeSUPbC7DbLJpQ")]
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
    /// Type of tax identification number or identifier.
    /// </summary>
    [IsoId("_ooC5EQhIEeSUPbC7DbLJpQ")]
    [DisplayName("Tax Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxIdTp")]
    #endif
    [IsoXmlTag("TaxIdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxIdentificationType1Choice_ TaxIdentificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxIdentificationType1Choice_ TaxIdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxIdentificationType1Choice_ TaxIdentificationType { get; init; } 
    #else
    public TaxIdentificationType1Choice_ TaxIdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_BpuDRAhIEeSUPbC7DbLJpQ")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Issuer { get; init; } 
    #else
    public System.String? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the identification was issued.
    /// </summary>
    [IsoId("_BpuDRQhIEeSUPbC7DbLJpQ")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssueDate { get; init; } 
    #else
    public System.DateOnly? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the identification expires.
    /// </summary>
    [IsoId("_BpuDRghIEeSUPbC7DbLJpQ")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpiryDate { get; init; } 
    #else
    public System.DateOnly? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Country that issued the tax identification.
    /// </summary>
    [IsoId("_Zg-eNQhGEeSUPbC7DbLJpQ")]
    [DisplayName("Issuer Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrCtry")]
    #endif
    [IsoXmlTag("IssrCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode IssuerCountry { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string IssuerCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string IssuerCountry { get; init; } 
    #else
    public string IssuerCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
