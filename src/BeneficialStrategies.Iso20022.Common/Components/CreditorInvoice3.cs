// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification attribtues of an invoice which are required by the creditor for the activation of the debtor.
/// </summary>
[IsoId("_ABrj0eH5Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Invoice")]
public record CreditorInvoice3
{
    /// <summary>
    /// Indicates whether the creditor allows limited presentment of the e-invoice, that is, only the e-invoice data needed for payment initiation.
    /// </summary>
    [IsoId("_AEXrceH5Eeqbls7Gk4-ckA")]
    [DisplayName("Limited Presentment Indicator")]
    [IsoXmlTag("LtdPresntmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator LimitedPresentmentIndicator { get; init; }

    /// <summary>
    /// Unique and unambiguous type of the identification of the debtor required by the creditor, for example  the reference number or customer number. Unique identification provided by the web bank or web payment services user, with which the creditor may identify the debtor in its system.
    /// </summary>
    [IsoId("_AEXrc-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Customer Identification Type")]
    [IsoXmlTag("CstmrIdTp")]
    public CustomerTypeRequest2? CustomerIdentificationType { get; init; }

    /// <summary>
    /// Document format type supported to exchange the contracts.
    /// </summary>
    [IsoId("_AEXrdeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Contract Format Type")]
    [IsoXmlTag("CtrctFrmtTp")]
    public ValueList<DocumentFormat2Choice_> ContractFormatType { get; init; } = [];

    /// <summary>
    /// Type of the contract reference for which the enrolment is defined.Type of the contract reference requested by the creditor which the debtor must provide in the debtor activation request  to identify the contract(s) for which the RTP is requested.
    /// </summary>
    [IsoId("_AEXrd-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Contract Reference Type")]
    [IsoXmlTag("CtrctRefTp")]
    public ValueList<DocumentType1Choice_> ContractReferenceType { get; init; } = [];

    /// <summary>
    /// Instructions provided by the seller (that is creditor or ultimate creditor) for the Request-To-Pay (RTP) recipient (that is the debtor). The instructions may include for example the time required by the creditor to take into account the activation request. The debtor agent may display the information in the customer’s own service language.
    /// </summary>
    [IsoId("_AEXreeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor Instruction")]
    [IsoXmlTag("CdtrInstr")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? CreditorInstruction { get; init; }

    /// <summary>
    /// Creditor&apos;s service provider address to which the debtor activation has to be delivered.
    /// </summary>
    [IsoId("_AEXre-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Activation Request Delivery Party")]
    [IsoXmlTag("ActvtnReqDlvryPty")]
    public required RTPPartyIdentification1 ActivationRequestDeliveryParty { get; init; }
}
