// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_s8mYYewSEeiazoAmcoGsBQ")]
[DisplayName("Intra Position Details")]
public record IntraPositionDetails49
{
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_tPWVQ-wSEeiazoAmcoGsBQ")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_tPWVS-wSEeiazoAmcoGsBQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification127Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_tPWVU-wSEeiazoAmcoGsBQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_tPWVW-wSEeiazoAmcoGsBQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_tPWVY-wSEeiazoAmcoGsBQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Number identifying a lot constituting the financial instrument.
    /// </summary>
    [IsoId("_tPWVa-wSEeiazoAmcoGsBQ")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification37? LotNumber { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    [IsoId("_tPWVbewSEeiazoAmcoGsBQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_tPWVdewSEeiazoAmcoGsBQ")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_tPWVd-wSEeiazoAmcoGsBQ")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public SecuritiesBalanceType7Choice_? BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_tPWVf-wSEeiazoAmcoGsBQ")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public SecuritiesBalanceType7Choice_? BalanceTo { get; init; }
}
