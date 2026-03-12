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
[IsoId("_VPwneNp-Ed-ak6NoX_4Aeg_1612453912")]
[DisplayName("Delivering Parties And Account")]
public partial record DeliveringPartiesAndAccount1
{
    #nullable enable
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_VPwnedp-Ed-ak6NoX_4Aeg_-113392795")]
    [DisplayName("Deliverer Details")]
    [IsoXmlTag("DlvrrDtls")]
    public required InvestmentAccount11 DelivererDetails { get; init; } 
    
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_VPwnetp-Ed-ak6NoX_4Aeg_-920738279")]
    [DisplayName("Deliverers Custodian Details")]
    [IsoXmlTag("DlvrrsCtdnDtls")]
    public PartyIdentificationAndAccount2? DeliverersCustodianDetails { get; init; } 
    
    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_VPwne9p-Ed-ak6NoX_4Aeg_-905962487")]
    [DisplayName("Deliverers Intermediary Details")]
    [IsoXmlTag("DlvrrsIntrmyDtls")]
    public PartyIdentificationAndAccount2? DeliverersIntermediaryDetails { get; init; } 
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.
    /// </summary>
    [IsoId("_VPwnfNp-Ed-ak6NoX_4Aeg_-940132827")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public required PartyIdentificationAndAccount2 DeliveringAgentDetails { get; init; } 
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_VPwnfdp-Ed-ak6NoX_4Aeg_460557631")]
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_VP5xYNp-Ed-ak6NoX_4Aeg_312914241")]
    [DisplayName("Place Of Settlement Details")]
    [IsoXmlTag("PlcOfSttlmDtls")]
    public required PartyIdentificationAndAccount2 PlaceOfSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
