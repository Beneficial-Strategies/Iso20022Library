// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate8Choice
{
    /// <inheritdoc cref="IOriginalMandate"/>
    [IsoId("_bQuQE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public partial record OriginalMandate : OriginalMandate8Choice_
    {
        /// <inheritdoc cref="IOriginalMandate.MandateIdentification"/>
        [IsoId("_bSCetdcZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateRequestIdentification"/>
        [IsoId("_bSCet9cZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Request Identification")]
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateRequestIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Authentication"/>
        [IsoId("_bSCeudcZEeqRFcf2R4bPBw")]
        [DisplayName("Authentication")]
        [IsoXmlTag("Authntcn")]
        public MandateAuthentication1? Authentication { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Type"/>
        [IsoId("_bSCeu9cZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MandateTypeInformation2? Type { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Occurrences"/>
        [IsoId("_bSCevdcZEeqRFcf2R4bPBw")]
        [DisplayName("Occurrences")]
        [IsoXmlTag("Ocrncs")]
        public MandateOccurrences5? Occurrences { get; init; }

        /// <inheritdoc cref="IOriginalMandate.TrackingIndicator"/>
        [IsoId("_bSCev9cZEeqRFcf2R4bPBw")]
        [DisplayName("Tracking Indicator")]
        [IsoXmlTag("TrckgInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

        /// <inheritdoc cref="IOriginalMandate.FirstCollectionAmount"/>
        [IsoId("_bSCewdcZEeqRFcf2R4bPBw")]
        [DisplayName("First Collection Amount")]
        [IsoXmlTag("FrstColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CollectionAmount"/>
        [IsoId("_bSCew9cZEeqRFcf2R4bPBw")]
        [DisplayName("Collection Amount")]
        [IsoXmlTag("ColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MaximumAmount"/>
        [IsoId("_bSCexdcZEeqRFcf2R4bPBw")]
        [DisplayName("Maximum Amount")]
        [IsoXmlTag("MaxAmt")]
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Adjustment"/>
        [IsoId("_bSCex9cZEeqRFcf2R4bPBw")]
        [DisplayName("Adjustment")]
        [IsoXmlTag("Adjstmnt")]
        public MandateAdjustment1? Adjustment { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Reason"/>
        [IsoId("_bSCeydcZEeqRFcf2R4bPBw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public MandateSetupReason1Choice_? Reason { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorSchemeIdentification"/>
        [IsoId("_bSCey9cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Scheme Identification")]
        [IsoXmlTag("CdtrSchmeId")]
        public PartyIdentification135? CreditorSchemeIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Creditor"/>
        [IsoId("_bSCezdcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public required PartyIdentification135 Creditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAccount"/>
        [IsoId("_bSCez9cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount40? CreditorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAgent"/>
        [IsoId("_bSCe0dcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateCreditor"/>
        [IsoId("_bSCe09cZEeqRFcf2R4bPBw")]
        [DisplayName("Ultimate Creditor")]
        [IsoXmlTag("UltmtCdtr")]
        public PartyIdentification135? UltimateCreditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Debtor"/>
        [IsoId("_bSCe1dcZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public required PartyIdentification135 Debtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAccount"/>
        [IsoId("_bSCe19cZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount40? DebtorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAgent"/>
        [IsoId("_bSCe2dcZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateDebtor"/>
        [IsoId("_bSCe29cZEeqRFcf2R4bPBw")]
        [DisplayName("Ultimate Debtor")]
        [IsoXmlTag("UltmtDbtr")]
        public PartyIdentification135? UltimateDebtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateReference"/>
        [IsoId("_bSCe3dcZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Reference")]
        [IsoXmlTag("MndtRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateReference { get; init; }

        /// <inheritdoc cref="IOriginalMandate.ReferredDocument"/>
        [IsoId("_bSCe39cZEeqRFcf2R4bPBw")]
        [DisplayName("Referred Document")]
        [IsoXmlTag("RfrdDoc")]
        public ReferredMandateDocument1? ReferredDocument { get; init; }
    }
}
