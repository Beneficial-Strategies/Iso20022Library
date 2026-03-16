// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote20.
/// </summary>
[IsoId("_PcEnwVxyEe6fgZt44_IqFA")]
[DisplayName("Vote20")]
public partial record Vote20
{
    #nullable enable

    /// <summary>
    /// Abstain.
    /// </summary>
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; } 

    /// <summary>
    /// Against.
    /// </summary>
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    public FinancialInstrumentQuantity18Choice_? Against { get; init; } 

    /// <summary>
    /// Against Management.
    /// </summary>
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; } 

    /// <summary>
    /// Blank.
    /// </summary>
    [DisplayName("Blank")]
    [IsoXmlTag("Blnk")]
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; } 

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public ValueList<ItemDescription2> Description { get; init; } = [];

    /// <summary>
    /// Discretionary.
    /// </summary>
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; } 

    /// <summary>
    /// For.
    /// </summary>
    [DisplayName("For")]
    [IsoXmlTag("For")]
    public FinancialInstrumentQuantity18Choice_? For { get; init; } 

    /// <summary>
    /// Issuer Label.
    /// </summary>
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    public required IsoMax35Text IssuerLabel { get; init; } 

    /// <summary>
    /// No Action.
    /// </summary>
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; } 

    /// <summary>
    /// One Year.
    /// </summary>
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; } 

    /// <summary>
    /// Proprietary.
    /// </summary>
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryVote2? Proprietary { get; init; } 

    /// <summary>
    /// Resolution Status.
    /// </summary>
    [DisplayName("Resolution Status")]
    [IsoXmlTag("RsltnSts")]
    public required ResolutionStatus2Code ResolutionStatus { get; init; } 

    /// <summary>
    /// Sub Status.
    /// </summary>
    [DisplayName("Sub Status")]
    [IsoXmlTag("SubSts")]
    public ResolutionSubStatus1Code? SubStatus { get; init; } 

    /// <summary>
    /// Three Years.
    /// </summary>
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; } 

    /// <summary>
    /// Two Years.
    /// </summary>
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; } 

    /// <summary>
    /// Withhold.
    /// </summary>
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; } 

    /// <summary>
    /// With Management.
    /// </summary>
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; } 

    
    #nullable disable
    
}
