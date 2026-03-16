// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes for a debtor activation.
/// </summary>
[IsoId("_UPBU9eH7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation")]
public record DebtorActivation3
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the activation.
    /// Usage:
    /// This element may be used for technical reconciliation purpose.
    /// </summary>
    [IsoId("_UQacEeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Debtor Activation Identification")]
    [IsoXmlTag("DbtrActvtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorActivationIdentification { get; init; }

    /// <summary>
    /// Name by which the debtor is known, other than legal name, such as the name to be shown to the creditor.
    /// </summary>
    [IsoId("_UQacE-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Display Name")]
    [IsoXmlTag("DispNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? DisplayName { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_UQacFeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public RTPPartyIdentification1? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_UQacF-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required RTPPartyIdentification1 Debtor { get; init; }

    /// <summary>
    /// Organisation servicing the e-invoicing for the debtor (to which the activation status report must be sent).
    /// </summary>
    [IsoId("_UQacGeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Debtor Solution Provider")]
    [IsoXmlTag("DbtrSolPrvdr")]
    public required RTPPartyIdentification1 DebtorSolutionProvider { get; init; }

    /// <summary>
    /// Unique identifier of the debtor required by the creditor, for example  the reference number or customer number. Unique identification provided by the web bank or web payment services user, with which the creditor may identify the debtor in its system.
    /// </summary>
    [IsoId("_UQacG-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    public Party49Choice_? CustomerIdentification { get; init; }

    /// <summary>
    /// Document format type supported to exchange the contracts.
    /// </summary>
    [IsoId("_UQacHeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Contract Format Type")]
    [IsoXmlTag("CtrctFrmtTp")]
    public DocumentFormat2Choice_? ContractFormatType { get; init; }

    /// <summary>
    /// Code choice external/prop
    /// Description
    /// identical to the Instruction for Debtor
    /// </summary>
    [IsoId("_UQacH-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    public ContractReference1? ContractReference { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_UQacIeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required RTPPartyIdentification1 Creditor { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_UQacI-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public RTPPartyIdentification1? UltimateCreditor { get; init; }

    /// <summary>
    /// Creditor&apos;s service provider address to which the debtor activation has to be delivered.
    /// </summary>
    [IsoId("_UQacJeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Activation Request Delivery Party")]
    [IsoXmlTag("ActvtnReqDlvryPty")]
    public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; init; }

    /// <summary>
    /// Date and time at which the debtor activation will be activated.
    /// </summary>
    [IsoId("_UQacJ-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public DateAndDateTime2Choice_? StartDate { get; init; }

    /// <summary>
    /// Date and time at which the debtor activation will be deactivated.
    /// </summary>
    [IsoId("_UQacKeH7Eeqbls7Gk4-ckA")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public DateAndDateTime2Choice_? EndDate { get; init; }

    /// <summary>
    /// Unique, one-time code that a creditor may require from a debtor for activation purposes, and which is known only by the creditor and the debtor.
    /// </summary>
    [IsoId("_UQacMeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Dedicated Activation Code")]
    [IsoXmlTag("DdctdActvtnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DedicatedActivationCode { get; init; }
}
