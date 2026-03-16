// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the list of criteria to be returned in the contract registration statement.
/// </summary>
[IsoId("_ZgWEUOFIEeStTblywAGIyA")]
[DisplayName("Contract Registration Statement Criteria")]
public record ContractRegistrationStatementCriteria1
{
    /// <summary>
    /// Indicates whether the journal of the transactions recorded under the registered currency control contract must be returned or not.
    /// </summary>
    [IsoId("_0pv6lOFIEeStTblywAGIyA")]
    [DisplayName("Transaction Journal")]
    [IsoXmlTag("TxJrnl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TransactionJournal { get; init; }

    /// <summary>
    /// Indicates whether the journal of the supporting documents recorded under the registered currency control contract must be returned or not.
    /// </summary>
    [IsoId("_0pv6leFIEeStTblywAGIyA")]
    [DisplayName("Supporting Document Journal")]
    [IsoXmlTag("SpprtgDocJrnl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SupportingDocumentJournal { get; init; }

    /// <summary>
    /// Indicates whether the journal of additional supporting documents recorded under the registered currency control contract must be returned or not.
    /// </summary>
    [IsoId("_0pv6luFIEeStTblywAGIyA")]
    [DisplayName("Additional Supporting Document Journal")]
    [IsoXmlTag("AddtlSpprtgDocJrnl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AdditionalSupportingDocumentJournal { get; init; }

    /// <summary>
    /// Indicates whether the details on the currency control rule against which has been violated must be returned or not.
    /// </summary>
    [IsoId("_0pv6l-FIEeStTblywAGIyA")]
    [DisplayName("Regulatory Rule Validation")]
    [IsoXmlTag("RgltryRuleVldtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RegulatoryRuleValidation { get; init; }
}
