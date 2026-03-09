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
/// Reports either on the collateral value report or on a business error.
/// </summary>
[IsoId("_-DiXdTpvEemk2e6qGBk8IQ")]
[DisplayName("Collateral Value Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValueReport3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralValueReport3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralValueReport3( CashAccount38 reqCashAccount )
    {
        CashAccount = reqCashAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account on which information is requested.
    /// </summary>
    [IsoId("_-ORAwTpvEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount38 CashAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount38 CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38 CashAccount { get; init; } 
    #else
    public CashAccount38 CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_wBoGcjpwEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctOwnr")]
    #endif
    [IsoXmlTag("CshAcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification11? CashAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification11? CashAccountOwner { get; init; } 
    #else
    public SystemPartyIdentification11? CashAccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_wBoGczpwEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctSvcr")]
    #endif
    [IsoXmlTag("CshAcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account owner.
    /// </summary>
    [IsoId("_-ORAwzpvEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctOwnr")]
    #endif
    [IsoXmlTag("SctiesAcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification8? SecuritiesAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8? SecuritiesAccountOwner { get; init; } 
    #else
    public SystemPartyIdentification8? SecuritiesAccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the securities account on behalf of the account owner.
    /// </summary>
    [IsoId("_-ORAxTpvEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctSvcr")]
    #endif
    [IsoXmlTag("SctiesAcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? SecuritiesAccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? SecuritiesAccountServicer { get; init; } 
    #else
    public PartyIdentification136? SecuritiesAccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information specific to the report on collateral value positions.
    /// </summary>
    [IsoId("_-ORAxzpvEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollValRpt")]
    #endif
    [IsoXmlTag("CollValRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralValueReportOrError6Choice_? CollateralValueReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralValueReportOrError6Choice_? CollateralValueReport { get; init; } 
    #else
    public CollateralValueReportOrError6Choice_? CollateralValueReport { get; set; } 
    #endif
    
    
    #nullable disable
    
}
