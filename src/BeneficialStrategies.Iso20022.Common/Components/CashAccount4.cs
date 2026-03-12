// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_SOo_2Np-Ed-ak6NoX_4Aeg_1895658095")]
[DisplayName("Cash Account")]
public partial record CashAccount4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SOyJwNp-Ed-ak6NoX_4Aeg_1760558737")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentificationAndName3 Identification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_SOyJwdp-Ed-ak6NoX_4Aeg_73616744")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification2Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_SOyJwtp-Ed-ak6NoX_4Aeg_70844740")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_SOyJw9p-Ed-ak6NoX_4Aeg_-594739147")]
    [DisplayName("Account Servicer Branch")]
    [IsoXmlTag("AcctSvcrBrnch")]
    public BranchData? AccountServicerBranch { get; init; } 
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_SOyJxNp-Ed-ak6NoX_4Aeg_2924093")]
    [DisplayName("Investment Account Type")]
    [IsoXmlTag("InvstmtAcctTp")]
    public FundCashAccount2Code? InvestmentAccountType { get; init; } 
    
    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_SOyJxdp-Ed-ak6NoX_4Aeg_-158034192")]
    [DisplayName("Extended Investment Account Type")]
    [IsoXmlTag("XtndedInvstmtAcctTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedInvestmentAccountType { get; init; } 
    
    
    #nullable disable
    
}
