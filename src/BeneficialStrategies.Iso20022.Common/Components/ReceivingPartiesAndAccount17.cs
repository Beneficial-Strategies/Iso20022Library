// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_BlPwYYfuEeevKP8c-ilVhA")]
[DisplayName("Receiving Parties And Account")]
public partial record ReceivingPartiesAndAccount17
{
    #nullable enable
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_B16Cl4fuEeevKP8c-ilVhA")]
    [DisplayName("Receiver Details")]
    [IsoXmlTag("RcvrDtls")]
    public InvestmentAccount65? ReceiverDetails { get; init; } 
    
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_B16CmYfuEeevKP8c-ilVhA")]
    [DisplayName("Receivers Custodian Details")]
    [IsoXmlTag("RcvrsCtdnDtls")]
    public PartyIdentificationAndAccount157? ReceiversCustodianDetails { get; init; } 
    
    /// <summary>
    /// Party that the receiver&apos;s custodian uses to effect the receipt of a security, when the receiver&apos;s custodian does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_B16Cm4fuEeevKP8c-ilVhA")]
    [DisplayName("Receivers Intermediary 1 Details")]
    [IsoXmlTag("RcvrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount157? ReceiversIntermediary1Details { get; init; } 
    
    /// <summary>
    /// Party that interacts with the receiver’s intermediary.
    /// </summary>
    [IsoId("_B16CnYfuEeevKP8c-ilVhA")]
    [DisplayName("Receivers Intermediary 2 Details")]
    [IsoXmlTag("RcvrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount157? ReceiversIntermediary2Details { get; init; } 
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_B16Cn4fuEeevKP8c-ilVhA")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public required PartyIdentificationAndAccount158 ReceivingAgentDetails { get; init; } 
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_B16CoYfuEeevKP8c-ilVhA")]
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_B16Co4fuEeevKP8c-ilVhA")]
    [DisplayName("Place Of Settlement Details")]
    [IsoXmlTag("PlcOfSttlmDtls")]
    public PartyIdentification123? PlaceOfSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
