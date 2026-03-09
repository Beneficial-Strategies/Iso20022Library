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
/// Specifies the identification of a billing subservice.
/// </summary>
[IsoId("_6Oww65qlEeGSON8vddiWzQ_-1562075356")]
[DisplayName("Billing Sub Service Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingSubServiceIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingSubServiceIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingSubServiceIdentification1( BillingSubServiceQualifier1Choice_ reqIssuer,System.String reqIdentification )
    {
        Issuer = reqIssuer;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the qualifier of the sub service.
    /// </summary>
    [IsoId("_6Oww7JqlEeGSON8vddiWzQ_-1383956684")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingSubServiceQualifier1Choice_ Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingSubServiceQualifier1Choice_ Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingSubServiceQualifier1Choice_ Issuer { get; init; } 
    #else
    public BillingSubServiceQualifier1Choice_ Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Further defines a financial institution service, through the provision of the value required by the sub service qualifier, such as the actual lockbox number or store number.
    /// </summary>
    [IsoId("_6Oww7ZqlEeGSON8vddiWzQ_83192079")]
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
    
    
    #nullable disable
    
}
