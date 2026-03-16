// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
/// </summary>
[IsoId("_wc_c4SgsEeyB747fKu7_rw")]
[DisplayName("Obligation")]
public record Obligation9
{
    /// <summary>
    /// Defines one of the entities associated with the collateral agreement.
    /// </summary>
    [IsoId("_w0_GISgsEeyB747fKu7_rw")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentification178Choice_ PartyA { get; init; }

    /// <summary>
    /// Specifies the party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_w0_GIygsEeyB747fKu7_rw")]
    [DisplayName("Servicing Party A")]
    [IsoXmlTag("SvcgPtyA")]
    public PartyIdentification178Choice_? ServicingPartyA { get; init; }

    /// <summary>
    /// Defines the other entity associated with the collateral agreement.
    /// </summary>
    [IsoId("_w0_GJSgsEeyB747fKu7_rw")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification178Choice_ PartyB { get; init; }

    /// <summary>
    /// Specifies the party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_w0_GJygsEeyB747fKu7_rw")]
    [DisplayName("Servicing Party B")]
    [IsoXmlTag("SvcgPtyB")]
    public PartyIdentification178Choice_? ServicingPartyB { get; init; }

    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_w0_GKSgsEeyB747fKu7_rw")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount3? CollateralAccountIdentification { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    [IsoId("_KiRFAyqQEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Specifies the underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_w0_GKygsEeyB747fKu7_rw")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType11Code? ExposureType { get; init; }

    /// <summary>
    /// Indicates the close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_w0_GLSgsEeyB747fKu7_rw")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public required DateAndDateTime2Choice_ ValuationDate { get; init; }
}
