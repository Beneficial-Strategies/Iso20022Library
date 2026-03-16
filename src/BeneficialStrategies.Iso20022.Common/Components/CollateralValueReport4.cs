// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Collateral Value Report4.
/// </summary>
[IsoId("_zF1apTEyEe6g-ffJsqGiSA")]
[DisplayName("Collateral Value Report4")]
public partial record CollateralValueReport4
{
    #nullable enable

    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount40 CashAccount { get; init; } 

    /// <summary>
    /// Cash Account Owner.
    /// </summary>
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification11? CashAccountOwner { get; init; } 

    /// <summary>
    /// Cash Account Servicer.
    /// </summary>
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? CashAccountServicer { get; init; } 

    /// <summary>
    /// Collateral Value Report.
    /// </summary>
    [DisplayName("Collateral Value Report")]
    [IsoXmlTag("CollValRpt")]
    public ValueList<CollateralValueReportOrError6Choice_> CollateralValueReport { get; init; } = [];

    /// <summary>
    /// Securities Account Owner.
    /// </summary>
    [DisplayName("Securities Account Owner")]
    [IsoXmlTag("SctiesAcctOwnr")]
    public SystemPartyIdentification8? SecuritiesAccountOwner { get; init; } 

    /// <summary>
    /// Securities Account Servicer.
    /// </summary>
    [DisplayName("Securities Account Servicer")]
    [IsoXmlTag("SctiesAcctSvcr")]
    public PartyIdentification136? SecuritiesAccountServicer { get; init; } 

    
    #nullable disable
    
}
