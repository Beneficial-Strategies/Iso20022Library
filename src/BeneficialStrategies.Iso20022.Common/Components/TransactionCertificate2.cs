// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate in which all currency control transactions are registered.
/// </summary>
[IsoId("_Oo0tENLiEeSdq5yU2aaSNw")]
[DisplayName("Transaction Certificate")]
public record TransactionCertificate2
{
    /// <summary>
    /// Reference of the transaction, that is the underlying payment instruction or statement entry.
    /// </summary>
    [IsoId("_TOVNsNLkEeSDLevdaFPXHw")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public required CertificateReference1 ReferredDocument { get; init; }

    /// <summary>
    /// Date of the underlying transaction.
    /// </summary>
    [IsoId("_WmWSYNLkEeSDLevdaFPXHw")]
    [DisplayName("Transaction Date")]
    [IsoXmlTag("TxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TransactionDate { get; init; }

    /// <summary>
    /// Type of the transaction.
    /// </summary>
    [IsoId("_h6KTgNLlEeSDLevdaFPXHw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public required IsoExact1NumericText TransactionType { get; init; }

    /// <summary>
    /// User community specific instrument.
    /// Usage: This element is used to specify a local transaction type to further qualify the transaction type.
    /// </summary>
    [IsoId("_klsssNLlEeSDLevdaFPXHw")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    [IsoSimpleType(IsoSimpleType.Exact5NumericText)]
    public required IsoExact5NumericText LocalInstrument { get; init; }

    /// <summary>
    /// Amount as provided in the transaction to be recorded under the contract.
    /// </summary>
    [IsoId("_nawOQNLlEeSDLevdaFPXHw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
