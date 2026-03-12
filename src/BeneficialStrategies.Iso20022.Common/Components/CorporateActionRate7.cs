// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security rate details.
/// </summary>
[IsoId("_TYGiStp-Ed-ak6NoX_4Aeg_-678980299")]
[DisplayName("Corporate Action Rate")]
public partial record CorporateActionRate7
{
    #nullable enable
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_TYGiS9p-Ed-ak6NoX_4Aeg_-678980281")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat5Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_TYGiTNp-Ed-ak6NoX_4Aeg_-678980238")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat5Choice_? AdditionalQuantityForExistingSecurities { get; init; } 
    
    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_TYQTQNp-Ed-ak6NoX_4Aeg_-678979920")]
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat6Choice_? NewToOld { get; init; } 
    
    /// <summary>
    /// Quantity of new equities that will be derived by the exercise of a given quantity of intermediate securities.
    /// </summary>
    [IsoId("_TYQTQdp-Ed-ak6NoX_4Aeg_-678979878")]
    [DisplayName("New Securities To Underlying Securities")]
    [IsoXmlTag("NewSctiesToUndrlygScties")]
    public RatioFormat6Choice_? NewSecuritiesToUnderlyingSecurities { get; init; } 
    
    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    [IsoId("_TYQTQtp-Ed-ak6NoX_4Aeg_821675097")]
    [DisplayName("Transformation Rate")]
    [IsoXmlTag("TrfrmatnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TransformationRate { get; init; } 
    
    
    #nullable disable
    
}
