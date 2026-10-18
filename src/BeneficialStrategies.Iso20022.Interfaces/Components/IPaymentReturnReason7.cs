// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the return of the transaction.
/// </summary>
[IsoId("_wrllwTEyEe6g-ffJsqGiSA")]
public interface IPaymentReturnReason7 : IIsoComponent
{
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }

    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification272? Originator { get; }

    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IReturnReason5Choice? Reason { get; }
}
