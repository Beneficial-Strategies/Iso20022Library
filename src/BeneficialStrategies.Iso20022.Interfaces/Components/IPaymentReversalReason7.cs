// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the reversal of the transaction.
/// </summary>
[IsoId("_t3aEIVkyEeGeoaLUQk__nA_20263708")]
public interface IPaymentReversalReason7 : IIsoComponent
{
    /// <summary>
    /// Party that issues the reversal.
    /// </summary>
    [IsoId("_t3aEIlkyEeGeoaLUQk__nA_1241275489")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification43? Originator { get; }

    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_t3aEI1kyEeGeoaLUQk__nA_-1778414709")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IReversalReason4Choice? Reason { get; }

    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_t3aEJFkyEeGeoaLUQk__nA_-878513043")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<Max105Text> AdditionalInformation { get; }
}
