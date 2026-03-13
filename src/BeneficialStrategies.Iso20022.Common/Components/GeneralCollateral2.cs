// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Repurchase agreement where the agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
/// </summary>
[IsoId("_N9NIEchuEeadgvwNGwK05w")]
[DisplayName("General Collateral")]
public partial record GeneralCollateral2
{
    #nullable enable
    
    /// <summary>
    /// List of the identifiers of the securities eligible for a general collateral repurchase agreement.
    /// </summary>
    [IsoId("_OFpSY8huEeadgvwNGwK05w")]
    [DisplayName("Eligible Financial Instrument Identification")]
    [IsoXmlTag("ElgblFinInstrmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> EligibleFinancialInstrumentIdentification { get; init; } = [];
    // ID for the above is _OFpSY8huEeadgvwNGwK05w
    
    
    #nullable disable
    
}
