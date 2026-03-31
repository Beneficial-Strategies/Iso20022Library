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
[IsoId("_65XLC_fUEeiNZp_PtLohLw")]
[DisplayName("Intra Position Details")]
public record IntraPositionDetails50
{
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_65XLD_fUEeiNZp_PtLohLw")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? PoolIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_65XLF_fUEeiNZp_PtLohLw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_65XLH_fUEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount30 SafekeepingAccount { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_65XLJ_fUEeiNZp_PtLohLw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_65XLL_fUEeiNZp_PtLohLw")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Number identifying a lot constituting the financial instrument.
    /// </summary>
    [IsoId("_65XLN_fUEeiNZp_PtLohLw")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification39? LotNumber { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    [IsoId("_65XLOffUEeiNZp_PtLohLw")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_65XLQffUEeiNZp_PtLohLw")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_65XLQ_fUEeiNZp_PtLohLw")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public SecuritiesBalanceType11Choice_? BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_65XLS_fUEeiNZp_PtLohLw")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public SecuritiesBalanceType11Choice_? BalanceTo { get; init; }
}
