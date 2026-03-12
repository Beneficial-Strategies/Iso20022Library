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
[IsoId("_4Nxqe_soEeCFJsO61PplcQ")]
[DisplayName("Delivering Parties And Account")]
public partial record DeliveringPartiesAndAccount8
{
    #nullable enable
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_4NxqifsoEeCFJsO61PplcQ")]
    [DisplayName("Deliverer Details")]
    [IsoXmlTag("DlvrrDtls")]
    public InvestmentAccount24? DelivererDetails { get; init; } 
    
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_4NxqjfsoEeCFJsO61PplcQ")]
    [DisplayName("Deliverers Custodian Details")]
    [IsoXmlTag("DlvrrsCtdnDtls")]
    public PartyIdentificationAndAccount5? DeliverersCustodianDetails { get; init; } 
    
    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_4NxqkfsoEeCFJsO61PplcQ")]
    [DisplayName("Deliverers Intermediary Details")]
    [IsoXmlTag("DlvrrsIntrmyDtls")]
    public PartyIdentificationAndAccount5? DeliverersIntermediaryDetails { get; init; } 
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.
    /// </summary>
    [IsoId("_4NxqlfsoEeCFJsO61PplcQ")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public required PartyIdentificationAndAccount4 DeliveringAgentDetails { get; init; } 
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_4NxqmfsoEeCFJsO61PplcQ")]
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_4NxqnfsoEeCFJsO61PplcQ")]
    [DisplayName("Place Of Settlement Details")]
    [IsoXmlTag("PlcOfSttlmDtls")]
    public PartyIdentification21? PlaceOfSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
