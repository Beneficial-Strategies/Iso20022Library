// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the reversal of the transaction.
/// </summary>
[IsoId("_YEpCuW49EeiU9cctagi5ow")]
public interface IPaymentReversalReason9 : IIsoComponent
{
    /// <summary>
    /// Party that issues the reversal.
    /// </summary>
    [IsoId("_YNljQ249EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification135? Originator { get; }

    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_YNljRW49EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IReversalReason4Choice? Reason { get; }

    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_YNljR249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<Max105Text> AdditionalInformation { get; }
}
