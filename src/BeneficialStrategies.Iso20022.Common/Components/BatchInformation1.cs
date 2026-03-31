// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying batches.
/// </summary>
[IsoId("_RUE1CNp-Ed-ak6NoX_4Aeg_408833196")]
[DisplayName("Batch Information")]
public record BatchInformation1
{
    /// <summary>
    /// Point to point reference assigned by the sending party to unambiguously identify the batch of transactions.
    /// </summary>
    [IsoId("_RUOmANp-Ed-ak6NoX_4Aeg_1422452073")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// Reference assigned by a sending party to unambiguously identify a payment information block within a payment message.
    /// </summary>
    [IsoId("_RUOmAdp-Ed-ak6NoX_4Aeg_1307010927")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Number of individual transactions included in the batch.
    /// </summary>
    [IsoId("_RUOmAtp-Ed-ak6NoX_4Aeg_1792782508")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }
}
