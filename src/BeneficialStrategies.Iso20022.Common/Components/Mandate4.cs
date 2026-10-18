// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate4"/>
[IsoId("_hAPPcSmeEeKdFJmzhTDOvQ")]
[DisplayName("Mandate")]
public partial record Mandate4
{
    /// <inheritdoc cref="IMandate4.MandateIdentification"/>
    [IsoId("_hv6__SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandate4.MandateRequestIdentification"/>
    [IsoId("_hv7AASmeEeKdFJmzhTDOvQ")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate4.Type"/>
    [IsoId("_hv7ABSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <inheritdoc cref="IMandate4.Occurrences"/>
    [IsoId("_hv7ACSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences2? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate4.CollectionAmount"/>
    [IsoId("_hv7ADSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate4.MaximumAmount"/>
    [IsoId("_hv7AESmeEeKdFJmzhTDOvQ")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate4.CreditorSchemeIdentification"/>
    [IsoId("_hv7AFSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate4.Creditor"/>
    [IsoId("_hv7AGSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IMandate4.CreditorAccount"/>
    [IsoId("_hv7AHSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate4.CreditorAgent"/>
    [IsoId("_hv7AISmeEeKdFJmzhTDOvQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate4.UltimateCreditor"/>
    [IsoId("_hv7AJSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate4.Debtor"/>
    [IsoId("_hv7AKSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IMandate4.DebtorAccount"/>
    [IsoId("_hv7ALSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate4.DebtorAgent"/>
    [IsoId("_hv7AMSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate4.UltimateDebtor"/>
    [IsoId("_hv7ANSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate4.ReferredDocument"/>
    [IsoId("_hv7AOSmeEeKdFJmzhTDOvQ")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ReferredDocumentInformation3? ReferredDocument { get; init; }

    /// <inheritdoc cref="IMandate4.SupplementaryData"/>
    [IsoId("_pSRXECmeEeKdFJmzhTDOvQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
