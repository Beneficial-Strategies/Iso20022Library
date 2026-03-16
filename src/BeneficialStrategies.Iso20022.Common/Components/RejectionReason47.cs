// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reasons of rejecting transactions.
/// </summary>
[IsoId("_j8wpua4cEemB_csI4yyKLA")]
[DisplayName("Rejection Reason")]
public record RejectionReason47
{
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_kBO6Aa4cEemB_csI4yyKLA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification1Choice_ TransactionIdentification { get; init; }

    /// <summary>
    /// Information on status of submitted transactions.
    /// </summary>
    [IsoId("_kBO6A64cEemB_csI4yyKLA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ReportingMessageStatus1Code Status { get; init; }

    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [IsoId("_kBO6Ba4cEemB_csI4yyKLA")]
    [DisplayName("Detailed Validation Rule")]
    [IsoXmlTag("DtldVldtnRule")]
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; init; }
}
