// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Registered Contract17.
/// </summary>
[IsoId("_2MYU4TEyEe6g-ffJsqGiSA")]
[DisplayName("Registered Contract17")]
public record RegisteredContract17
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax1025Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Attachment.
    /// </summary>
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = [];

    /// <summary>
    /// Contract.
    /// </summary>
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public required UnderlyingContract4Choice_ Contract { get; init; }

    /// <summary>
    /// Contract Balance.
    /// </summary>
    [DisplayName("Contract Balance")]
    [IsoXmlTag("CtrctBal")]
    public ValueList<ContractBalance1> ContractBalance { get; init; } = [];

    /// <summary>
    /// Original Registered Contract Identification.
    /// </summary>
    [DisplayName("Original Registered Contract Identification")]
    [IsoXmlTag("OrgnlRegdCtrctId")]
    public required IsoMax35Text OriginalRegisteredContractIdentification { get; init; }

    /// <summary>
    /// Payment Schedule Type.
    /// </summary>
    [DisplayName("Payment Schedule Type")]
    [IsoXmlTag("PmtSchdlTp")]
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; }

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public required Priority2Code Priority { get; init; }

    /// <summary>
    /// Registered Contract Amendment Identification.
    /// </summary>
    [DisplayName("Registered Contract Amendment Identification")]
    [IsoXmlTag("RegdCtrctAmdmntId")]
    public required IsoMax35Text RegisteredContractAmendmentIdentification { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
