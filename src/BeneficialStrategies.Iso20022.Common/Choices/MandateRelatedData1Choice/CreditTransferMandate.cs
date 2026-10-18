// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData1Choice
{
    /// <inheritdoc cref="ICreditTransferMandate"/>
    [IsoId("_2_Hf4clxEem0vqvvoqYsqQ")]
    [DisplayName("Credit Transfer Mandate")]
    [IsoXmlTag("CdtTrfMndt")]
    public partial record CreditTransferMandate : MandateRelatedData1Choice_
    {
        /// <inheritdoc cref="ICreditTransferMandate.MandateIdentification"/>
        [IsoId("_EgIuh8lqEem0vqvvoqYsqQ")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateIdentification { get; init; }

        /// <inheritdoc cref="ICreditTransferMandate.Type"/>
        [IsoId("_CLrtsclsEem0vqvvoqYsqQ")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MandateTypeInformation2? Type { get; init; }

        /// <inheritdoc cref="ICreditTransferMandate.DateOfSignature"/>
        [IsoId("_EgIuiclqEem0vqvvoqYsqQ")]
        [DisplayName("Date Of Signature")]
        [IsoXmlTag("DtOfSgntr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DateOfSignature { get; init; }

        /// <inheritdoc cref="ICreditTransferMandate.DateOfVerification"/>
        [IsoId("_MBcj0MlqEem0vqvvoqYsqQ")]
        [DisplayName("Date Of Verification")]
        [IsoXmlTag("DtOfVrfctn")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? DateOfVerification { get; init; }

        /// <inheritdoc cref="ICreditTransferMandate.ElectronicSignature"/>
        [IsoId("_EgIuj8lqEem0vqvvoqYsqQ")]
        [DisplayName("Electronic Signature")]
        [IsoXmlTag("ElctrncSgntr")]
        [IsoSimpleType(IsoSimpleType.Max10KBinary)]
        public IsoMax10KBinary? ElectronicSignature { get; init; }

        /// <inheritdoc cref="ICreditTransferMandate.FirstPaymentDate"/>
        [IsoId("_EgIukclqEem0vqvvoqYsqQ")]
        [DisplayName("First Payment Date")]
        [IsoXmlTag("FrstPmtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? FirstPaymentDate { get; init; }

        /// <inheritdoc cref="ICreditTransferMandate.FinalPaymentDate"/>
        [IsoId("_EgIuk8lqEem0vqvvoqYsqQ")]
        [DisplayName("Final Payment Date")]
        [IsoXmlTag("FnlPmtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? FinalPaymentDate { get; init; }

        /// <inheritdoc cref="ICreditTransferMandate.Frequency"/>
        [IsoId("_EgIulclqEem0vqvvoqYsqQ")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public Frequency36Choice_? Frequency { get; init; }

        /// <inheritdoc cref="ICreditTransferMandate.Reason"/>
        [IsoId("_EgIul8lqEem0vqvvoqYsqQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public MandateSetupReason1Choice_? Reason { get; init; }
    }
}
