// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to report on the payment status.
/// </summary>
[IsoId("_RImk0tp-Ed-ak6NoX_4Aeg_-1267402839")]
[DisplayName("Instruction Status Return Criteria")]
public record InstructionStatusReturnCriteria
{
    /// <summary>
    /// Indicates if the instruction status is requested.
    /// </summary>
    [IsoId("_RImk09p-Ed-ak6NoX_4Aeg_-1267402838")]
    [DisplayName("Payment Instruction Status Indicator")]
    [IsoXmlTag("PmtInstrStsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator PaymentInstructionStatusIndicator { get; init; }

    /// <summary>
    /// Indicates if the status date and time are requested.
    /// </summary>
    [IsoId("_RImk1Np-Ed-ak6NoX_4Aeg_-1267402837")]
    [DisplayName("Payment Instruction Status Date Time Indicator")]
    [IsoXmlTag("PmtInstrStsDtTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentInstructionStatusDateTimeIndicator { get; init; }

    /// <summary>
    /// Indicates if the status reason is requested.
    /// </summary>
    [IsoId("_RImk1dp-Ed-ak6NoX_4Aeg_-1267402836")]
    [DisplayName("Payment Instruction Status Reason Indicator")]
    [IsoXmlTag("PmtInstrStsRsnInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentInstructionStatusReasonIndicator { get; init; }
}
