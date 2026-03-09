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
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_SOMT6Np-Ed-ak6NoX_4Aeg_-1967253219")]
[DisplayName("Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccount22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccount22 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccount22( System.String reqServicer,AccountIdentification5Choice_ reqIdentification,System.String reqAccountTypeDescription )
    {
        Servicer = reqServicer;
        Identification = reqIdentification;
        AccountTypeDescription = reqAccountTypeDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_SOWE4Np-Ed-ak6NoX_4Aeg_-1789134547")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_SOWE4dp-Ed-ak6NoX_4Aeg_-2081092285")]
    [DisplayName("Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svcr")]
    #endif
    [IsoXmlTag("Svcr")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBICIdentifier Servicer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Servicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Servicer { get; init; } 
    #else
    public System.String Servicer { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SOWE4tp-Ed-ak6NoX_4Aeg_-1902973613")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification5Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification5Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification5Choice_ Identification { get; init; } 
    #else
    public AccountIdentification5Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-division of a master or omnibus cash account.
    /// </summary>
    [IsoId("_SOWE49p-Ed-ak6NoX_4Aeg_-286714049")]
    [DisplayName("Secondary Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryAcct")]
    #endif
    [IsoXmlTag("ScndryAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount21? SecondaryAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount21? SecondaryAccount { get; init; } 
    #else
    public CashAccount21? SecondaryAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_SOWE5Np-Ed-ak6NoX_4Aeg_-268592078")]
    [DisplayName("Account Type Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTpDesc")]
    #endif
    [IsoXmlTag("AcctTpDesc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AccountTypeDescription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountTypeDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountTypeDescription { get; init; } 
    #else
    public System.String AccountTypeDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
