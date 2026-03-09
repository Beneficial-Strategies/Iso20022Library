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
/// Operational construct of a central counterparty that defines the relationship between collateral, margin and position accounts and upon default of a clearing member defines the segregation of losses on positions and assets held in such accounts.
/// </summary>
[IsoId("_zZQ3oZXeEeaEh9L5Y0ZaKQ")]
[DisplayName("Clearing Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingAccount1( ClearingAccountType3Code reqAccountType )
    {
        AccountType = reqAccountType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the type of clearing account.
    /// </summary>
    [IsoId("_4qXrUKsbEeayv9XxdmMwKQ")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClearingAccountType3Code AccountType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClearingAccountType3Code AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingAccountType3Code AccountType { get; init; } 
    #else
    public ClearingAccountType3Code AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty.
    /// </summary>
    [IsoId("_fXQ-0HX_Eee_qcLXasnA4g")]
    [DisplayName("Collateral Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollAcctOwnr")]
    #endif
    [IsoXmlTag("CollAcctOwnr")]
    public ValueList<CollateralAccount5> CollateralAccountOwner { get; init; } = new ValueList<CollateralAccount5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _fXQ-0HX_Eee_qcLXasnA4g
    
    
    #nullable disable
    
}
