// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Debtor Activation6.
/// </summary>
[IsoId("_wmIeATEyEe6g-ffJsqGiSA")]
[DisplayName("Debtor Activation6")]
public record DebtorActivation6
{
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
    /// Contract Reference.
    /// </summary>
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    public ValueList<ContractReference1> ContractReference { get; init; } = [];

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public RTPPartyIdentification2? Creditor { get; init; }

    /// <summary>
    /// Customer Identification.
    /// </summary>
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    public ValueList<Party53Choice_> CustomerIdentification { get; init; } = [];

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public RTPPartyIdentification2? Debtor { get; init; }

    /// <summary>
    /// Debtor Activation Identification.
    /// </summary>
    [DisplayName("Debtor Activation Identification")]
    [IsoXmlTag("DbtrActvtnId")]
    public IsoMax35Text? DebtorActivationIdentification { get; init; }

    /// <summary>
    /// Debtor Solution Provider.
    /// </summary>
    [DisplayName("Debtor Solution Provider")]
    [IsoXmlTag("DbtrSolPrvdr")]
    public RTPPartyIdentification2? DebtorSolutionProvider { get; init; }

    /// <summary>
    /// Dedicated Activation Code.
    /// </summary>
    [DisplayName("Dedicated Activation Code")]
    [IsoXmlTag("DdctdActvtnCd")]
    public IsoMax35Text? DedicatedActivationCode { get; init; }

    /// <summary>
    /// Display Name.
    /// </summary>
    [DisplayName("Display Name")]
    [IsoXmlTag("DispNm")]
    public IsoMax140Text? DisplayName { get; init; }

    /// <summary>
    /// End Date.
    /// </summary>
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public DateAndDateTime2Choice_? EndDate { get; init; }

    /// <summary>
    /// Start Date.
    /// </summary>
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public DateAndDateTime2Choice_? StartDate { get; init; }

    /// <summary>
    /// Ultimate Creditor.
    /// </summary>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public RTPPartyIdentification2? UltimateCreditor { get; init; }

    /// <summary>
    /// Ultimate Debtor.
    /// </summary>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public RTPPartyIdentification2? UltimateDebtor { get; init; }
}
