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
/// Unique identifier of an account, as assigned by the account servicer.
/// </summary>
[IsoId("_WHfgudp-Ed-ak6NoX_4Aeg_655013533")]
[DisplayName("Account Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountIdentification2( System.String reqIBAN )
    {
        IBAN = reqIBAN;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of a customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 &quot;Banking and related financial services - International Bank Account Number (IBAN)&quot; version 1997-10-01, or later revisions.
    /// </summary>
    [IsoId("_WHfgutp-Ed-ak6NoX_4Aeg_701188999")]
    [DisplayName("IBAN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IBAN")]
    #endif
    [IsoXmlTag("IBAN")]
    [IsoSimpleType(IsoSimpleType.IBANIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoIBANIdentifier IBAN { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IBAN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IBAN { get; init; } 
    #else
    public System.String IBAN { get; set; } 
    #endif
    
    
    #nullable disable
    
}
