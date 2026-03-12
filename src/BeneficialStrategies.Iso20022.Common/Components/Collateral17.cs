// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the collateral that will be either delivered, returned or both.
/// </summary>
[IsoId("_XBG5kYpJEeaNTaanBSMWmg")]
[DisplayName("Collateral")]
public partial record Collateral17
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call request.
    /// </summary>
    [IsoId("_XP1SEYpJEeaNTaanBSMWmg")]
    [DisplayName("Margin Call Request Identification")]
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call response.
    /// </summary>
    [IsoId("_XP1SE4pJEeaNTaanBSMWmg")]
    [DisplayName("Margin Call Response Identification")]
    [IsoXmlTag("MrgnCallRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MarginCallResponseIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the standard settlement instructions.
    /// </summary>
    [IsoId("_XP1SFYpJEeaNTaanBSMWmg")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
    /// </summary>
    [IsoId("_XP1SF4pJEeaNTaanBSMWmg")]
    [DisplayName("Collateral Proposal Response Identification")]
    [IsoXmlTag("CollPrpslRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CollateralProposalResponseIdentification { get; init; } 
    
    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    [IsoId("_XP1SGYpJEeaNTaanBSMWmg")]
    [DisplayName("Securities Collateral")]
    [IsoXmlTag("SctiesColl")]
    public SecuritiesCollateral8? SecuritiesCollateral { get; init; } 
    
    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    [IsoId("_XP1SG4pJEeaNTaanBSMWmg")]
    [DisplayName("Cash Collateral")]
    [IsoXmlTag("CshColl")]
    public CashCollateral2? CashCollateral { get; init; } 
    
    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    [IsoId("_XP1SHYpJEeaNTaanBSMWmg")]
    [DisplayName("Other Collateral")]
    [IsoXmlTag("OthrColl")]
    public OtherCollateral5? OtherCollateral { get; init; } 
    
    
    #nullable disable
    
}
