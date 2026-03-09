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
[IsoId("_SOo_2Np-Ed-ak6NoX_4Aeg_1895658095")]
[DisplayName("Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccount4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccount4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccount4( AccountIdentificationAndName3 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SOyJwNp-Ed-ak6NoX_4Aeg_1760558737")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentificationAndName3 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentificationAndName3 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName3 Identification { get; init; } 
    #else
    public AccountIdentificationAndName3 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_SOyJwdp-Ed-ak6NoX_4Aeg_73616744")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_SOyJwtp-Ed-ak6NoX_4Aeg_70844740")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_SOyJw9p-Ed-ak6NoX_4Aeg_-594739147")]
    [DisplayName("Account Servicer Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrBrnch")]
    #endif
    [IsoXmlTag("AcctSvcrBrnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchData? AccountServicerBranch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchData? AccountServicerBranch { get; init; } 
    #else
    public BranchData? AccountServicerBranch { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_SOyJxNp-Ed-ak6NoX_4Aeg_2924093")]
    [DisplayName("Investment Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctTp")]
    #endif
    [IsoXmlTag("InvstmtAcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundCashAccount2Code? InvestmentAccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundCashAccount2Code? InvestmentAccountType { get; init; } 
    #else
    public FundCashAccount2Code? InvestmentAccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_SOyJxdp-Ed-ak6NoX_4Aeg_-158034192")]
    [DisplayName("Extended Investment Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedInvstmtAcctTp")]
    #endif
    [IsoXmlTag("XtndedInvstmtAcctTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedInvestmentAccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedInvestmentAccountType { get; init; } 
    #else
    public System.String? ExtendedInvestmentAccountType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
