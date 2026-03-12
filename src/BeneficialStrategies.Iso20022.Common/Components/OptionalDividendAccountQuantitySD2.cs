// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding optional dividend election details.
/// </summary>
[IsoId("_DfVYUUlFEeK8UrXTVVBVxw")]
[DisplayName("Optional Dividend Account Quantity SD")]
public partial record OptionalDividendAccountQuantitySD2
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_D2PccUlFEeK8UrXTVVBVxw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Beneficial owner quantity to be paid.
    /// </summary>
    [IsoId("_D2PchUlFEeK8UrXTVVBVxw")]
    [DisplayName("Beneficial Owner Quantity")]
    [IsoXmlTag("BnfclOwnrQty")]
    public required FinancialInstrumentQuantity15Choice_ BeneficialOwnerQuantity { get; init; } 
    
    /// <summary>
    /// Number of accounts for which the beneficial quantity is elected.
    /// </summary>
    [IsoId("_RkH20ElHEeK8UrXTVVBVxw")]
    [DisplayName("Number Of Accounts")]
    [IsoXmlTag("NbOfAccts")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfAccounts { get; init; } 
    
    
    #nullable disable
    
}
