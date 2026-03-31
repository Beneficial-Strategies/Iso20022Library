// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further information required for the account switch.
/// </summary>
[IsoId("_AU8gYUz5EeepdbMfWGyv3Q")]
[DisplayName("Transfer Instruction")]
public record TransferInstruction1
{
    /// <summary>
    /// Indicates whether a payment arrangement is transferable.
    /// Usage: Default value for TransferIndicator is false.
    /// </summary>
    [IsoId("_e2fXIEz5EeepdbMfWGyv3Q")]
    [DisplayName("Transfer Indicator")]
    [IsoXmlTag("TrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransferIndicator { get; init; }

    /// <summary>
    /// Specifies an additional parameter to be applied to the requested transaction schedule.
    /// </summary>
    [IsoId("_AjO0AUz5EeepdbMfWGyv3Q")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Code { get; init; }

    /// <summary>
    /// Specifies an additional parameter to be applied to the transaction schedule in a proprietary format.
    /// </summary>
    [IsoId("_AjO0A0z5EeepdbMfWGyv3Q")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Proprietary { get; init; }

    /// <summary>
    /// The date and time at which the event specified by Code commences.
    /// </summary>
    [IsoId("_AjO0B0z5EeepdbMfWGyv3Q")]
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartDateTime { get; init; }

    /// <summary>
    /// The date on which the event specified by Code commences.
    /// </summary>
    [IsoId("_AjO0CUz5EeepdbMfWGyv3Q")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Additional switch parameters in a free text format.
    /// </summary>
    [IsoId("_AjO0C0z5EeepdbMfWGyv3Q")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; }
}
