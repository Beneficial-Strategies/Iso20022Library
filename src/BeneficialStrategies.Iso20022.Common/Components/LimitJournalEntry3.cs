// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Journal Entry3.
/// </summary>
[IsoId("_tr-04ZEhEe-Goq1fIU72qA")]
[DisplayName("Limit Journal Entry3")]
public partial record LimitJournalEntry3
{
    #nullable enable

    /// <summary>
    /// Account Servicer Reference.
    /// </summary>
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    public IsoMax35Text? AccountServicerReference { get; init; } 

    /// <summary>
    /// Additional Entry Information.
    /// </summary>
    [DisplayName("Additional Entry Information")]
    [IsoXmlTag("AddtlNtryInf")]
    public IsoMax500Text? AdditionalEntryInformation { get; init; } 

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2Choice_ Amount { get; init; } 

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 

    /// <summary>
    /// Journal Date.
    /// </summary>
    [DisplayName("Journal Date")]
    [IsoXmlTag("JrnlDt")]
    public required DateAndDateTime2Choice_ JournalDate { get; init; } 

    /// <summary>
    /// Market Infrastructure Transaction Identification.
    /// </summary>
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 

    /// <summary>
    /// Processor Transaction Identification.
    /// </summary>
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public IsoMax35Text? TransactionIdentification { get; init; } 

    
    #nullable disable
    
}
