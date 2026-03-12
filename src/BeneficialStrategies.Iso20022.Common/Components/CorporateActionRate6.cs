// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rate details.
/// </summary>
[IsoId("_TWA3mNp-Ed-ak6NoX_4Aeg_1311130667")]
[DisplayName("Corporate Action Rate")]
public partial record CorporateActionRate6
{
    #nullable enable
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_TWA3mdp-Ed-ak6NoX_4Aeg_1631591600")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat3Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_TWA3mtp-Ed-ak6NoX_4Aeg_1744261193")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat3Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_TWKokNp-Ed-ak6NoX_4Aeg_2028704129")]
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat4Choice_? NewToOld { get; init; } 
    
    /// <summary>
    /// Quantity of new equities that will be derived by the exercise of a given quantity of intermediate securities.
    /// </summary>
    [IsoId("_TWKokdp-Ed-ak6NoX_4Aeg_2053642046")]
    [DisplayName("New Securities To Underlying Securities")]
    [IsoXmlTag("NewSctiesToUndrlygScties")]
    public RatioFormat4Choice_? NewSecuritiesToUnderlyingSecurities { get; init; } 
    
    
    #nullable disable
    
}
