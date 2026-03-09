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
[IsoId("_TVRQuNp-Ed-ak6NoX_4Aeg_-1028115455")]
[DisplayName("Bank Transaction Code Structure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankTransactionCodeStructure3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BankTransactionCodeStructure3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankTransactionCodeStructure3( string reqCode,string reqSubFamilyCode )
    {
        Code = reqCode;
        SubFamilyCode = reqSubFamilyCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the family within a domain.
    /// </summary>
    [IsoId("_TVRQudp-Ed-ak6NoX_4Aeg_-1028115424")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionFamilyCode Code { get; init; } 
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
    [IsoId("_TVRQutp-Ed-ak6NoX_4Aeg_-1028115394")]
    [DisplayName("Sub Family Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubFmlyCd")]
    #endif
    [IsoXmlTag("SubFmlyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalBankTransactionSubFamilyCode SubFamilyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SubFamilyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SubFamilyCode { get; init; } 
    #else
    public string SubFamilyCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
