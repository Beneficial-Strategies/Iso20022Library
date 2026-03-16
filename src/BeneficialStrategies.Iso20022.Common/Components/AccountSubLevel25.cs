// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Sub Level25.
/// </summary>
[IsoId("_w_HKh1x7Ee6fgZt44_IqFA")]
[DisplayName("Account Sub Level25")]
public partial record AccountSubLevel25
{
    #nullable enable

    /// <summary>
    /// Account Holder.
    /// </summary>
    [DisplayName("Account Holder")]
    [IsoXmlTag("AcctHldr")]
    public required PartyIdentification276 AccountHolder { get; init; } 

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public IsoMax35Text? SafekeepingAccount { get; init; } 

    /// <summary>
    /// Shareholding Balance.
    /// </summary>
    [DisplayName("Shareholding Balance")]
    [IsoXmlTag("ShrhldgBal")]
    public ValueList<ShareholdingBalance1> ShareholdingBalance { get; init; } = [];

    
    #nullable disable
    
}
