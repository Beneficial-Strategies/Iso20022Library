// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria based on which information is included.
/// </summary>
[IsoId("_VUPx9Tp9EemwKdP955WBJQ")]
[DisplayName("Intra Balance Query Criteria")]
public record IntraBalanceQueryCriteria9
{
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Ve-bQTp9EemwKdP955WBJQ")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public References36Choice_? References { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_Ve-bSTp9EemwKdP955WBJQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public IntraBalanceQueryStatus3? Status { get; init; }

    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_Ve-bTTp9EemwKdP955WBJQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public AccountIdentificationSearchCriteria2Choice_? CashAccount { get; init; }

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_Ve-bSzp9EemwKdP955WBJQ")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }

    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_08RvoTp9EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; }

    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_Ve-bTzp9EemwKdP955WBJQ")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public IntraBalanceType3? BalanceType { get; init; }

    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_Ve-bVzp9EemwKdP955WBJQ")]
    [DisplayName("Cash Sub Balance Identification")]
    [IsoXmlTag("CshSubBalId")]
    public GenericIdentification37? CashSubBalanceIdentification { get; init; }

    /// <summary>
    /// Total amount of money to be settled.
    /// </summary>
    [IsoId("_Ve-bWTp9EemwKdP955WBJQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ImpliedCurrencyAmountRange1Choice_? SettlementAmount { get; init; }

    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_Ve-bYTp9EemwKdP955WBJQ")]
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public ImpliedCurrencyAmountRange1Choice_? SettledAmount { get; init; }

    /// <summary>
    /// Currency in which the instructed amount is expressed.
    /// </summary>
    [IsoId("_Ve-baTp9EemwKdP955WBJQ")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveOrHistoricCurrencyCode? SettlementCurrency { get; init; }

    /// <summary>
    /// Date and time at which the amount of money is intended to be moved.
    /// </summary>
    [IsoId("_Ve-bazp9EemwKdP955WBJQ")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public DateAndDateTimeSearch5Choice_? IntendedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the amount of money is moved.
    /// </summary>
    [IsoId("_Ve-bczp9EemwKdP955WBJQ")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTimeSearch5Choice_? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_Ve-bezp9EemwKdP955WBJQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_Ve-bgzp9EemwKdP955WBJQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public SystemPartyIdentification8? MessageOriginator { get; init; }

    /// <summary>
    /// Specifies the creation date/time of the intra-balance movement.
    /// </summary>
    [IsoId("_Ve-bhTp9EemwKdP955WBJQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeSearch5Choice_? CreationDateTime { get; init; }
}
