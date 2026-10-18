// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate7Choice
{
    /// <inheritdoc cref="IOriginalMandate"/>
    [IsoId("_Z7tR9W49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public partial record OriginalMandate : OriginalMandate7Choice_
    {
        /// <inheritdoc cref="IOriginalMandate.MandateIdentification"/>
        [IsoId("_aHoOF249EeiU9cctagi5ow")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateRequestIdentification"/>
        [IsoId("_aHoOGW49EeiU9cctagi5ow")]
        [DisplayName("Mandate Request Identification")]
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateRequestIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Authentication"/>
        [IsoId("_aHoOG249EeiU9cctagi5ow")]
        [DisplayName("Authentication")]
        [IsoXmlTag("Authntcn")]
        public MandateAuthentication1? Authentication { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Type"/>
        [IsoId("_aHoOHW49EeiU9cctagi5ow")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MandateTypeInformation2? Type { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Occurrences"/>
        [IsoId("_aHoOH249EeiU9cctagi5ow")]
        [DisplayName("Occurrences")]
        [IsoXmlTag("Ocrncs")]
        public MandateOccurrences4? Occurrences { get; init; }

        /// <inheritdoc cref="IOriginalMandate.TrackingIndicator"/>
        [IsoId("_aHoOIW49EeiU9cctagi5ow")]
        [DisplayName("Tracking Indicator")]
        [IsoXmlTag("TrckgInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

        /// <inheritdoc cref="IOriginalMandate.FirstCollectionAmount"/>
        [IsoId("_aHoOI249EeiU9cctagi5ow")]
        [DisplayName("First Collection Amount")]
        [IsoXmlTag("FrstColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CollectionAmount"/>
        [IsoId("_aHoOJW49EeiU9cctagi5ow")]
        [DisplayName("Collection Amount")]
        [IsoXmlTag("ColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MaximumAmount"/>
        [IsoId("_aHoOJ249EeiU9cctagi5ow")]
        [DisplayName("Maximum Amount")]
        [IsoXmlTag("MaxAmt")]
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Adjustment"/>
        [IsoId("_aHoOKW49EeiU9cctagi5ow")]
        [DisplayName("Adjustment")]
        [IsoXmlTag("Adjstmnt")]
        public MandateAdjustment1? Adjustment { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Reason"/>
        [IsoId("_aHoOK249EeiU9cctagi5ow")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public MandateSetupReason1Choice_? Reason { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorSchemeIdentification"/>
        [IsoId("_aHoOLW49EeiU9cctagi5ow")]
        [DisplayName("Creditor Scheme Identification")]
        [IsoXmlTag("CdtrSchmeId")]
        public PartyIdentification135? CreditorSchemeIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Creditor"/>
        [IsoId("_aHoOL249EeiU9cctagi5ow")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public required PartyIdentification135 Creditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAccount"/>
        [IsoId("_aHoOMW49EeiU9cctagi5ow")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount38? CreditorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAgent"/>
        [IsoId("_aHoOM249EeiU9cctagi5ow")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateCreditor"/>
        [IsoId("_aHoONW49EeiU9cctagi5ow")]
        [DisplayName("Ultimate Creditor")]
        [IsoXmlTag("UltmtCdtr")]
        public PartyIdentification135? UltimateCreditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Debtor"/>
        [IsoId("_aHoON249EeiU9cctagi5ow")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public required PartyIdentification135 Debtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAccount"/>
        [IsoId("_aHoOOW49EeiU9cctagi5ow")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount38? DebtorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAgent"/>
        [IsoId("_aHoOO249EeiU9cctagi5ow")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateDebtor"/>
        [IsoId("_aHoOPW49EeiU9cctagi5ow")]
        [DisplayName("Ultimate Debtor")]
        [IsoXmlTag("UltmtDbtr")]
        public PartyIdentification135? UltimateDebtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateReference"/>
        [IsoId("_aHoOP249EeiU9cctagi5ow")]
        [DisplayName("Mandate Reference")]
        [IsoXmlTag("MndtRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateReference { get; init; }

        /// <inheritdoc cref="IOriginalMandate.ReferredDocument"/>
        [IsoId("_aHoOQW49EeiU9cctagi5ow")]
        [DisplayName("Referred Document")]
        [IsoXmlTag("RfrdDoc")]
        public ReferredMandateDocument1? ReferredDocument { get; init; }
    }
}
