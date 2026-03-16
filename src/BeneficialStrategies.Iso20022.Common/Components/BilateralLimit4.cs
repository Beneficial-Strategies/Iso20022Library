// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Bilateral Limit4.
/// </summary>
[IsoId("_36KFVzEyEe6g-ffJsqGiSA")]
[DisplayName("Bilateral Limit4")]
public partial record BilateralLimit4
{
    #nullable enable

    /// <summary>
    /// Bilateral Balance.
    /// </summary>
    [DisplayName("Bilateral Balance")]
    [IsoXmlTag("BilBal")]
    public ValueList<CashBalance11> BilateralBalance { get; init; } = [];

    /// <summary>
    /// Counterparty Identification.
    /// </summary>
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required BranchAndFinancialInstitutionIdentification8 CounterpartyIdentification { get; init; } 

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 

    /// <summary>
    /// Limit Amount.
    /// </summary>
    [DisplayName("Limit Amount")]
    [IsoXmlTag("LmtAmt")]
    public required Amount2Choice_ LimitAmount { get; init; } 

    
    #nullable disable
    
}
