// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the collateral agreement.
/// </summary>
[IsoId("_KfQr8SgtEeyB747fKu7_rw")]
[DisplayName("Obligation")]
public partial record Obligation11
{
    #nullable enable
    
    /// <summary>
    /// One of the entities associated with the collateral agreement and type of the CCP membership type where the counterparty is a CCP.
    /// </summary>
    [IsoId("_K28zMSgtEeyB747fKu7_rw")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentification242 PartyA { get; init; } 
    
    /// <summary>
    /// Party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_K28zMygtEeyB747fKu7_rw")]
    [DisplayName("Servicing Party A")]
    [IsoXmlTag("SvcgPtyA")]
    public PartyIdentification178Choice_? ServicingPartyA { get; init; } 
    
    /// <summary>
    /// Other entity associated with the collateral agreement and type of the CCP membership type where the counterparty is a CCP.
    /// </summary>
    [IsoId("_K28zNSgtEeyB747fKu7_rw")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification242 PartyB { get; init; } 
    
    /// <summary>
    /// Party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_K28zNygtEeyB747fKu7_rw")]
    [DisplayName("Servicing Party B")]
    [IsoXmlTag("SvcgPtyB")]
    public PartyIdentification178Choice_? ServicingPartyB { get; init; } 
    
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_K28zOSgtEeyB747fKu7_rw")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    [IsoId("_uh2DAyqWEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_K28zOygtEeyB747fKu7_rw")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType11Code? ExposureType { get; init; } 
    
    /// <summary>
    /// Close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_K28zPSgtEeyB747fKu7_rw")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public required DateAndDateTime2Choice_ ValuationDate { get; init; } 
    
    
    #nullable disable
    
}
