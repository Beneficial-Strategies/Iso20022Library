// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acknowledgement of a completion advice.
/// </summary>
[IsoId("_ny2Sga4NEeWZgJQOa6iKCQ")]
[DisplayName("ATM Transaction")]
public record ATMTransaction18
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_n_Ewoa4NEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Response to the advice.
    /// </summary>
    [IsoId("_n_Ewo64NEeWZgJQOa6iKCQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response4Code Response { get; init; }

    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_n_Ewpa4NEeWZgJQOa6iKCQ")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public ResultDetail4Code? ResponseReason { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_n_Ewp64NEeWZgJQOa6iKCQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_n_Ewqa4NEeWZgJQOa6iKCQ")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand7? Command { get; init; }
}
