// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Short Payment Identification4.
/// </summary>
[IsoId("_2C1-ZTEyEe6g-ffJsqGiSA")]
[DisplayName("Short Payment Identification4")]
public record ShortPaymentIdentification4
{
    /// <summary>
    /// Instructing Agent.
    /// </summary>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public required BranchAndFinancialInstitutionIdentification8 InstructingAgent { get; init; }

    /// <summary>
    /// Interbank Settlement Date.
    /// </summary>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public required ISODate InterbankSettlementDate { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public Max35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// UETR.
    /// </summary>
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public UUIDv4Identifier? UETR { get; init; }
}
