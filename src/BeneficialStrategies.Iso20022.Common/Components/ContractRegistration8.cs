// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract Registration8.
/// </summary>
[IsoId("_7LO0gTEyEe6g-ffJsqGiSA")]
[DisplayName("Contract Registration8")]
public partial record ContractRegistration8
{
    #nullable enable

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
    /// Contract Registration Opening Identification.
    /// </summary>
    [DisplayName("Contract Registration Opening Identification")]
    [IsoXmlTag("CtrctRegnOpngId")]
    public required IsoMax35Text ContractRegistrationOpeningIdentification { get; init; } 

    /// <summary>
    /// Payment Schedule Type.
    /// </summary>
    [DisplayName("Payment Schedule Type")]
    [IsoXmlTag("PmtSchdlTp")]
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; } 

    /// <summary>
    /// Previous Registration Identification.
    /// </summary>
    [DisplayName("Previous Registration Identification")]
    [IsoXmlTag("PrvsRegnId")]
    public ValueList<DocumentIdentification22> PreviousRegistrationIdentification { get; init; } = [];

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public required Priority2Code Priority { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    
    #nullable disable
    
}
