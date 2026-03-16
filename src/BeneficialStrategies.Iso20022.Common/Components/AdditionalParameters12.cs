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
[IsoId("__hoh0ENHEeGHJ_bHJRPaIQ_1862779948")]
[DisplayName("Additional Parameters")]
public record AdditionalParameters12
{
    /// <summary>
    /// Specifies whether there exists a pre-confirmation.
    /// </summary>
    [IsoId("__hoh0UNHEeGHJ_bHJRPaIQ_1748940882")]
    [DisplayName("Pre Confirmation")]
    [IsoXmlTag("PreConf")]
    public PreConfirmation1Code? PreConfirmation { get; init; }

    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    [IsoId("__hoh0kNHEeGHJ_bHJRPaIQ_751868529")]
    [DisplayName("Partial Settlement")]
    [IsoXmlTag("PrtlSttlm")]
    public PartialSettlement2Code? PartialSettlement { get; init; }

    /// <summary>
    /// Identification of the confirmation previously sent to confirm the partial settlement of a transaction.
    /// </summary>
    [IsoId("__hoh00NHEeGHJ_bHJRPaIQ_-245203824")]
    [DisplayName("Previous Partial Confirmation Identification")]
    [IsoXmlTag("PrvsPrtlConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreviousPartialConfirmationIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the triparty agent&apos;s point of view.
    /// </summary>
    [IsoId("__h8D0ENHEeGHJ_bHJRPaIQ_-1242276177")]
    [DisplayName("Triparty Agent Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("__h8D0UNHEeGHJ_bHJRPaIQ_2055618766")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }
}
