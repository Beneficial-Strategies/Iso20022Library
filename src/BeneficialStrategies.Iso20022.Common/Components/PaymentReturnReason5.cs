// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the return of the transaction.
/// </summary>
[IsoId("_-mplh248EeiU9cctagi5ow")]
[DisplayName("Payment Return Reason")]
public record PaymentReturnReason5
{
    /// <summary>
    /// Bank transaction code included in the original entry for the transaction.
    /// </summary>
    [IsoId("_-v4Z1W48EeiU9cctagi5ow")]
    [DisplayName("Original Bank Transaction Code")]
    [IsoXmlTag("OrgnlBkTxCd")]
    public BankTransactionCodeStructure4? OriginalBankTransactionCode { get; init; }

    /// <summary>
    /// Party that issues the return.
    /// </summary>
    [IsoId("_-v4Z1248EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_-v4Z2W48EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_-v4Z2248EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
