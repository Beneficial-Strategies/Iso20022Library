// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the pledge and pledger.
/// </summary>
[IsoId("_xiaQoPQ9EeqAradXpAelDQ")]
[DisplayName("Pledge Information")]
public partial record PledgeInformation1
{
    #nullable enable
    
    /// <summary>
    /// Entity that provide assets to a counterparty as a guarantee.
    /// </summary>
    [IsoId("_C2xUYPQ-EeqAradXpAelDQ")]
    [DisplayName("Pledger")]
    [IsoXmlTag("Pldgr")]
    public required PartyIdentification232Choice_ Pledger { get; init; } 
    
    /// <summary>
    /// Third party, usually a bank, involved in the pledge.
    /// </summary>
    [IsoId("_FfoNAPQ-EeqAradXpAelDQ")]
    [DisplayName("Third Party")]
    [IsoXmlTag("ThrdPty")]
    public ThirdPartyIdentification1? ThirdParty { get; init; } 
    
    /// <summary>
    /// Identifies the type of pledge.
    /// </summary>
    [IsoId("_KBvGQPQ-EeqAradXpAelDQ")]
    [DisplayName("Pledge Type")]
    [IsoXmlTag("PldgTp")]
    public required GenericIdentification36 PledgeType { get; init; } 
    
    /// <summary>
    /// Indicates whether the pledger is entitled to vote, otherwise the right to vote is with the right holder.
    /// </summary>
    [IsoId("_Q7cJAPQ-EeqAradXpAelDQ")]
    [DisplayName("Return Securities Indicator")]
    [IsoXmlTag("RtrSctiesInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReturnSecuritiesIndicator { get; init; } 
    
    
    #nullable disable
    
}
