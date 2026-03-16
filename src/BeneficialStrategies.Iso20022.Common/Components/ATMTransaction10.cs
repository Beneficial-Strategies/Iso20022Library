// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to the PIN management transaction. request.
/// </summary>
[IsoId("_VdrcoYrDEeSgLpgNvMAP2g")]
[DisplayName("ATM Transaction")]
public record ATMTransaction10
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_VqDEsYrDEeSgLpgNvMAP2g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_VqDEs4rDEeSgLpgNvMAP2g")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// True if a completion advice has to be sent after the end of the transaction.
    /// </summary>
    [IsoId("_VqDEtYrDEeSgLpgNvMAP2g")]
    [DisplayName("Completion Required")]
    [IsoXmlTag("CmpltnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CompletionRequired { get; init; }

    /// <summary>
    /// Result of the PIN service.
    /// </summary>
    [IsoId("_7YUA0IrDEeSgLpgNvMAP2g")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType3 TransactionResponse { get; init; }

    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("_FmVUAIrEEeSgLpgNvMAP2g")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action5? Action { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_VqDEx4rDEeSgLpgNvMAP2g")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_VqDEyYrDEeSgLpgNvMAP2g")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand1? Command { get; init; }
}
