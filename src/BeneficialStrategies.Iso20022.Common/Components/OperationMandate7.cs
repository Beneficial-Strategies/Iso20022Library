// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Operation Mandate7.
/// </summary>
[IsoId("_1R0xKTEyEe6g-ffJsqGiSA")]
[DisplayName("Operation Mandate7")]
public partial record OperationMandate7
{
    #nullable enable

    /// <summary>
    /// Applicable Channel.
    /// </summary>
    [DisplayName("Applicable Channel")]
    [IsoXmlTag("AplblChanl")]
    public ValueList<Channel2Choice_> ApplicableChannel { get; init; } = [];

    /// <summary>
    /// Bank Operation.
    /// </summary>
    [DisplayName("Bank Operation")]
    [IsoXmlTag("BkOpr")]
    public ValueList<BankTransactionCodeStructure4> BankOperation { get; init; } = [];

    /// <summary>
    /// End Date.
    /// </summary>
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public IsoISODate? EndDate { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; } 

    /// <summary>
    /// Mandate Holder.
    /// </summary>
    [DisplayName("Mandate Holder")]
    [IsoXmlTag("MndtHldr")]
    public ValueList<PartyAndAuthorisation7> MandateHolder { get; init; } = [];

    /// <summary>
    /// Required Signature Number.
    /// </summary>
    [DisplayName("Required Signature Number")]
    [IsoXmlTag("ReqrdSgntrNb")]
    public required IsoMax15PlusSignedNumericText RequiredSignatureNumber { get; init; } 

    /// <summary>
    /// Signature Order Indicator.
    /// </summary>
    [DisplayName("Signature Order Indicator")]
    [IsoXmlTag("SgntrOrdrInd")]
    public required IsoYesNoIndicator SignatureOrderIndicator { get; init; } 

    /// <summary>
    /// Start Date.
    /// </summary>
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public IsoISODate? StartDate { get; init; } 

    
    #nullable disable
    
}
