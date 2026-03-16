// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.003.001.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("__PoMa4S0Ee-Pv9KR9bv9IA")]
[DisplayName("Securities Balance Accounting Report V12")]
public record SecuritiesBalanceAccountingReportV12 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.003.001.12";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalAcctgRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.12";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Account Base Currency Total Amounts.
    /// </summary>
    [DisplayName("Account Base Currency Total Amounts")]
    [IsoXmlTag("AcctBaseCcyTtlAmts")]
    public TotalValueInPageAndStatement2? AccountBaseCurrencyTotalAmounts { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification136? AccountServicer { get; init; }

    /// <summary>
    /// Alternate Reporting Currency Total Amounts.
    /// </summary>
    [DisplayName("Alternate Reporting Currency Total Amounts")]
    [IsoXmlTag("AltrnRptgCcyTtlAmts")]
    public TotalValueInPageAndStatement2? AlternateReportingCurrencyTotalAmounts { get; init; }

    /// <summary>
    /// Balance For Account.
    /// </summary>
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public ValueList<AggregateBalanceInformation45> BalanceForAccount { get; init; } = [];

    /// <summary>
    /// Block Chain Address Or Wallet.
    /// </summary>
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet1? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Intermediary Information.
    /// </summary>
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary44? IntermediaryInformation { get; init; }

    /// <summary>
    /// Pagination.
    /// </summary>
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount26? SafekeepingAccount { get; init; }

    /// <summary>
    /// Statement General Details.
    /// </summary>
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement74 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Sub Account Details.
    /// </summary>
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public ValueList<SubAccountIdentification72> SubAccountDetails { get; init; } = [];
}

// Since SecuritiesBalanceAccountingReportV12Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesBalanceAccountingReportV12.
