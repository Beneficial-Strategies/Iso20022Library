// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creditor Invoice5.
/// </summary>
[IsoId("_zjVO_TEyEe6g-ffJsqGiSA")]
[DisplayName("Creditor Invoice5")]
public partial record CreditorInvoice5
{
    #nullable enable

    /// <summary>
    /// Activation Request Delivery Party.
    /// </summary>
    [DisplayName("Activation Request Delivery Party")]
    [IsoXmlTag("ActvtnReqDlvryPty")]
    public RTPPartyIdentification2? ActivationRequestDeliveryParty { get; init; } 

    /// <summary>
    /// Contract Format Type.
    /// </summary>
    [DisplayName("Contract Format Type")]
    [IsoXmlTag("CtrctFrmtTp")]
    public ValueList<DocumentFormat2Choice_> ContractFormatType { get; init; } = [];

    /// <summary>
    /// Contract Reference Type.
    /// </summary>
    [DisplayName("Contract Reference Type")]
    [IsoXmlTag("CtrctRefTp")]
    public ValueList<DocumentType1Choice_> ContractReferenceType { get; init; } = [];

    /// <summary>
    /// Creditor Instruction.
    /// </summary>
    [DisplayName("Creditor Instruction")]
    [IsoXmlTag("CdtrInstr")]
    public IsoMax500Text? CreditorInstruction { get; init; } 

    /// <summary>
    /// Customer Identification Type.
    /// </summary>
    [DisplayName("Customer Identification Type")]
    [IsoXmlTag("CstmrIdTp")]
    public CustomerTypeRequest2? CustomerIdentificationType { get; init; } 

    /// <summary>
    /// Limited Presentment Indicator.
    /// </summary>
    [DisplayName("Limited Presentment Indicator")]
    [IsoXmlTag("LtdPresntmntInd")]
    public IsoTrueFalseIndicator? LimitedPresentmentIndicator { get; init; } 

    
    #nullable disable
    
}
