// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[IsoId("_UdigWNp-Ed-ak6NoX_4Aeg_-2016914974")]
[DisplayName("Transaction Details")]
public record TransactionDetails13
{
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("_UdigWdp-Ed-ak6NoX_4Aeg_220289058")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public required SettlementTypeAndIdentification3 AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_UdigWtp-Ed-ak6NoX_4Aeg_1677903662")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public Identification1? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_UdigW9p-Ed-ak6NoX_4Aeg_-1963394961")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification13Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_UdigXNp-Ed-ak6NoX_4Aeg_2061497646")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount13 SafekeepingAccount { get; init; }

    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_UdigXdp-Ed-ak6NoX_4Aeg_-1936729863")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails10? TransactionDetails { get; init; }
}
