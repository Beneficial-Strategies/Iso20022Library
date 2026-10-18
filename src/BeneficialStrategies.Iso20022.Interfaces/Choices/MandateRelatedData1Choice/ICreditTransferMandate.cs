// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData1Choice;

/// <summary>
/// Specific credit transfer mandate data.
/// </summary>
[IsoId("_2_Hf4clxEem0vqvvoqYsqQ")]
public interface ICreditTransferMandate : IMandateRelatedData1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_EgIuh8lqEem0vqvvoqYsqQ")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    IsoMax35Text? MandateIdentification { get; }

    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    [IsoId("_CLrtsclsEem0vqvvoqYsqQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IMandateTypeInformation2? Type { get; }

    /// <summary>
    /// Date on which the credit transfer mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_EgIuiclqEem0vqvvoqYsqQ")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    IsoISODate? DateOfSignature { get; }

    /// <summary>
    /// Date on which the credit transfer mandate has been verified.
    /// </summary>
    [IsoId("_MBcj0MlqEem0vqvvoqYsqQ")]
    [DisplayName("Date Of Verification")]
    [IsoXmlTag("DtOfVrfctn")]
    IsoISODateTime? DateOfVerification { get; }

    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_EgIuj8lqEem0vqvvoqYsqQ")]
    [DisplayName("Electronic Signature")]
    [IsoXmlTag("ElctrncSgntr")]
    IsoMax10KBinary? ElectronicSignature { get; }

    /// <summary>
    /// Date of the first payment of a recurrent credit transfer as per the mandate.
    /// </summary>
    [IsoId("_EgIukclqEem0vqvvoqYsqQ")]
    [DisplayName("First Payment Date")]
    [IsoXmlTag("FrstPmtDt")]
    IsoISODate? FirstPaymentDate { get; }

    /// <summary>
    /// Date of the final payment of a recurrent credit transfer as per the mandate.
    /// </summary>
    [IsoId("_EgIuk8lqEem0vqvvoqYsqQ")]
    [DisplayName("Final Payment Date")]
    [IsoXmlTag("FnlPmtDt")]
    IsoISODate? FinalPaymentDate { get; }

    /// <summary>
    /// Regularity with which credit transfer instructions are to be created and processed.
    /// </summary>
    [IsoId("_EgIulclqEem0vqvvoqYsqQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    IFrequency36Choice? Frequency { get; }

    /// <summary>
    /// Reason for the setup of the credit transfer mandate.
    /// Usage:
    /// The reason will allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    [IsoId("_EgIul8lqEem0vqvvoqYsqQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IMandateSetupReason1Choice? Reason { get; }
}
