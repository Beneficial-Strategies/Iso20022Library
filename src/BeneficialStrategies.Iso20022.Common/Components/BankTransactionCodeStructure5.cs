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
/// Set of elements used to identify the type or operations code of a transaction entry.
/// </summary>
[IsoId("_TVbBstp-Ed-ak6NoX_4Aeg_-1809965694")]
[DisplayName("Bank Transaction Code Structure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankTransactionCodeStructure5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BankTransactionCodeStructure5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankTransactionCodeStructure5( string reqCode,BankTransactionCodeStructure6 reqFamily )
    {
        Code = reqCode;
        Family = reqFamily;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the business area of the underlying transaction.
    /// </summary>
    [IsoId("_TVbBs9p-Ed-ak6NoX_4Aeg_-1809965664")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionDomain1Code Code { get; init; } 
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
    [IsoId("_TVbBtNp-Ed-ak6NoX_4Aeg_-1809965570")]
    [DisplayName("Family")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fmly")]
    #endif
    [IsoXmlTag("Fmly")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankTransactionCodeStructure6 Family { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankTransactionCodeStructure6 Family { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure6 Family { get; init; } 
    #else
    public BankTransactionCodeStructure6 Family { get; set; } 
    #endif
    
    
    #nullable disable
    
}
