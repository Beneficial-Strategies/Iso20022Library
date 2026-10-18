// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the return of the transaction.
/// </summary>
[IsoId("_TQDZg9p-Ed-ak6NoX_4Aeg_-415808124")]
public interface IReturnReasonInformation9 : IIsoComponent
{
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_TQDZhNp-Ed-ak6NoX_4Aeg_-415807751")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    IPartyIdentification32? Originator { get; }

    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_TQDZhdp-Ed-ak6NoX_4Aeg_-415807661")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IReturnReason5Choice? Reason { get; }

    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_TQDZhtp-Ed-ak6NoX_4Aeg_-415808122")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IEnumerable<IsoMax105Text> AdditionalInformation { get; }
}
