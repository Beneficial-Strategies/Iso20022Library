// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate4Choice
{
    /// <inheritdoc cref="IOriginalMandate"/>
    [IsoId("_c4CjZUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public partial record OriginalMandate : OriginalMandate4Choice_
    {
        /// <inheritdoc cref="IOriginalMandate.MandateIdentification"/>
        [IsoId("_dBASJ0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text MandateIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateRequestIdentification"/>
        [IsoId("_dBASKUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Mandate Request Identification")]
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateRequestIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Authentication"/>
        [IsoId("_jArg0WoGEearR-CA7eRZXQ")]
        [DisplayName("Authentication")]
        [IsoXmlTag("Authntcn")]
        public MandateAuthentication1? Authentication { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Type"/>
        [IsoId("_dBASK0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MandateTypeInformation2? Type { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Occurrences"/>
        [IsoId("_dBASLUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Occurrences")]
        [IsoXmlTag("Ocrncs")]
        public MandateOccurrences4? Occurrences { get; init; }

        /// <inheritdoc cref="IOriginalMandate.TrackingIndicator"/>
        [IsoId("_Zx4UIGn0EearR-CA7eRZXQ")]
        [DisplayName("Tracking Indicator")]
        [IsoXmlTag("TrckgInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

        /// <inheritdoc cref="IOriginalMandate.FirstCollectionAmount"/>
        [IsoId("_eWoD8WnvEearR-CA7eRZXQ")]
        [DisplayName("First Collection Amount")]
        [IsoXmlTag("FrstColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CollectionAmount"/>
        [IsoId("_dBASL0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Collection Amount")]
        [IsoXmlTag("ColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MaximumAmount"/>
        [IsoId("_dBASMUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Maximum Amount")]
        [IsoXmlTag("MaxAmt")]
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Adjustment"/>
        [IsoId("_JHq7cWoGEearR-CA7eRZXQ")]
        [DisplayName("Adjustment")]
        [IsoXmlTag("Adjstmnt")]
        public MandateAdjustment1? Adjustment { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Reason"/>
        [IsoId("_dBASM0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public MandateSetupReason1Choice_? Reason { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorSchemeIdentification"/>
        [IsoId("_dBASNUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Creditor Scheme Identification")]
        [IsoXmlTag("CdtrSchmeId")]
        public PartyIdentification43? CreditorSchemeIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Creditor"/>
        [IsoId("_dBASN0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public required PartyIdentification43 Creditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAccount"/>
        [IsoId("_dBASOUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount24? CreditorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAgent"/>
        [IsoId("_dBASO0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateCreditor"/>
        [IsoId("_dBASPUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Ultimate Creditor")]
        [IsoXmlTag("UltmtCdtr")]
        public PartyIdentification43? UltimateCreditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Debtor"/>
        [IsoId("_dBASP0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public required PartyIdentification43 Debtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAccount"/>
        [IsoId("_dBASQUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount24? DebtorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAgent"/>
        [IsoId("_dBASQ0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateDebtor"/>
        [IsoId("_dBASRUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Ultimate Debtor")]
        [IsoXmlTag("UltmtDbtr")]
        public PartyIdentification43? UltimateDebtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateReference"/>
        [IsoId("_OHvTIGnyEearR-CA7eRZXQ")]
        [DisplayName("Mandate Reference")]
        [IsoXmlTag("MndtRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateReference { get; init; }

        /// <inheritdoc cref="IOriginalMandate.ReferredDocument"/>
        [IsoId("_dBASR0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Referred Document")]
        [IsoXmlTag("RfrdDoc")]
        public ReferredMandateDocument1? ReferredDocument { get; init; }
    }
}
