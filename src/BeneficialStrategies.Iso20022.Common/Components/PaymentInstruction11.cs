// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction11"/>
[IsoId("_GWSo0TimEeKpHbBQ3XWFBw")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction11
{
    /// <inheritdoc cref="IPaymentInstruction11.PaymentInformationIdentification"/>
    [IsoId("_GhfzbTimEeKpHbBQ3XWFBw")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.PaymentMethod"/>
    [IsoId("_GhfzcTimEeKpHbBQ3XWFBw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.PaymentTypeInformation"/>
    [IsoId("_GhfzdTimEeKpHbBQ3XWFBw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.RequestedExecutionDate"/>
    [IsoId("_GhfzeTimEeKpHbBQ3XWFBw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.Debtor"/>
    [IsoId("_GhgaUTimEeKpHbBQ3XWFBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.DebtorAccount"/>
    [IsoId("_GhgaVTimEeKpHbBQ3XWFBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.DebtorAgent"/>
    [IsoId("_GhgaWTimEeKpHbBQ3XWFBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.UltimateDebtor"/>
    [IsoId("_GhgaXTimEeKpHbBQ3XWFBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.ChargeBearer"/>
    [IsoId("_GhgaYTimEeKpHbBQ3XWFBw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction11.CreditTransferTransaction"/>
    [IsoId("_GhgaZTimEeKpHbBQ3XWFBw")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransaction10> CreditTransferTransaction { get; init; } = [];
    // ID for the above is _GhgaZTimEeKpHbBQ3XWFBw
}
