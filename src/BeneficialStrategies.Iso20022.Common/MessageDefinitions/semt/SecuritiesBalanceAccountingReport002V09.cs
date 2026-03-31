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
/// This record is an implementation of the semt.003.002.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesBalanceAccountingReport to an account owner to provide, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.
/// The account servicer/owner relationship may be:
/// - an accounting agent acting on behalf of an account owner, or
/// - a transfer agent acting on behalf of a fund manager or an account owner&apos;s designated agent.
///
/// Usage
/// The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner.
/// The message can be sent either audited or un-audited and may be provided on a trade date, contractual or settlement date basis.
/// This message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, the message can be used to either specify holdings at
/// - the main account level, or,
/// - the sub-account level.
/// This message can be used to report where the financial instruments are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.
/// The SecuritiesBalanceAccountingReport message should not be used for trading purposes.
/// There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope |An account servicer sends a SecuritiesBalanceAccountingReport to an account owner to provide, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.|The account servicer/owner relationship may be:|- an accounting agent acting on behalf of an account owner, or|- a transfer agent acting on behalf of a fund manager or an account owner's designated agent.||Usage|The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner.|The message can be sent either audited or un-audited and may be provided on a trade date, contractual or settlement date basis. |This message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, the message can be used to either specify holdings at|- the main account level, or, |- the sub-account level.|This message can be used to report where the financial instruments are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated. |The SecuritiesBalanceAccountingReport message should not be used for trading purposes.|There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_5WxS45NLEeWGlc8L7oPDIg")]
[DisplayName("Securities Balance Accounting Report 002 V")]
public record SecuritiesBalanceAccountingReport002V09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.003.002.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalAcctgRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.002.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_5WxS7ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination Pagination { get; init; }

    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_5WxS75NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement51 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_5WxS8ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification109? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_5WxS85NLEeWGlc8L7oPDIg")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification111? AccountServicer { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_5WxS9ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount33 SafekeepingAccount { get; init; }

    /// <summary>
    /// Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_5WxS95NLEeWGlc8L7oPDIg")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary37> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_5WxS-ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateBalanceInformation32? BalanceForAccount { get; init; }

    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_5WxS-5NLEeWGlc8L7oPDIg")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification45? SubAccountDetails { get; init; }

    /// <summary>
    /// Total valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_5WxS_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Account Base Currency Total Amounts")]
    [IsoXmlTag("AcctBaseCcyTtlAmts")]
    public TotalValueInPageAndStatement4? AccountBaseCurrencyTotalAmounts { get; init; }

    /// <summary>
    /// Total valuation amounts provided in another currency than the base currency of the account.
    /// </summary>
    [IsoId("_5WxS_5NLEeWGlc8L7oPDIg")]
    [DisplayName("Alternate Reporting Currency Total Amounts")]
    [IsoXmlTag("AltrnRptgCcyTtlAmts")]
    public TotalValueInPageAndStatement4? AlternateReportingCurrencyTotalAmounts { get; init; }
}

// Since SecuritiesBalanceAccountingReport002V09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesBalanceAccountingReport002V09.
