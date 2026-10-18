// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstructionInformation1"/>
[IsoId("_PhfdE9p-Ed-ak6NoX_4Aeg_-259128313")]
[DisplayName("Payment Instruction Information")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public partial record PaymentInstructionInformation1
{
    /// <inheritdoc cref="IPaymentInstructionInformation1.PaymentInformationIdentification"/>
    [IsoId("_PhfdFNp-Ed-ak6NoX_4Aeg_545264123")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.PaymentMethod"/>
    [IsoId("_PhfdFdp-Ed-ak6NoX_4Aeg_-259128253")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.PaymentTypeInformation"/>
    [IsoId("_PhfdFtp-Ed-ak6NoX_4Aeg_-2044964532")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation1? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.RequestedExecutionDate"/>
    [IsoId("_PhfdF9p-Ed-ak6NoX_4Aeg_-259128294")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.PoolingAdjustmentDate"/>
    [IsoId("_PhfdGNp-Ed-ak6NoX_4Aeg_-2061588794")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.Debtor"/>
    [IsoId("_PhfdGdp-Ed-ak6NoX_4Aeg_-259128174")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification8 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.DebtorAccount"/>
    [IsoId("_PhonANp-Ed-ak6NoX_4Aeg_-259127767")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount7 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.DebtorAgent"/>
    [IsoId("_PhonAdp-Ed-ak6NoX_4Aeg_-259127338")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.DebtorAgentAccount"/>
    [IsoId("_PhonAtp-Ed-ak6NoX_4Aeg_-2060663386")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount7? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.UltimateDebtor"/>
    [IsoId("_PhonA9p-Ed-ak6NoX_4Aeg_-2045886160")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.ChargeBearer"/>
    [IsoId("_PhonBNp-Ed-ak6NoX_4Aeg_1606883128")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.ChargesAccount"/>
    [IsoId("_PhonBdp-Ed-ak6NoX_4Aeg_-259127278")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount7? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.ChargesAccountAgent"/>
    [IsoId("_PhonBtp-Ed-ak6NoX_4Aeg_-259127458")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification3? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation1.CreditTransferTransactionInformation"/>
    [IsoId("_PhonB9p-Ed-ak6NoX_4Aeg_-259127416")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransactionInformation1> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _PhonB9p-Ed-ak6NoX_4Aeg_-259127416
}
