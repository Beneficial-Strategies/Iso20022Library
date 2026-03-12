// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Costs and charges associated with the distribution or selling of a financial instrument. These may be one-off or recurring charges. These may be intended (ex ante) or actual (ex post).
/// </summary>
[IsoId("_peMCcZ9BEeqxTNfi5y7ywQ")]
[DisplayName("Costs And Charges")]
public partial record CostsAndCharges2
{
    #nullable enable
    
    /// <summary>
    /// Reference date applicable to all ex ante cost and charge disclosures. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07160.
    /// </summary>
    [IsoId("_-J7n4cpmEeqy06E9zwBYlQ")]
    [DisplayName("Ex Ante Reference Date")]
    [IsoXmlTag("ExAnteRefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExAnteReferenceDate { get; init; } 
    
    /// <summary>
    /// Individual cost or charge associated with the distribution of selling of the financial instrument. This may be one-off or recurring. This may be ex ante (intended) or post ante (actual).
    /// </summary>
    [IsoId("_p37YLZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Individual Cost Or Charge")]
    [IsoXmlTag("IndvCostOrChrg")]
    public ValueList<IndividualCostOrCharge2> IndividualCostOrCharge { get; init; } = new ValueList<IndividualCostOrCharge2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _p37YLZ9BEeqxTNfi5y7ywQ
    
    /// <summary>
    /// Additional information about costs and charges.
    /// </summary>
    [IsoId("_p37YL59BEeqxTNfi5y7ywQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
