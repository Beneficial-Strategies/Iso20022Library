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
[IsoId("_4CLSkeSlEe-qVZLXW4RRBw")]
[DisplayName("Intra Position Query Criteria8")]
public record IntraPositionQueryCriteria8
{
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_4KLYAeSlEe-qVZLXW4RRBw")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<References82Choice> References { get; init; } = [];

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_4KLYCeSlEe-qVZLXW4RRBw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public IntraPositionQueryStatus3? Status { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_4KLYC-SlEe-qVZLXW4RRBw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<SecurityIdentification19> FinancialInstrumentIdentification { get; init; } = [];

    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_4KLYE-SlEe-qVZLXW4RRBw")]
    [DisplayName("Safekeeping Account Owner")]
    [IsoXmlTag("SfkpgAcctOwnr")]
    public ValueList<SystemPartyIdentification8> SafekeepingAccountOwner { get; init; } = [];

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_4KLYFeSlEe-qVZLXW4RRBw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public ValueList<SecuritiesAccount19> SafekeepingAccount { get; init; } = [];

    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_4KLYF-SlEe-qVZLXW4RRBw")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public ValueList<IntraPositionType2> BalanceType { get; init; } = [];

    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_4KLYH-SlEe-qVZLXW4RRBw")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public ValueList<GenericIdentification37> SecuritiesSubBalanceIdentification { get; init; } = [];

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_4KLYIeSlEe-qVZLXW4RRBw")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public QuantitySearch2Choice? SettlementQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_4KLYKeSlEe-qVZLXW4RRBw")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public QuantitySearch2Choice? SettledQuantity { get; init; }

    /// <summary>
    /// Date and time at which the securities are intended to be moved.
    /// </summary>
    [IsoId("_4KLYMeSlEe-qVZLXW4RRBw")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public DateAndDateTimeSearch5Choice? IntendedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are moved.
    /// </summary>
    [IsoId("_4KLYOeSlEe-qVZLXW4RRBw")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTimeSearch5Choice? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_4KLYQeSlEe-qVZLXW4RRBw")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public ValueList<PriorityNumeric4Choice> Priority { get; init; } = [];

    /// <summary>
    /// Primary market or country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_4KLYSeSlEe-qVZLXW4RRBw")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public SimpleValueList<CountryCode> CountryOfIssue { get; init; } = [];

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_4KLYUeSlEe-qVZLXW4RRBw")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public ValueList<SystemPartyIdentification8> MessageOriginator { get; init; } = [];

    /// <summary>
    /// Specifies the creation date/time of the intra-position movement.
    /// </summary>
    [IsoId("_4KLYU-SlEe-qVZLXW4RRBw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeSearch5Choice? CreationDateTime { get; init; }
}
