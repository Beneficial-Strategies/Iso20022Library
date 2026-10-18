// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate9Choice
{
    /// <inheritdoc cref="IOriginalMandate"/>
    [IsoId("_eBUvc9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public partial record OriginalMandate : OriginalMandate9Choice_
    {
        /// <inheritdoc cref="IOriginalMandate.MandateIdentification"/>
        [IsoId("_eCqzRdcZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text MandateIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateRequestIdentification"/>
        [IsoId("_eCqzR9cZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Request Identification")]
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateRequestIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Authentication"/>
        [IsoId("_eCqzSdcZEeqRFcf2R4bPBw")]
        [DisplayName("Authentication")]
        [IsoXmlTag("Authntcn")]
        public MandateAuthentication1? Authentication { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Type"/>
        [IsoId("_eCqzS9cZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MandateTypeInformation2? Type { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Occurrences"/>
        [IsoId("_eCqzTdcZEeqRFcf2R4bPBw")]
        [DisplayName("Occurrences")]
        [IsoXmlTag("Ocrncs")]
        public MandateOccurrences5? Occurrences { get; init; }

        /// <inheritdoc cref="IOriginalMandate.TrackingIndicator"/>
        [IsoId("_eCqzT9cZEeqRFcf2R4bPBw")]
        [DisplayName("Tracking Indicator")]
        [IsoXmlTag("TrckgInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

        /// <inheritdoc cref="IOriginalMandate.FirstCollectionAmount"/>
        [IsoId("_eCqzUdcZEeqRFcf2R4bPBw")]
        [DisplayName("First Collection Amount")]
        [IsoXmlTag("FrstColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CollectionAmount"/>
        [IsoId("_eCqzU9cZEeqRFcf2R4bPBw")]
        [DisplayName("Collection Amount")]
        [IsoXmlTag("ColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MaximumAmount"/>
        [IsoId("_eCqzVdcZEeqRFcf2R4bPBw")]
        [DisplayName("Maximum Amount")]
        [IsoXmlTag("MaxAmt")]
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Adjustment"/>
        [IsoId("_eCqzV9cZEeqRFcf2R4bPBw")]
        [DisplayName("Adjustment")]
        [IsoXmlTag("Adjstmnt")]
        public MandateAdjustment1? Adjustment { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Reason"/>
        [IsoId("_eCqzWdcZEeqRFcf2R4bPBw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public MandateSetupReason1Choice_? Reason { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorSchemeIdentification"/>
        [IsoId("_eCqzW9cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Scheme Identification")]
        [IsoXmlTag("CdtrSchmeId")]
        public PartyIdentification135? CreditorSchemeIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Creditor"/>
        [IsoId("_eCqzXdcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public required PartyIdentification135 Creditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAccount"/>
        [IsoId("_eCqzX9cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount40? CreditorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAgent"/>
        [IsoId("_eCqzYdcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateCreditor"/>
        [IsoId("_eCqzY9cZEeqRFcf2R4bPBw")]
        [DisplayName("Ultimate Creditor")]
        [IsoXmlTag("UltmtCdtr")]
        public PartyIdentification135? UltimateCreditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Debtor"/>
        [IsoId("_eCqzZdcZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public required PartyIdentification135 Debtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAccount"/>
        [IsoId("_eCqzZ9cZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount40? DebtorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAgent"/>
        [IsoId("_eCqzadcZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateDebtor"/>
        [IsoId("_eCqza9cZEeqRFcf2R4bPBw")]
        [DisplayName("Ultimate Debtor")]
        [IsoXmlTag("UltmtDbtr")]
        public PartyIdentification135? UltimateDebtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateReference"/>
        [IsoId("_eCqzbdcZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Reference")]
        [IsoXmlTag("MndtRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateReference { get; init; }

        /// <inheritdoc cref="IOriginalMandate.ReferredDocument"/>
        [IsoId("_eCqzb9cZEeqRFcf2R4bPBw")]
        [DisplayName("Referred Document")]
        [IsoXmlTag("RfrdDoc")]
        public ReferredMandateDocument1? ReferredDocument { get; init; }
    }
}
