// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides shareholdings information at account sub level.
/// </summary>
[IsoId("_M0-jp_NyEeqRfth943bvEA")]
[DisplayName("Account Sub Level")]
public partial record AccountSubLevel23
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained. Account serviced by the responding intermediary for an account holder.
    /// </summary>
    [IsoId("_NH3qcfNyEeqRfth943bvEA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_NH3qefNyEeqRfth943bvEA")]
    [DisplayName("Account Holder")]
    [IsoXmlTag("AcctHldr")]
    public required PartyIdentification243 AccountHolder { get; init; } 
    
    /// <summary>
    /// Detailed shareholding balance information for an account.
    /// </summary>
    [IsoId("_NH3qe_NyEeqRfth943bvEA")]
    [DisplayName("Shareholding Balance")]
    [IsoXmlTag("ShrhldgBal")]
    public ValueList<ShareholdingBalance1> ShareholdingBalance { get; init; } = [];
    // ID for the above is _NH3qe_NyEeqRfth943bvEA
    
    
    #nullable disable
    
}
