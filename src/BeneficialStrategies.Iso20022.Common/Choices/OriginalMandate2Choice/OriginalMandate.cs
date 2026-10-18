// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate2Choice
{
    /// <inheritdoc cref="IOriginalMandate"/>
    [IsoId("_tpGiYFkyEeGeoaLUQk__nA_-668633660")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public partial record OriginalMandate : OriginalMandate2Choice_
    {
        /// <inheritdoc cref="IOriginalMandate.MandateIdentification"/>
        [IsoId("_tyfH5FkyEeGeoaLUQk__nA_-1872236648")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text MandateIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MandateRequestIdentification"/>
        [IsoId("_tyo44FkyEeGeoaLUQk__nA_-1111471495")]
        [DisplayName("Mandate Request Identification")]
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateRequestIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Type"/>
        [IsoId("_tyo44VkyEeGeoaLUQk__nA_-1917957078")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MandateTypeInformation1? Type { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Occurrences"/>
        [IsoId("_tyo44lkyEeGeoaLUQk__nA_1393687531")]
        [DisplayName("Occurrences")]
        [IsoXmlTag("Ocrncs")]
        public MandateOccurrences2? Occurrences { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CollectionAmount"/>
        [IsoId("_tyo441kyEeGeoaLUQk__nA_-501069567")]
        [DisplayName("Collection Amount")]
        [IsoXmlTag("ColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.MaximumAmount"/>
        [IsoId("_tyo45FkyEeGeoaLUQk__nA_705920533")]
        [DisplayName("Maximum Amount")]
        [IsoXmlTag("MaxAmt")]
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorSchemeIdentification"/>
        [IsoId("_tyyp4FkyEeGeoaLUQk__nA_1962059543")]
        [DisplayName("Creditor Scheme Identification")]
        [IsoXmlTag("CdtrSchmeId")]
        public PartyIdentification43? CreditorSchemeIdentification { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Creditor"/>
        [IsoId("_tyyp4VkyEeGeoaLUQk__nA_1240955787")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public required PartyIdentification43 Creditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAccount"/>
        [IsoId("_tyyp4lkyEeGeoaLUQk__nA_-995188356")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount24? CreditorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.CreditorAgent"/>
        [IsoId("_tyyp41kyEeGeoaLUQk__nA_-234423203")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateCreditor"/>
        [IsoId("_tyyp5FkyEeGeoaLUQk__nA_1932716250")]
        [DisplayName("Ultimate Creditor")]
        [IsoXmlTag("UltmtCdtr")]
        public PartyIdentification43? UltimateCreditor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.Debtor"/>
        [IsoId("_ty7z0FkyEeGeoaLUQk__nA_875396210")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public required PartyIdentification43 Debtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAccount"/>
        [IsoId("_ty7z0VkyEeGeoaLUQk__nA_1257851318")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount24? DebtorAccount { get; init; }

        /// <inheritdoc cref="IOriginalMandate.DebtorAgent"/>
        [IsoId("_ty7z0lkyEeGeoaLUQk__nA_-75473929")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

        /// <inheritdoc cref="IOriginalMandate.UltimateDebtor"/>
        [IsoId("_ty7z01kyEeGeoaLUQk__nA_-86572706")]
        [DisplayName("Ultimate Debtor")]
        [IsoXmlTag("UltmtDbtr")]
        public PartyIdentification43? UltimateDebtor { get; init; }

        /// <inheritdoc cref="IOriginalMandate.ReferredDocument"/>
        [IsoId("_ty7z1FkyEeGeoaLUQk__nA_1034345484")]
        [DisplayName("Referred Document")]
        [IsoXmlTag("RfrdDoc")]
        public ReferredDocumentInformation3? ReferredDocument { get; init; }
    }
}
