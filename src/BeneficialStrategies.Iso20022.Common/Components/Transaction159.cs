// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction159.
/// </summary>
[IsoId("_11F2NTEyEe6g-ffJsqGiSA")]
[DisplayName("Transaction159")]
public partial record Transaction159
{
    #nullable enable

    /// <summary>
    /// Account Entry.
    /// </summary>
    [DisplayName("Account Entry")]
    [IsoXmlTag("AcctNtry")]
    public CashAccountAndEntry5? AccountEntry { get; init; } 

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 

    /// <summary>
    /// Payment.
    /// </summary>
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public PaymentInstruction47? Payment { get; init; } 

    /// <summary>
    /// Payment From.
    /// </summary>
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public System3? PaymentFrom { get; init; } 

    /// <summary>
    /// Payment To.
    /// </summary>
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public System3? PaymentTo { get; init; } 

    /// <summary>
    /// Securities Transaction References.
    /// </summary>
    [DisplayName("Securities Transaction References")]
    [IsoXmlTag("SctiesTxRefs")]
    public SecuritiesTransactionReferences1? SecuritiesTransactionReferences { get; init; } 

    
    #nullable disable
    
}
