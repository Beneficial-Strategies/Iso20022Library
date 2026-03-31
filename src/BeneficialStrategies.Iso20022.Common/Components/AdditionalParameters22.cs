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
[IsoId("_FdHjATtPEeWRTLSN0i0tng")]
[DisplayName("Additional Parameters")]
public record AdditionalParameters22
{
    /// <summary>
    /// Specifies whether there exists a pre-confirmation.
    /// </summary>
    [IsoId("_F9tHkTtPEeWRTLSN0i0tng")]
    [DisplayName("Pre Confirmation")]
    [IsoXmlTag("PreConf")]
    public PreConfirmation1Code? PreConfirmation { get; init; }

    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    [IsoId("_F9tHmTtPEeWRTLSN0i0tng")]
    [DisplayName("Partial Settlement")]
    [IsoXmlTag("PrtlSttlm")]
    public PartialSettlement2Code? PartialSettlement { get; init; }

    /// <summary>
    /// Identification of the confirmation previously sent to confirm the partial settlement of a transaction.
    /// </summary>
    [IsoId("_F9tHoTtPEeWRTLSN0i0tng")]
    [DisplayName("Previous Partial Confirmation Identification")]
    [IsoXmlTag("PrvsPrtlConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreviousPartialConfirmationIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the triparty agent&apos;s point of view.
    /// </summary>
    [IsoId("_F9tHqTtPEeWRTLSN0i0tng")]
    [DisplayName("Triparty Agent Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("_F9tHsTtPEeWRTLSN0i0tng")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [IsoId("_F9tHuTtPEeWRTLSN0i0tng")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the triparty agent.
    /// </summary>
    [IsoId("_F9tHuztPEeWRTLSN0i0tng")]
    [DisplayName("Triparty Collateral Instruction Identification")]
    [IsoXmlTag("TrptyCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyCollateralInstructionIdentification { get; init; }
}
