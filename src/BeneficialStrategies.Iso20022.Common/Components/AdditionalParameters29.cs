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
[IsoId("_dlrxkY7CEeaa5_S8lsRKCQ")]
[DisplayName("Additional Parameters")]
public record AdditionalParameters29
{
    /// <summary>
    /// Specifies whether there exists a pre-confirmation.
    /// </summary>
    [IsoId("_d0iF447CEeaa5_S8lsRKCQ")]
    [DisplayName("Pre Confirmation")]
    [IsoXmlTag("PreConf")]
    public PreConfirmation1Code? PreConfirmation { get; init; }

    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    [IsoId("_d0is947CEeaa5_S8lsRKCQ")]
    [DisplayName("Partial Settlement")]
    [IsoXmlTag("PrtlSttlm")]
    public PartialSettlement2Code? PartialSettlement { get; init; }

    /// <summary>
    /// Identification of the confirmation previously sent to confirm the partial settlement of a transaction.
    /// </summary>
    [IsoId("_d0is_47CEeaa5_S8lsRKCQ")]
    [DisplayName("Previous Partial Confirmation Identification")]
    [IsoXmlTag("PrvsPrtlConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreviousPartialConfirmationIdentification { get; init; }

    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent&apos;s/service-provider&apos;s point of view.
    /// </summary>
    [IsoId("_d0itB47CEeaa5_S8lsRKCQ")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("_d0itD47CEeaa5_S8lsRKCQ")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [IsoId("_d0itF47CEeaa5_S8lsRKCQ")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    [IsoId("_d0itGY7CEeaa5_S8lsRKCQ")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }
}
