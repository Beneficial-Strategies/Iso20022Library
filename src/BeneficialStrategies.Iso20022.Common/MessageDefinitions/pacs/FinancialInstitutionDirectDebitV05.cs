// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.pacs;

/// <inheritdoc cref="IFinancialInstitutionDirectDebitV05"/>
[Description(
    @"Scope:|The FinancialInstitutionDirectDebit message is sent by an exchange or clearing house, or a financial institution, directly or through another agent, to the DebtorAgent. It is used to instruct the DebtorAgent to move funds from one or more debtor(s) account(s) to one or more creditor(s), where both debtor and creditor are financial institutions.||Usage:|The FinancialInstitutionDirectDebit message is exchanged between agents and can contain one or more financial institution direct debit instruction(s) for one or more creditor(s). The FinancialInstitutionDirectDebit message can be used in domestic and cross-border scenarios.|"
)]
[IsoId("_jMaBW9cBEeq_l4BJLVUF2Q")]
[DisplayName("Financial Institution Direct Debit V")]
public partial record FinancialInstitutionDirectDebitV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.010.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIDrctDbt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.010.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="IFinancialInstitutionDirectDebitV05.GroupHeader"/>
    [IsoId("_jMaBY9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader92 GroupHeader { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionDirectDebitV05.CreditInstruction"/>
    [IsoId("_jMaBZdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Credit Instruction")]
    [IsoXmlTag("CdtInstr")]
    public required CreditTransferTransaction53 CreditInstruction { get; init; }

    /// <inheritdoc cref="IFinancialInstitutionDirectDebitV05.SupplementaryData"/>
    [IsoId("_jMaBZ9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
