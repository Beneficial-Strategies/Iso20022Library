// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional parameters to the message or transaction.
/// </summary>
[IsoId("_Ujy5Vdp-Ed-ak6NoX_4Aeg_-1300321981")]
[DisplayName("Additional Parameters")]
public record AdditionalParameters3
{
    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    [IsoId("_Ujy5Vtp-Ed-ak6NoX_4Aeg_1883733896")]
    [DisplayName("Partial Settlement")]
    [IsoXmlTag("PrtlSttlm")]
    public PartialSettlement1Code? PartialSettlement { get; init; }

    /// <summary>
    /// Identification of the confirmation previously sent to confirm the partial settlement of a transaction.
    /// </summary>
    [IsoId("_Ujy5V9p-Ed-ak6NoX_4Aeg_886661543")]
    [DisplayName("Previous Partial Confirmation Identification")]
    [IsoXmlTag("PrvsPrtlConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreviousPartialConfirmationIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_Ujy5WNp-Ed-ak6NoX_4Aeg_-244393332")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_Ujy5Wdp-Ed-ak6NoX_4Aeg_-1241465685")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Ujy5Wtp-Ed-ak6NoX_4Aeg_-1865816851")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_Ujy5W9p-Ed-ak6NoX_4Aeg_-2104555516")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_Uj8qUNp-Ed-ak6NoX_4Aeg_2056429258")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }
}
