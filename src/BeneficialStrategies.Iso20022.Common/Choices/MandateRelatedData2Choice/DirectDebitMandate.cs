// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData2Choice
{
    /// <inheritdoc cref="IDirectDebitMandate"/>
    [IsoId("_a4TwEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Direct Debit Mandate")]
    [IsoXmlTag("DrctDbtMndt")]
    public partial record DirectDebitMandate : MandateRelatedData2Choice_
    {
        /// <inheritdoc cref="IDirectDebitMandate.MandateIdentification"/>
        [IsoId("_a5rCBdcZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateIdentification { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.DateOfSignature"/>
        [IsoId("_a5rCB9cZEeqRFcf2R4bPBw")]
        [DisplayName("Date Of Signature")]
        [IsoXmlTag("DtOfSgntr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DateOfSignature { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.AmendmentIndicator"/>
        [IsoId("_a5rCCdcZEeqRFcf2R4bPBw")]
        [DisplayName("Amendment Indicator")]
        [IsoXmlTag("AmdmntInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.AmendmentInformationDetails"/>
        [IsoId("_a5rCC9cZEeqRFcf2R4bPBw")]
        [DisplayName("Amendment Information Details")]
        [IsoXmlTag("AmdmntInfDtls")]
        public AmendmentInformationDetails14? AmendmentInformationDetails { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.ElectronicSignature"/>
        [IsoId("_a5rCDdcZEeqRFcf2R4bPBw")]
        [DisplayName("Electronic Signature")]
        [IsoXmlTag("ElctrncSgntr")]
        [IsoSimpleType(IsoSimpleType.Max1025Text)]
        [StringLength(maximumLength: 1025, MinimumLength = 1)]
        public IsoMax1025Text? ElectronicSignature { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.FirstCollectionDate"/>
        [IsoId("_a5rpEdcZEeqRFcf2R4bPBw")]
        [DisplayName("First Collection Date")]
        [IsoXmlTag("FrstColltnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? FirstCollectionDate { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.FinalCollectionDate"/>
        [IsoId("_a5rpE9cZEeqRFcf2R4bPBw")]
        [DisplayName("Final Collection Date")]
        [IsoXmlTag("FnlColltnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? FinalCollectionDate { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.Frequency"/>
        [IsoId("_a5rpFdcZEeqRFcf2R4bPBw")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public Frequency36Choice_? Frequency { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.Reason"/>
        [IsoId("_a5rpF9cZEeqRFcf2R4bPBw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public MandateSetupReason1Choice_? Reason { get; init; }

        /// <inheritdoc cref="IDirectDebitMandate.TrackingDays"/>
        [IsoId("_a5rpGdcZEeqRFcf2R4bPBw")]
        [DisplayName("Tracking Days")]
        [IsoXmlTag("TrckgDays")]
        [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
        public IsoExact2NumericText? TrackingDays { get; init; }
    }
}
