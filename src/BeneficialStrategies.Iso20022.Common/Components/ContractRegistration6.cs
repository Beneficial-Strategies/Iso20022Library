// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorized servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_w9E7MbGIEeuSTr8k0UEM8A")]
[DisplayName("Contract Registration")]
public record ContractRegistration6
{
    /// <summary>
    /// Unique and unambiguous identification of the registered contract opening.
    /// </summary>
    [IsoId("_w-U4YbGIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Registration Opening Identification")]
    [IsoXmlTag("CtrctRegnOpngId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ContractRegistrationOpeningIdentification { get; init; }

    /// <summary>
    /// Priority requested for the opening of the registered contract.
    /// </summary>
    [IsoId("_w-U4abGIEeuSTr8k0UEM8A")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public required Priority2Code Priority { get; init; }

    /// <summary>
    /// Details of the contract being registered.
    /// </summary>
    [IsoId("_w-U4a7GIEeuSTr8k0UEM8A")]
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public required UnderlyingContract3Choice_ Contract { get; init; }

    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    [IsoId("_w-U4bbGIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Balance")]
    [IsoXmlTag("CtrctBal")]
    public ValueList<ContractBalance1> ContractBalance { get; init; } = [];

    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    [IsoId("_w-U4b7GIEeuSTr8k0UEM8A")]
    [DisplayName("Payment Schedule Type")]
    [IsoXmlTag("PmtSchdlTp")]
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a previous contract registration.
    /// </summary>
    [IsoId("_w-U4cbGIEeuSTr8k0UEM8A")]
    [DisplayName("Previous Registration Identification")]
    [IsoXmlTag("PrvsRegnId")]
    public ValueList<DocumentIdentification22> PreviousRegistrationIdentification { get; init; } =
        [];

    /// <summary>
    /// Further details on the registered contract opening.
    /// </summary>
    [IsoId("_w-U4c7GIEeuSTr8k0UEM8A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Documents provided as attachments to the contract registration request.
    /// </summary>
    [IsoId("_w-U4dbGIEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_w-U4d7GIEeuSTr8k0UEM8A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
