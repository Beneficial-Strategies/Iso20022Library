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
[IsoId("_TVRQu9p-Ed-ak6NoX_4Aeg_1515822708")]
[DisplayName("Bank Transaction Code Structure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankTransactionCodeStructure6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BankTransactionCodeStructure6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankTransactionCodeStructure6( string reqCode,string reqSubFamilyCode )
    {
        Code = reqCode;
        SubFamilyCode = reqSubFamilyCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the family within a domain.
    /// </summary>
    [IsoId("_TVbBsNp-Ed-ak6NoX_4Aeg_1515822740")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionFamily1Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Code { get; init; } 
    #else
    public string Code { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the sub-product family within a specific family.
    /// </summary>
    [IsoId("_TVbBsdp-Ed-ak6NoX_4Aeg_1515822800")]
    [DisplayName("Sub Family Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubFmlyCd")]
    #endif
    [IsoXmlTag("SubFmlyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionSubFamily1Code SubFamilyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SubFamilyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SubFamilyCode { get; init; } 
    #else
    public string SubFamilyCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
