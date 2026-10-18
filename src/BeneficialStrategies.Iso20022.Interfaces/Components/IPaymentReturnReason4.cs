// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the return of the transaction.
/// </summary>
[IsoId("_nTY3MbTREeeyuKckOGlwuA")]
public interface IPaymentReturnReason4 : IIsoComponent
{
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_ncBOxbTREeeyuKckOGlwuA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification125? Originator { get; }

    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_ncBOx7TREeeyuKckOGlwuA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IReturnReason5Choice? Reason { get; }

    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_ncBOybTREeeyuKckOGlwuA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
