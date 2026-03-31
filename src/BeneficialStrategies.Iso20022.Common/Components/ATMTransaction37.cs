// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction37.
/// </summary>
[IsoId("_afiPEaCAEe-mUP79iiSLcw")]
[DisplayName("ATM Transaction37")]
public record ATMTransaction37
{
    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action7> Action { get; init; } = [];

    /// <summary>
    /// Command.
    /// </summary>
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];

    /// <summary>
    /// Completion Required.
    /// </summary>
    [DisplayName("Completion Required")]
    [IsoXmlTag("CmpltnReqrd")]
    public IsoTrueFalseIndicator? CompletionRequired { get; init; }

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier3 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Response.
    /// </summary>
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType12 TransactionResponse { get; init; }
}
