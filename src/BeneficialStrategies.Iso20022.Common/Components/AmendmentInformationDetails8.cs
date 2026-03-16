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
[IsoId("_teX5FFkyEeGeoaLUQk__nA_528536611")]
[DisplayName("Amendment Information Details")]
public record AmendmentInformationDetails8
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    [IsoId("_tehqEFkyEeGeoaLUQk__nA_670667391")]
    [DisplayName("Original Mandate Identification")]
    [IsoXmlTag("OrgnlMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMandateIdentification { get; init; }

    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    [IsoId("_tehqEVkyEeGeoaLUQk__nA_1004495065")]
    [DisplayName("Original Creditor Scheme Identification")]
    [IsoXmlTag("OrgnlCdtrSchmeId")]
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    [IsoId("_tehqElkyEeGeoaLUQk__nA_-488026944")]
    [DisplayName("Original Creditor Agent")]
    [IsoXmlTag("OrgnlCdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; }

    /// <summary>
    /// Original creditor agent account that has been modified.
    /// </summary>
    [IsoId("_tehqE1kyEeGeoaLUQk__nA_-499125721")]
    [DisplayName("Original Creditor Agent Account")]
    [IsoXmlTag("OrgnlCdtrAgtAcct")]
    public CashAccount24? OriginalCreditorAgentAccount { get; init; }

    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    [IsoId("_tehqFFkyEeGeoaLUQk__nA_-174008214")]
    [DisplayName("Original Debtor")]
    [IsoXmlTag("OrgnlDbtr")]
    public PartyIdentification43? OriginalDebtor { get; init; }

    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    [IsoId("_teq0AFkyEeGeoaLUQk__nA_1785884717")]
    [DisplayName("Original Debtor Account")]
    [IsoXmlTag("OrgnlDbtrAcct")]
    public CashAccount24? OriginalDebtorAccount { get; init; }

    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    [IsoId("_teq0AVkyEeGeoaLUQk__nA_2024930314")]
    [DisplayName("Original Debtor Agent")]
    [IsoXmlTag("OrgnlDbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; }

    /// <summary>
    /// Original debtor agent account that has been modified.
    /// </summary>
    [IsoId("_teq0AlkyEeGeoaLUQk__nA_2013831537")]
    [DisplayName("Original Debtor Agent Account")]
    [IsoXmlTag("OrgnlDbtrAgtAcct")]
    public CashAccount24? OriginalDebtorAgentAccount { get; init; }

    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    [IsoId("_teq0A1kyEeGeoaLUQk__nA_-2076799323")]
    [DisplayName("Original Final Collection Date")]
    [IsoXmlTag("OrgnlFnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalFinalCollectionDate { get; init; }

    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    [IsoId("_teq0BFkyEeGeoaLUQk__nA_-1622712054")]
    [DisplayName("Original Frequency")]
    [IsoXmlTag("OrgnlFrqcy")]
    public Frequency6Code? OriginalFrequency { get; init; }
}
