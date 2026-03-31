// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_PYcRcbGJEeuSTr8k0UEM8A")]
[DisplayName("Registered Contract")]
public record RegisteredContract14
{
    /// <summary>
    /// Unique and unambiguous identification of the registered contract amendment request.
    /// </summary>
    [IsoId("_PZZTsbGJEeuSTr8k0UEM8A")]
    [DisplayName("Registered Contract Amendment Identification")]
    [IsoXmlTag("RegdCtrctAmdmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RegisteredContractAmendmentIdentification { get; init; }

    /// <summary>
    /// Identification of the original contract registration, as registered with the registration agent.
    /// </summary>
    [IsoId("_PZZTubGJEeuSTr8k0UEM8A")]
    [DisplayName("Original Registered Contract Identification")]
    [IsoXmlTag("OrgnlRegdCtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalRegisteredContractIdentification { get; init; }

    /// <summary>
    /// Priority requested for the amendment of the registered contract.
    /// </summary>
    [IsoId("_PZZTwbGJEeuSTr8k0UEM8A")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public required Priority2Code Priority { get; init; }

    /// <summary>
    /// Amendment details of the registered contract for the registered contract.
    /// </summary>
    [IsoId("_PZZTw7GJEeuSTr8k0UEM8A")]
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public required UnderlyingContract3Choice_ Contract { get; init; }

    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    [IsoId("_PZZTxbGJEeuSTr8k0UEM8A")]
    [DisplayName("Contract Balance")]
    [IsoXmlTag("CtrctBal")]
    public ValueList<ContractBalance1> ContractBalance { get; init; } = [];

    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    [IsoId("_PZZTx7GJEeuSTr8k0UEM8A")]
    [DisplayName("Payment Schedule Type")]
    [IsoXmlTag("PmtSchdlTp")]
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; }

    /// <summary>
    /// Further additional information on the amendment.
    /// </summary>
    [IsoId("_PZZTybGJEeuSTr8k0UEM8A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Documents provided as attachments to the contract registration amendment request.
    /// </summary>
    [IsoId("_PZZTy7GJEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_PZZTzbGJEeuSTr8k0UEM8A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
