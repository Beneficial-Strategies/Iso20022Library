// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
[IsoId("_te0lAFkyEeGeoaLUQk__nA_-1080741410")]
[DisplayName("Amendment Information Details")]
public record AmendmentInformationDetails9
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_te0lAVkyEeGeoaLUQk__nA_-786752122")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_te0lAlkyEeGeoaLUQk__nA_-1987316393")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_te0lA1kyEeGeoaLUQk__nA_-1998415170")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_te9u8FkyEeGeoaLUQk__nA_-584178548")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification43? OriginalDebtor { get; init; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_te9u8VkyEeGeoaLUQk__nA_-552379473")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_te9u8lkyEeGeoaLUQk__nA_-1694300912")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_te9u81kyEeGeoaLUQk__nA_-197353443")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_te9u9FkyEeGeoaLUQk__nA_-1269358502")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency6Code? OriginalFrequency { get; init; }
}
