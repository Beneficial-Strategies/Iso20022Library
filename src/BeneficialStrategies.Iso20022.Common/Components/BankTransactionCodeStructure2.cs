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
/// Code of the underlying bank transaction.
/// </summary>
[IsoId("_TVHftdp-Ed-ak6NoX_4Aeg_749476994")]
[DisplayName("Bank Transaction Code Structure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankTransactionCodeStructure2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BankTransactionCodeStructure2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankTransactionCodeStructure2( string reqCode,BankTransactionCodeStructure3 reqFamily )
    {
        Code = reqCode;
        Family = reqFamily;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the business area of the underlying transaction.
    /// </summary>
    [IsoId("_TVHfttp-Ed-ak6NoX_4Aeg_749477114")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionDomainCode Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Code { get; init; } 
    #else
    public string Code { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the family and the sub-family of the bank transaction code, within a specific domain, in a structured and hierarchical format.
    /// </summary>
    [IsoId("_TVHft9p-Ed-ak6NoX_4Aeg_-989327573")]
    [DisplayName("Family")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fmly")]
    #endif
    [IsoXmlTag("Fmly")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankTransactionCodeStructure3 Family { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankTransactionCodeStructure3 Family { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure3 Family { get; init; } 
    #else
    public BankTransactionCodeStructure3 Family { get; set; } 
    #endif
    
    
    #nullable disable
    
}
