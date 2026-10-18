// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferMandateData1"/>
[IsoId("_EVj2MclqEem0vqvvoqYsqQ")]
[DisplayName("Credit Transfer Mandate Data")]
public partial record CreditTransferMandateData1
{
    /// <inheritdoc cref="ICreditTransferMandateData1.MandateIdentification"/>
    [IsoId("_EgIuh8lqEem0vqvvoqYsqQ")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferMandateData1.Type"/>
    [IsoId("_CLrtsclsEem0vqvvoqYsqQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <inheritdoc cref="ICreditTransferMandateData1.DateOfSignature"/>
    [IsoId("_EgIuiclqEem0vqvvoqYsqQ")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; }

    /// <inheritdoc cref="ICreditTransferMandateData1.DateOfVerification"/>
    [IsoId("_MBcj0MlqEem0vqvvoqYsqQ")]
    [DisplayName("Date Of Verification")]
    [IsoXmlTag("DtOfVrfctn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateOfVerification { get; init; }

    /// <inheritdoc cref="ICreditTransferMandateData1.ElectronicSignature"/>
    [IsoId("_EgIuj8lqEem0vqvvoqYsqQ")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ElectronicSignature { get; init; }

    /// <inheritdoc cref="ICreditTransferMandateData1.FirstPaymentDate"/>
    [IsoId("_EgIukclqEem0vqvvoqYsqQ")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FirstPaymentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferMandateData1.FinalPaymentDate"/>
    [IsoId("_EgIuk8lqEem0vqvvoqYsqQ")]
    [DisplayName("Final Payment Date")]
    [IsoXmlTag("FnlPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FinalPaymentDate { get; init; }

    /// <inheritdoc cref="ICreditTransferMandateData1.Frequency"/>
    [IsoId("_EgIulclqEem0vqvvoqYsqQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency36Choice_? Frequency { get; init; }

    /// <inheritdoc cref="ICreditTransferMandateData1.Reason"/>
    [IsoId("_EgIul8lqEem0vqvvoqYsqQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }
}
