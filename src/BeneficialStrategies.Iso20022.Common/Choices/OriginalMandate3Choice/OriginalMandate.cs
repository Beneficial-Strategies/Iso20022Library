// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate3Choice
{
    /// <inheritdoc cref="IOriginalMandate"/>
    [IsoId("_YkloBR77EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public partial record OriginalMandate : OriginalMandate3Choice_
    {
        /// <inheritdoc cref="IOriginalMandate.MandateIdentification"/>
        [IsoId("_Y12XJx77EeSxevWRRWxNAg")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text MandateIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateRequestIdentification"/>
        [IsoId("_Y12XKR77EeSxevWRRWxNAg")]
        [DisplayName("Mandate Request Identification")]
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateRequestIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Type"/>
        [IsoId("_Y12XKx77EeSxevWRRWxNAg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MandateTypeInformation1? Type { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Occurrences"/>
        [IsoId("_Y12XLR77EeSxevWRRWxNAg")]
        [DisplayName("Occurrences")]
        [IsoXmlTag("Ocrncs")]
        public MandateOccurrences3? Occurrences { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CollectionAmount"/>
        [IsoId("_Y12XLx77EeSxevWRRWxNAg")]
        [DisplayName("Collection Amount")]
        [IsoXmlTag("ColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MaximumAmount"/>
        [IsoId("_Y12XMR77EeSxevWRRWxNAg")]
        [DisplayName("Maximum Amount")]
        [IsoXmlTag("MaxAmt")]
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Reason"/>
        [IsoId("_UDQxwyL0EeSizvrwx7oJNQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public MandateSetupReason1Choice_? Reason { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorSchemeIdentification"/>
        [IsoId("_Y12XMx77EeSxevWRRWxNAg")]
        [DisplayName("Creditor Scheme Identification")]
        [IsoXmlTag("CdtrSchmeId")]
        public PartyIdentification43? CreditorSchemeIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Creditor"/>
        [IsoId("_Y12XNR77EeSxevWRRWxNAg")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public required PartyIdentification43 Creditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAccount"/>
        [IsoId("_Y12XNx77EeSxevWRRWxNAg")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount24? CreditorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAgent"/>
        [IsoId("_Y12XOR77EeSxevWRRWxNAg")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateCreditor"/>
        [IsoId("_Y12XOx77EeSxevWRRWxNAg")]
        [DisplayName("Ultimate Creditor")]
        [IsoXmlTag("UltmtCdtr")]
        public PartyIdentification43? UltimateCreditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Debtor"/>
        [IsoId("_Y12XPR77EeSxevWRRWxNAg")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public required PartyIdentification43 Debtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAccount"/>
        [IsoId("_Y12XPx77EeSxevWRRWxNAg")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount24? DebtorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAgent"/>
        [IsoId("_Y12XQR77EeSxevWRRWxNAg")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateDebtor"/>
        [IsoId("_Y12XQx77EeSxevWRRWxNAg")]
        [DisplayName("Ultimate Debtor")]
        [IsoXmlTag("UltmtDbtr")]
        public PartyIdentification43? UltimateDebtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.ReferredDocument"/>
        [IsoId("_Y12XRR77EeSxevWRRWxNAg")]
        [DisplayName("Referred Document")]
        [IsoXmlTag("RfrdDoc")]
        public ReferredDocumentInformation6? ReferredDocument { get; init; }
    }
}
