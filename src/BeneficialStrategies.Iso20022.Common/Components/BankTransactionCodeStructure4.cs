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
[IsoId("_TVbBtdp-Ed-ak6NoX_4Aeg_-549688189")]
[DisplayName("Bank Transaction Code Structure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankTransactionCodeStructure4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide the domain, the family and the sub-family of the bank transaction code, in a structured and hierarchical format.||Usage: If a specific family or sub-family code cannot be provided, the generic family code defined for the domain or the generic sub-family code defined for the family should be provided.
    /// </summary>
    [IsoId("_TVbBttp-Ed-ak6NoX_4Aeg_-549687856")]
    [DisplayName("Domain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Domn")]
    #endif
    [IsoXmlTag("Domn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BankTransactionCodeStructure5? Domain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure5? Domain { get; init; } 
    #else
    public BankTransactionCodeStructure5? Domain { get; set; } 
    #endif
    
    /// <summary>
    /// Bank transaction code in a proprietary form, as defined by the issuer.
    /// </summary>
    [IsoId("_TVbBt9p-Ed-ak6NoX_4Aeg_-549687485")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryBankTransactionCodeStructure1? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryBankTransactionCodeStructure1? Proprietary { get; init; } 
    #else
    public ProprietaryBankTransactionCodeStructure1? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
