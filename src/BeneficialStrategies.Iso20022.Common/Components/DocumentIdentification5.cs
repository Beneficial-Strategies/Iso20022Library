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
/// Identifies a document by a unique identification and its issuer.
/// </summary>
[IsoId("_RJWLsdp-Ed-ak6NoX_4Aeg_-86119846")]
[DisplayName("Document Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentIdentification5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentIdentification5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentIdentification5( System.String reqIdentification,BICIdentification1 reqIdentificationIssuer )
    {
        Identification = reqIdentification;
        IdentificationIssuer = reqIdentificationIssuer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a set of data.
    /// </summary>
    [IsoId("_RJWLstp-Ed-ak6NoX_4Aeg_109665302")]
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
    /// Uniquely identifies the financial institution which has issued the identification of the set of data by using a BIC.
    /// </summary>
    [IsoId("_RJWLs9p-Ed-ak6NoX_4Aeg_601412896")]
    [DisplayName("Identification Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdIssr")]
    #endif
    [IsoXmlTag("IdIssr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 IdentificationIssuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 IdentificationIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 IdentificationIssuer { get; init; } 
    #else
    public BICIdentification1 IdentificationIssuer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
